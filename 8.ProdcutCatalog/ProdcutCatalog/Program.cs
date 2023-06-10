using DocumentFormat.OpenXml.Wordprocessing;
using ProdcutCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog
{
    internal class Program
    {
        static bool ContinueAgain = true;         
        static Product p = new Product();
        static DemoProducts dp = new DemoProducts();
        static SearchByProperty sp;
        static SearchByStockQuantity sq;
        static SearchByBrandName sb;
        static ExpiringThisMonth em;
        static SearchByPrice price;
        static ExportProducts ep;
        static ImportExcel ie;
        static int PopStock;


        static Program()
        {
            dp.AddData();
        }
        static void Main(string[] args)
        {
            while (ContinueAgain)
            {
                Console.WriteLine("1:Add Product");
                Console.WriteLine("2:View Products");
                Console.WriteLine("3:Search by Popularity");
                Console.WriteLine("4:Search by Price");
                Console.WriteLine("5:Search by Brand Name");
                Console.WriteLine("6:Search by Stock Quantity");
                Console.WriteLine("7:Expiring this month");
                Console.WriteLine("8:Export to Excel");
                Console.WriteLine("9:Import to Excel");
                Console.WriteLine("10:Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InitializeQuestions(dp);
                        break;
                    case 2:
                        dp.viewAllProducts();
                        break;
                    case 3:
                        sp = new SearchByProperty();
                        break;
                    case 4:
                        price = new SearchByPrice();
                        break;
                    case 5:
                        sb = new SearchByBrandName();
                        break;
                    case 6:
                        sq = new SearchByStockQuantity();
                        break;
                    case 7:
                        em = new ExpiringThisMonth();
                        break;
                    case 8:
                        ep = new ExportProducts();
                        break;
                    case 9:
                        ie = new ImportExcel();
                        break;
                    case 10:
                        //exit = true;
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        static void InitializeQuestions(DemoProducts dp)
        {
            bool ContinueAgain = true;
            while (ContinueAgain)
            {
                dp.Initialize();
                Console.WriteLine("Want to add More Products?(y/n)");
                string n = Console.ReadLine();
                if (n == "n" || n == "N")
                {
                    break;
                }
                else
                {
                    ContinueAgain = true;
                }
            }
        }

        static void Popularity(DemoProducts dp)
        {
            PopStock  = GetReader.GetInteger("Enter correct Number");
            dp.SearchByPop(PopStock);
        }
    }
}
