using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetAray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] prefix = { "st", "nd", "rd", "th" };
            Console.WriteLine("Enter Array Size");
            int arraySize = int.Parse(Console.ReadLine());
            bool tryAgain = false;
            int[] intArray = new int[arraySize];
            for (int i = 1; i <= arraySize; i++)
            {
                if ((i - 1) == 0 || (i - 1) % 10 == 0 && i != 11)
                {
                    Console.WriteLine("Enter " + i + prefix[0] + " Number");
                    intArray[i-1] = GetInteger("Enter Correct " + i + prefix[0] + " Number");
                }
                else if ((i - 2) == 0 || (i - 2) % 10 == 0 && i != 12)
                {
                    Console.WriteLine("Enter " + i + prefix[1] + " Number");
                    intArray[i-1] = GetInteger("Enter Correct " + i + prefix[1] + " Number");
                }
                else if ((i - 3) == 0 || (i - 3) % 10 == 0 && i != 13)
                {
                    Console.WriteLine("Enter " + i + prefix[2] + " Number");
                    intArray[i - 1] = GetInteger("Enter Correct " + i + prefix[2] + " Number");
                }
                else
                {
                    Console.WriteLine("Enter " + i + prefix[3] + " Number");
                    intArray[i - 1] = GetInteger("Enter Correct " + i + prefix[3] + " Number");
                }
                if (i != arraySize - 1)
                {
                    tryAgain = false;
                }
            }

            for (int j = 0; j < arraySize; j++)
            {
                if (j == arraySize - 1)
                {
                    Console.Write(intArray[j]);
                } else
                {
                    Console.Write(intArray[j] + ",");
                }
            }
            Console.ReadLine();
        }

        static int GetInteger(string str) 
        {
            bool tryAgain = false;
            int l;
            while (!tryAgain)
            {
                tryAgain = int.TryParse(Console.ReadLine(), out l);
                if (!tryAgain) 
                {
                    Console.WriteLine(str);
                }
                else
                {
                    return l;
                }
            }
            return 1;
        }
    }
}
