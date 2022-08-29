using SalesTaxesApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTaxesApp
{    
    internal static class Program
    {
        public static ShoppingCart shoppingCart = new ShoppingCart();
        public static List<Product> inventoryList = new List<Product>();        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Init Inventory            
            inventoryList.Add(new Product { Code = "B01", Description = "Don Quixote by Miguel de Cervantes Saveedra", ImportedGood = true, Price = 29.99m, ProductType = Enums.ProductTypeEnum.Book });
            inventoryList.Add(new Product { Code = "B02", Description = "Hamlet by William Shakespeare", ImportedGood = true, Price = 29.99m, ProductType = Enums.ProductTypeEnum.Book });
            inventoryList.Add(new Product { Code = "B03", Description = "Moby Dick by Herman Melville", ImportedGood = false, Price = 24.99m, ProductType = Enums.ProductTypeEnum.Book });
            inventoryList.Add(new Product { Code = "B04", Description = "A Christmas Carol by Charles Dickens", ImportedGood = false, Price = 19.99m, ProductType = Enums.ProductTypeEnum.Book });
            inventoryList.Add(new Product { Code = "M01", Description = "Wrist Brace", ImportedGood = false, Price = 25.99m, ProductType = Enums.ProductTypeEnum.Medical });
            inventoryList.Add(new Product { Code = "M02", Description = "Oximeter Blood Oxygen", ImportedGood = false, Price = 14.90m, ProductType = Enums.ProductTypeEnum.Medical });
            inventoryList.Add(new Product { Code = "F01", Description = "Avocado", ImportedGood = false, Price = 2.99m, ProductType = Enums.ProductTypeEnum.Food });
            inventoryList.Add(new Product { Code = "F02", Description = "Atlantic Salmon Fillet", ImportedGood = false, Price = 12.99m, ProductType = Enums.ProductTypeEnum.Food });
            inventoryList.Add(new Product { Code = "H01", Description = "Colnago Road Bike", ImportedGood = true, Price = 16000m, ProductType = Enums.ProductTypeEnum.Exercise });
            inventoryList.Add(new Product { Code = "E01", Description = "Apple Airpods Pro", ImportedGood = false, Price = 179.99m, ProductType = Enums.ProductTypeEnum.Electronics });
            inventoryList.Add(new Product { Code = "E02", Description = "Bits Fit Pro Earbuds", ImportedGood = false, Price = 199.99m, ProductType = Enums.ProductTypeEnum.Electronics });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CashRegister());                        
        }
    }
}
