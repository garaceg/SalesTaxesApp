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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();

            StringBuilder sbReceipt = new StringBuilder();

            foreach(CartLineItem item in Program.shoppingCart.GetCartLineItems())
            {                
                if (item.Imported)
                    sbReceipt.AppendFormat("{0} Imported {1}: ${2}", item.Quantity, item.Description, item.Price);
                else
                    sbReceipt.AppendFormat("{0} {1}: ${2}", item.Quantity, item.Description, item.Price);

                sbReceipt.Append(Environment.NewLine);
            }

            sbReceipt.AppendFormat("Sales Taxes: ${0}", Program.shoppingCart.SalesTaxes);
            sbReceipt.Append(Environment.NewLine);
            sbReceipt.AppendFormat("Total: ${0}", Program.shoppingCart.Total);
            sbReceipt.Append(Environment.NewLine);

            txtReceipt.Text = sbReceipt.ToString();            
            txtReceipt.DeselectAll();
        }
    }
}
