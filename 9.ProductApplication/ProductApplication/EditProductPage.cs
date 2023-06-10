using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    public class EditProductPage : MainPage
    {
        public EditProductPage()
        {
            PageName = "Edit Products";
        }

        public override void InitializeQuestion()
        {
            EditProduct();
        }

        public override void EditProduct()
        {
            Console.WriteLine("Enter Product ID: ");
            string ID = Console.ReadLine();

            for(int i = 0; i < productList.Count-1; i++) 
            {
                if (productList[i].UID == ID)
                {
                    productList[i].EndDate = DateTime.Now;
                    EditInitializeQuestion(ID);
                    break;
                }else
                {
                    Console.Clear();
                    this.EditProduct();
                }
            }
        }


        public string[] BrandArray = { "samsung", "apple", "vivo", "oppo", "blackberry", "lg", "1+" };

        public void EditInitializeQuestion(string uid)
        {
            product = new Product();
            Console.Clear();

            product.UID  = uid;
            Console.WriteLine("Found Product!!!: ");
            Console.WriteLine("Enter Brand Name: ");
            product.BrandName = BrandValidation("Invalid Brand Name!!!\nEntervalid Brand Name:", BrandArray);
            Console.WriteLine("Enter Model Name: ");
            product.ModelName = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            product.Price = GetReader.GetInteger("Enter Correct Price");
            product.StartDate = (DateTime)DateTime.Now;
            product.EndDate = null;
            productList.Add(product);
            Console.WriteLine("Product Modified!!!");
            //ContinueQuestions();
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
