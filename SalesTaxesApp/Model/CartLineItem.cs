using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesApp.Model
{
    /// <summary>
    /// CartLineItem Class
    /// Represents a single record within the Shopping Cart
    /// </summary>
    public class CartLineItem
    {
        public int LineItem { get; set; }        
        public string Code { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool Imported { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal 
        { 
            get { return Quantity * Price; }
        }        
        public decimal SalesTax { get; set; }
        public decimal Total 
        { 
            get { return SubTotal + SalesTax; }
        }
    }
}
