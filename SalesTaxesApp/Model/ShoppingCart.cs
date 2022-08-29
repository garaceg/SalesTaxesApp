using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesApp.Model
{
    public class ShoppingCart
    {
        public List<CartLineItem> cartLineItems { get; set; }

        public ShoppingCart()
        {
            cartLineItems = new List<CartLineItem>();
        }

        public void AddItem(int lineItem, string code, string description, bool isImported, decimal price, int quantity, decimal salesTax)
        {            
            cartLineItems.Add(new CartLineItem { LineItem = lineItem, Code = code, Description = description, Price = price, Quantity = quantity, Imported = isImported, SalesTax = salesTax });
        }

        public void RemoveItem(int lineItem)
        {
            cartLineItems.RemoveAt(lineItem - 1);            
        }

        public List<CartLineItem> GetCartLineItems()
        {
            return cartLineItems;
        }

        public decimal SubTotal 
        { 
            get { return cartLineItems.Sum(x => x.SubTotal); }
        }
        public decimal SalesTaxes 
        {
            get { return cartLineItems.Sum(x => x.SalesTax); }
        }
        public decimal Total 
        {
            get { return cartLineItems.Sum(x => x.Total); }
        }
    }
}
