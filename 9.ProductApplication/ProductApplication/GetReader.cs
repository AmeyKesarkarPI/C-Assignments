using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    internal class GetReader
    {
        public static int GetInteger(string str)
        {
            bool tryAgain = false;
            int l = 0;
            while (!tryAgain)
            {
                tryAgain = int.TryParse(Console.ReadLine(), out l);
                if (!tryAgain)
                {
                    Console.WriteLine(str);
                }
            }
            return l;
        }

        public static DateTime GetDate(string str)
        {
            bool tryAgain = false;
            DateTime date = DateTime.Now;
            while (!tryAgain)
            {
                tryAgain = DateTime.TryParse(Console.ReadLine(), out date);
                if (!tryAgain)
                {
                    Console.WriteLine(str);
                }
            }
            return date;
        }


        public static bool GetStockVal(string str, int stockVal)
        {
            bool tryAgain = false;
            while (!tryAgain)
            {
                if (stockVal != 1 || stockVal != 2)
                {
                    Console.WriteLine(str);
                    tryAgain = int.TryParse(Console.ReadLine(), out stockVal);
                }
                else
                {
                    tryAgain = true;
                }
            }
            return tryAgain;
        }
    }
}
