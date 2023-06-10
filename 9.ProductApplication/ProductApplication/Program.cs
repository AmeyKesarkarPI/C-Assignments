using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainPage n = new MainPage();
            n.AddDemoProduct();
            do
            {
                MainPage m = new MainPage();
                m.MainMenu();
            }while (true);
        }
    }
}
