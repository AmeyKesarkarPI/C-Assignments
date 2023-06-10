using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    public class DeleteProductPage : MainPage
    {
        public DeleteProductPage()
        {
            PageName = "Delete Product";
        }

        public override void InitializeQuestion()
        {
            DeleteProduct();
        }

        public override void DeleteProduct()
        {
            Console.WriteLine("Enter Product ID: ");
            string ID = Console.ReadLine();

            for (int i = 0; i < productList.Count - 1; i++)
            {
                if (productList[i].UID == ID)
                {
                    Console.WriteLine("Found Product!!!: ");
                    Console.WriteLine("Delete the Product?(y/n)");
                    string confirm = Console.ReadLine();
                    if(confirm == "y") {
                        productList[i].EndDate = DateTime.Now;
                        base.MainMenu();
                    } else
                    {
                        base.MainMenu();
                    }
                }
                else
                {
                    Console.Clear();
                    this.DeleteProduct();
                }
            }
        }
    }


}
