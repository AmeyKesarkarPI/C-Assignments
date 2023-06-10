using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApplication
{
    public class MainPage
    {
        static MainPageOption menu = new MainPageOption();
        public Product product;
        public static List<Product> productList = new List<Product>();


        public string PageName { get; set; }

        public virtual void InitializeQuestion()
        {
        }


        public string GenerateUniqueID()
        {
            Thread.Sleep(1);
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateUniqueID();
            }
            return r;
        }


        public void AddDemoProduct()
        {
            for (int i = 0; i < 2; i++)
            {
                product = new Product();
                product.UID = GenerateUniqueID();
                product.BrandName = "Apple";
                product.ModelName = "ZZZZZC12";
                product.Price = 234;
                product.StartDate = DateTime.Now;
                product.EndDate = null;
                productList.Add(product);
            }
            for (int i = 0; i < 2; i++)
            {
                product = new Product();
                product.UID = GenerateUniqueID();
                product.BrandName = "Samsung";
                product.ModelName = "1234123";
                product.Price = 123;
                product.StartDate = DateTime.Now;
                product.EndDate = null;
                productList.Add(product);
            }
        }

        public virtual void ViewAllProduct()
        {
        }
        public virtual void EditProduct()
        {
        }
        public virtual void DeleteProduct()
        {
        }
        public virtual void ShowHistory()
        {
        }

        public MainPage()
        {
            PageName = "Main Page";
        }
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("MAIN PAGE");
            foreach (var MOpt in menu.ListMainPageOption)
            {
                Console.WriteLine(menu.ListMainPageOption.IndexOf(MOpt) + 1 + " -- " + MOpt.PageName);
            }
            int choice = int.Parse(Console.ReadLine());

            if (choice >= menu.ListMainPageOption.Count + 1)
            {
                Console.Clear();
                this.MainMenu();
            }
            Console.Clear();
            //menu.ListMainPageOption[choice - 1].AddDemoProduct();
            menu.ListMainPageOption[choice - 1].InitializeQuestion();

            Console.ReadLine();
        }
    }
}
