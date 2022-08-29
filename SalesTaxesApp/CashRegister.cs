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

namespace SalesTaxesApp
{
    public partial class CashRegister : Form
    {
        public CashRegister()
        {
            InitializeComponent();
            
            cmbProductList.DisplayMember = "Description";
            cmbProductList.ValueMember = "Code";
            cmbProductList.DataSource = Program.inventoryList;                                                            
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Add Product to shopping cart
            String errorMessage = String.Empty;
            Product product = cmbProductList.SelectedItem as Product;
            int lineItem = dgShoppingCart.Rows.Count + 1;
            int quantity = (int)numQuantity.Value;
            bool imported = product.ImportedGood;
            decimal subTotal = product.Price * quantity;
            decimal salesTax = Math.Round((decimal)product.SalesTax * subTotal,2);

            foreach(CartLineItem item in Program.shoppingCart.cartLineItems)
            {
                if (product.Code == item.Code)
                {
                    errorMessage = "Item already exist in the shopping cart";
                    break;
                }
            }

            if (String.IsNullOrEmpty(errorMessage))
                Program.shoppingCart.AddItem(lineItem, product.Code, product.Description, imported, product.Price, quantity, salesTax);
            else
                MessageBox.Show(errorMessage);

            dgShoppingCart.DataSource = Program.shoppingCart.GetCartLineItems().ToList();

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            List<CartLineItem> items = Program.shoppingCart.cartLineItems.ToList();

            if (dgShoppingCart.SelectedRows.Count == 0)
                MessageBox.Show("Please select at least one row");
            else
            {
                foreach (DataGridViewRow row in dgShoppingCart.SelectedRows)
                {
                    string code = row.Cells[1].Value.ToString();

                    foreach (CartLineItem item in Program.shoppingCart.cartLineItems)
                    {
                        if (code == item.Code)
                            items.RemoveAt(item.LineItem - 1);
                    }
                }
            }
            
            Program.shoppingCart.cartLineItems = items;
            dgShoppingCart.DataSource = Program.shoppingCart.GetCartLineItems().ToList();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            var frmReceipt = new Receipt();            
            frmReceipt.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            var frmInventory = new Inventory();
            frmInventory.Show();
        }

        private void btnPopulateWithSample_Click(object sender, EventArgs e)
        {
            //Program.shoppingCart.AddItem(1, "B02", "Hamlet by William Shakespeare", 29.99m, 1, 0.10m );
            //Program.shoppingCart.AddItem(1, "B03", "Moby Dick by Herman Melville", 24.99m, 0, 0.10m);

            ///CartLineItemList.Add(new Product { Code = "B02", Description = "Hamlet by William Shakespeare", ImportedGood = true, Price = 29.99m, ProductType = Enums.ProductTypeEnum.Book });
            //CartLineItemList.Add(new Product { Code = "B03", Description = "Moby Dick by Herman Melville", ImportedGood = false, Price = 24.99m, ProductType = Enums.ProductTypeEnum.Book });
            //CartLineItemList.Add(new Product { Code = "B04", Description = "A Christmas Carol by Charles Dickens", ImportedGood = false, Price = 19.99m, ProductType = Enums.ProductTypeEnum.Book });
            //CartLineItemList.Add(new Product { Code = "M01", Description = "Wrist Brace", ImportedGood = false, Price = 25.99m, ProductType = Enums.ProductTypeEnum.Medical });
            //CartLineItemList.Add(new Product { Code = "M02", Description = "Oximeter Blood Oxygen", ImportedGood = false, Price = 14.90m, ProductType = Enums.ProductTypeEnum.Medical });
        }
    }
}
