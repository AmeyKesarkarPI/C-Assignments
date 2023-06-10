using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog
{
    public class DemoProducts
    {
        List<viewProduct> viewProductsArr = new List<viewProduct>();
        string BrandName { get; set; }
        string ModelName { get; set; }
        float Price { get; set; }
        //string Popularity;
        string[] categories { get; set; }
        List<Specification> specifications { get; set; } = new List<Specification>();
        int StockQuantity { get; set; }
        DateTime Mfgdate { get; set; }
        ConsoleColor stockColor = ConsoleColor.White;
        PopAndPrice.Popularity High = PopAndPrice.Popularity.High;
        PopAndPrice.Popularity Medium = PopAndPrice.Popularity.Medium;
        PopAndPrice.Popularity Low= PopAndPrice.Popularity.Low;
        public string[] CategoryArray;
        public string[] BrandArray = { "samsung", "apple", "vivo", "oppo", "blackberry", "lg", "1+" };
        public List<Specification> SpecificationDict = new List<Specification>();
        public float PriceProp { get; set; }
        static DateTime ManufactureDate;
        static bool StockAvail;
        private int stockQuantity, CatQuan, SpecQuan;

        //viewProduct vp = new viewProduct();

        public void AddData()
        {
            for (int i = 0; i < 2; i++)
            {
                viewProduct vp = new viewProduct();
                Specification sp = new Specification();
                vp.BrandName = "Samsung";
                vp.ModelName = "ASDASC12";
                categories = new string[3] { "Electronics", "Mobile", "Chip" };
                vp.categories = categories;
                sp.Name = "Color";
                sp.Value = "Red";
                specifications.Add(sp);
                vp.specifications = specifications;
                Price = 123;
                vp.Price = Price;
                StockQuantity = 20;
                vp.StockQuantity = StockQuantity;
                Mfgdate = DateTime.Now.AddMonths(3);
                vp.Mfgdate = Mfgdate;
                viewProductsArr.Add(vp);
            }
            for (int i = 0; i < 2; i++)
            {
                viewProduct vp = new viewProduct();
                Specification sp = new Specification();
                vp.BrandName = "Apple";
                vp.ModelName = "ZZZZZC12";
                categories = new string[3] { "Fruit", "Mobile", "Chip" };
                vp.categories = categories;
                sp.Name = "Color";
                sp.Value = "Black";
                specifications.Add(sp);
                vp.specifications = specifications;

                Price = 234;
                vp.Price = Price;
                StockQuantity = 67;
                vp.StockQuantity = StockQuantity;
                Mfgdate = DateTime.Now.AddMonths(-3);
                vp.Mfgdate = Mfgdate;
                viewProductsArr.Add(vp);
            }
        }

        public void AddObjectData(string BrandName, string ModelName, string[] CategoryArray, List<Specification> SpecificationDict,float Price,int StockQuantity,DateTime ManufactureDate)
        {
            
            //Console.WriteLine(vProduct.BrandName);
        }

        public void viewAllProducts()
        {
            char line = '_';
            //Console.Clear();
            for (int i = 0; i < viewProductsArr.Count; i++)
            {
                for (int m = 0; m <= 45; m++)
                {
                    Console.Write(line);
                }
                Console.Write("\n" + viewProductsArr[i].BrandName + " " + viewProductsArr[i].ModelName + "(" + viewProductsArr[i].Price + " rupees )");
                //if (viewProductsArr[i].Popularity >100
                Console.Write("[ " + "Popularity" + " ]");
                Console.Write("\nCategories          :");
                for (int k = 0; k < viewProductsArr[i].categories.Length; k++)
                {
                    Console.Write(viewProductsArr[i].categories[k] + ", ");
                }
                Console.WriteLine("\nSpecifications:");
                for (int l = 0; l < viewProductsArr[i].specifications.Count; l++)
                {
                    Console.WriteLine(viewProductsArr[i].specifications[l].Name + "   " + viewProductsArr[i].specifications[l].Value);
                }
                Console.WriteLine("Expiry Date    :" + viewProductsArr[i].Mfgdate.AddMonths(6));
                Console.Write("Stock Quantity  :" + viewProductsArr[i].StockQuantity);
                if (viewProductsArr[i].StockQuantity < 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine("        #");
                Console.ForegroundColor = ConsoleColor.White;

                for (int m = 0; m <= 45; m++)
                {
                    Console.Write(line);
                };
            }

        }


        public int StockQuantityProp
        {
            get { return stockQuantity; }
            set
            {
                if (value <= 50)
                {
                    stockColor = ConsoleColor.Red;
                }
                else
                {
                    stockColor = ConsoleColor.Green;
                }
            }
        }

        public void Initialize()
        {
            Console.Clear();
            Console.WriteLine("Enter Brand Name: ");
            BrandName = BrandValidation("Invalid Brand Name!!!\nEntervalid Brand Name:", BrandArray);

            Console.WriteLine("Enter Model Name: ");
            ModelName = Console.ReadLine();

            Console.WriteLine("How many number of Categories?: ");
            CatQuan = GetReader.GetInteger("Enter proper Number");
            CategoryArray = Categories(CatQuan);

            Console.WriteLine("Enter Price: ");
            Price = GetReader.GetInteger("Enter Correct Price");

            Console.WriteLine("How many number of Specifications?");
            SpecQuan = GetReader.GetInteger("Enter proper Number");
            SpecificationDict = Specification(SpecQuan);

            Console.WriteLine("Enter Manufacture Date: ");
            ManufactureDate = GetReader.GetDate("Enter Proper Date");

            Console.WriteLine("Enter Stock Quantity");
            StockQuantityProp = GetReader.GetInteger("Enter Correct Stock Quantity");

            viewProduct vp = new viewProduct();
            vp.BrandName = BrandName;
            vp.ModelName = ModelName;
            vp.categories = CategoryArray;
            vp.specifications = SpecificationDict;
            vp.Price = Price;
            vp.StockQuantity = StockQuantity;
            vp.Mfgdate = ManufactureDate;
            viewProductsArr.Add(vp);

            //demoProducts.AddObjectData(BrandName, ModelName, CategoryArray, SpecificationDict, Price, StockQuantity, ManufactureDate);
        }

        public List<Specification> Specification(int spec)
        {
            string key, value;
            List<Specification> keyValuePairs = new List<Specification>();
            for (int i = 0; i < spec; i++)
            {
                Specification sp = new Specification();
                Console.WriteLine("Spec" + i + "Name: ");
                key = Console.ReadLine();
                Console.WriteLine("Spec" + i + "Value: ");
                value = Console.ReadLine();
                sp.Name = key;
                sp.Value = value;
                keyValuePairs.Add(sp);
            }
            return keyValuePairs;
        }

        public string BrandValidation(string msg, string[] brandArray)
        {
            string brandName = "";
            brandName = Console.ReadLine().Trim();
            bool tryAgain = brandArray.Contains(brandName);
            while (!tryAgain)
            {
                Console.WriteLine(msg);
                brandName = Console.ReadLine().Trim();
                tryAgain = brandArray.Contains(brandName);
            }
            return brandName;
        }

        public string[] Categories(int quan)
        {
            string[] categories = new string[quan];
            for (int i = 0; i < quan; i++)
            {
                Console.WriteLine("Category" + (i + 1) + ": ");
                categories[i] = Console.ReadLine();
            }
            return categories;
        }
    }
}
