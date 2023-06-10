using ProductCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdcutCatalog
{
    public class ExpiringThisMonth
    {
        public ExpiringThisMonth()
        {
            ExpireDisplay();
        }


        public void ExpireDisplay()
        {
            Console.Clear();
            char line = '_';
            Console.WriteLine("Products expiring this Month:");
            foreach (var p in DemoProducts.viewProductsArr.Where(x => x.Mfgdate.AddMonths(6).Month == DateTime.Now.Month ))
            {
                for (int m = 0; m <= 45; m++)
                {
                    Console.Write(line);
                }
                Console.Write("\n" + p.BrandName + " " + p.ModelName + "(" + p.Price + " rupees )");
                //if (p.Popularity >100
                Console.Write("[ " + p.PopularityStatus + " ]");

                Console.Write("\nCategories          :");
                for (int k = 0; k < p.categories.Length; k++)
                {
                    Console.Write(p.categories[k] + ", ");
                }

                Console.Write("\nStockStatus        :");
                Console.Write(p.StockStatus);

                Console.WriteLine("\nSpecifications:");
                for (int l = 0; l < p.specifications.Count; l++)
                {
                    Console.WriteLine(p.specifications[l].Name + "   " + p.specifications[l].Value);
                }

                Console.WriteLine("Expiry Date    :" + p.Mfgdate.AddMonths(6));

                Console.ForegroundColor = ConsoleColor.White;

                for (int m = 0; m <= 45; m++)
                {
                    Console.Write(line);
                }
            }
        }
    }

}
