using SalesTaxesApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SalesTaxesApp.Model.Enums;

namespace SalesTaxesApp
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();

            // Populates Inventory grid
            dgInventory.DataSource = Program.inventoryList;

            // Populates Product Type list
            cmbProductType.DataSource = Enum.GetValues(typeof(ProductTypeEnum))
                .Cast<ProductTypeEnum>()
                .ToList();            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            StringBuilder sbErrorMessage = new StringBuilder();
            decimal price;
            string code = txtCode.Text.Trim();
            string description = txtDescription.Text.Trim();
            bool isImported = chkImportedGood.Checked;
            ProductTypeEnum productType = (ProductTypeEnum)Enum.Parse(typeof(ProductTypeEnum), cmbProductType.SelectedValue.ToString());
                        
            if (string.IsNullOrEmpty(code))
                sbErrorMessage.AppendLine("code is missing");

            if (string.IsNullOrEmpty(description))
                sbErrorMessage.AppendLine("description is missing");

            if (!decimal.TryParse(mskPrice.Text, out price))
                sbErrorMessage.AppendLine("Invalid Price");

            foreach (Product item in Program.inventoryList)
            {
                if (item.Code == code)
                {
                    sbErrorMessage.AppendLine("Item already exist in the shopping cart");
                    break;
                }
            }

            if (string.IsNullOrEmpty(sbErrorMessage.ToString()))
            {
                Program.inventoryList.Add(new Product { Code = code, Description = description, ImportedGood = isImported, Price = price, ProductType = productType });
            }
            else
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Error");
            }
            
            dgInventory.DataSource = Program.inventoryList.ToList();

            txtCode.Text = String.Empty;
            txtDescription.Text = String.Empty;            
            mskPrice.Text = String.Empty;
            chkImportedGood.Checked = false;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            List<Product> items = Program.inventoryList.ToList();

            if (dgInventory.SelectedRows.Count == 0)
                MessageBox.Show("Please select at least one row");
            else
            {
                foreach (DataGridViewRow row in dgInventory.SelectedRows)
                {
                    string code = row.Cells[0].Value.ToString();

                    foreach (Product item in Program.inventoryList)
                    {
                        if (code == item.Code)
                            items.RemoveAt(row.Index);
                    }
                }
            }

            Program.inventoryList = items;
            dgInventory.DataSource = Program.inventoryList.ToList();
        }
    }
}
