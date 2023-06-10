using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog
{
    internal class Product
    {
        public string BrandName, ModelName;
        public float Price;
        public string[] BrandArray = { "samsung", "apple", "vivo", "oppo", "blackberry", "lg", "1+" };
        public List<Specification> SpecificationDict = new List<Specification>();
        public List<viewProduct> viewProductsArr = new List<viewProduct>();
        DemoProducts demoProducts = new DemoProducts();
        public float PriceProp { get; set; }
        static DateTime ManufactureDate;
        static bool StockAvail;
        private int stockQuantity, CatQuan, SpecQuan;
        private ConsoleColor stockColor = ConsoleColor.White;



        static bool StockOptionMenu()
        {
            bool StockVal = true;
            Console.WriteLine("Enter keys according to the Options: ");
            Console.WriteLine("1:In Stock");
            Console.WriteLine("2:Out Of Stock");
            int choice = GetReader.GetInteger("Invalid Key!!!\n Enter Correct Key:");
            if (choice == 1)
            {
                StockVal = true;
            }
            else if (choice == 2)
            {
                StockVal = false;
            }
            return StockVal;
        }
    }
}
