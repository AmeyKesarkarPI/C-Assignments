using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            bool tryAgain;
            int arraySize;
            tryAgain = int.TryParse(Console.ReadLine(), out arraySize);

            int[] intArray = new int[arraySize];
            Console.WriteLine();
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Enter Number:");
                tryAgain = int.TryParse(Console.ReadLine(),out intArray[i]);
            }
            for (int i = 0; i < intArray.Length; i++) 
            {
                Console.Write(intArray[i]);
            }
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.ReadLine();
        }
    }
}
