using NUnit.Framework;
using SalesTaxesApp.Model;

namespace SalesTaxAppTest
{
    public class Tests
    {        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateSubTotal()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(1, "", "", false, 10, 2, 0.10m);
            shoppingCart.AddItem(2, "", "", false, 10, 1, 0.10m);
            Assert.AreEqual(30, shoppingCart.SubTotal);
        }

        [Test]
        public void CalculateSalesTax()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(1, "", "", false, 10, 2, 0.20m);
            shoppingCart.AddItem(1, "", "", false, 10, 1, 0.10m);
            Assert.AreEqual(0.30, shoppingCart.SalesTaxes);
        }

        [Test]
        public void CalculateTotal()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(1, "", "", false, 10, 2, 0.20m);
            shoppingCart.AddItem(2, "", "", false, 10, 1, 0.10m);
            Assert.AreEqual(30.30, shoppingCart.Total);
        }

        [Test]
        public void IsTaxExempt()
        {
            Product product = new Product();
            product.ProductType = Enums.ProductTypeEnum.Book;
            product.Price = 10;
            Assert.IsTrue(product.SalesTax == 0);
        }

        public void IsNotTaxExempt()
        {
            Product product = new Product();
            product.ProductType = Enums.ProductTypeEnum.Medical;
            product.Price = 10;
            Assert.IsTrue(product.SalesTax != 0);
        }

        [Test]
        public void IsImportedGood()
        {
            Product product = new Product();
            product.ImportedGood = true;            
            Assert.IsTrue(product.ImportedGood);
        }
    }
}