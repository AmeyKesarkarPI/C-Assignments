using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    public class AddProductPage : MainPage
    {
        public string[] BrandArray = { "samsung", "apple", "vivo", "oppo", "blackberry", "lg", "1+" };

        public AddProductPage()
        {
            PageName = "Add Product";
        }

        public override void InitializeQuestion()
        {
            product = new Product();
            Console.Clear();

            product.UID = GenerateUniqueID();
            product.Price = GetReader.GetInteger("Enter Correct Price");
            Console.WriteLine("Enter Brand Name: ");
            product.BrandName = BrandValidation("Invalid Brand Name!!!\nEntervalid Brand Name:", BrandArray);
            Console.WriteLine("Enter Model Name: ");
            Console.WriteLine("Enter Price: ");
            product.ModelName = Console.ReadLine();
            product.StartDate = (DateTime)DateTime.Now;
            product.EndDate = null;
            productList.Add(product);
            ContinueQuestions();
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

        public void ContinueQuestions()
        {
            bool ContinueAgain = true;
            while (ContinueAgain)
            {
                Console.WriteLine("Want to add More Products?(y/n)");
                string n = Console.ReadLine();
                if (n == "n" || n == "N")
                {
                    base.MainMenu();
                }
                else
                {
                    InitializeQuestion();
                    ContinueAgain = true;
                }
            }
        }
    }
}
