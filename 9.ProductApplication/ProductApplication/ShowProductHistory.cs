using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    public class ShowProductHistory : MainPage
    {
        public ShowProductHistory()
        {
            PageName = "Show Product History";
        }


        public override void InitializeQuestion()
        {
            ShowHistory();
        }

        public override void ShowHistory()
        {
            Console.WriteLine("Product History: ");

            foreach (var product in productList.OrderBy(x => x.UID).ThenBy(y => y.StartDate))
            {
                Console.Write("\n" + product.UID + ":  ");
                Console.Write(product.BrandName);
                Console.Write("  ( " + product.ModelName + " )");
                Console.Write("  [ " + product.Price + "rupees ]\n");
            }
        }

    }
}
