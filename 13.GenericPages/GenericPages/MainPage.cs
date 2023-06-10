using System;
using System.Collections.Generic;

namespace GenericPages
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
    }
}