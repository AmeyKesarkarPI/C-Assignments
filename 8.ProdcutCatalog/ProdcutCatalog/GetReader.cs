using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog
{
    public class GetReader
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

        /*
        public static bool GetBool(string str)
        {
            bool tryAgain = false;
            bool boolVal = true;
            while (!tryAgain)
            {
                tryAgain = bool.TryParse(Console.ReadLine(), out boolVal);
                if (!tryAgain)
                {
                    Console.WriteLine(str);
                }
            }
            return boolVal;
        }*/
    }
}
