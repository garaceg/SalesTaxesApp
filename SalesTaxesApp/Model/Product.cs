using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SalesTaxesApp.Model.Enums;

namespace SalesTaxesApp.Model
{
    public class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductTypeEnum ProductType { get; set; }
        public bool ImportedGood { get; set; }
        public float SalesTax 
        { 
            get
            {

                float salesTax = (ProductType == ProductTypeEnum.Book || ProductType == ProductTypeEnum.Food || ProductType == ProductTypeEnum.Medical) ? 0.0f : 0.10f;

                if (ProductType != ProductTypeEnum.Book &&
                    ProductType != ProductTypeEnum.Food &&
                    ProductType != ProductTypeEnum.Medical)
                {
                    salesTax = 0.10f;
                }

                salesTax = ImportedGood ? salesTax + .05f : salesTax;
                
                return salesTax;
            }
        }
    }
}
