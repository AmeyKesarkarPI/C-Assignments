using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    public class ViewAllProductPage : MainPage
    {
        public ViewAllProductPage()
        {
            PageName = "View All Products";
        }

        public override void InitializeQuestion()
        {
            ViewAllProduct();
        }


        public override void ViewAllProduct()
        {
            Console.Clear();
            foreach (var productItem in productList.Where(x => x.EndDate == null))
            {
                Console.Write("\n" + productItem.UID + ":  " );
                Console.Write(productItem.BrandName);
                Console.Write("  ( " + productItem.ModelName + " )");
                Console.Write("  [ " + productItem.Price +"rupees ]\n");
            }
        }
    }
}
