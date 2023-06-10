using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuccessivePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Array:");
            ConsoleColor white = ConsoleColor.White;
            ConsoleColor red = ConsoleColor.Red;
            ConsoleColor green = ConsoleColor.Green;
            ConsoleColor blue = ConsoleColor.Blue;
            int milliSecs = 400;
            int[] intArray = { 10, 15, 1, 99, 75, 76, 114, 88, 89, 17, 16, 51, 33, 100, 101, 102 };
            int i = 0;
            int j = 0;
            Loading(milliSecs, red);
            Loading(milliSecs,green);
            Loading(milliSecs, blue);
            Console.ForegroundColor = white;
            Console.Write("Array = [");
            for (j = 0; j < intArray.Length; j++)
            {
                if (j == intArray.Length-1)
                {
                    Console.Write(intArray[j] + "]");
                }
                else
                {
                    Console.Write(intArray[j] + ",");
                }
            }

            Console.WriteLine("\nSuccessive Pairs:");
            while (i != intArray.Length - 2)
            {
                int counter1 = intArray[i + 1];
                int counter2 = intArray[i];
                if (counter2 + 1 == counter1)
                {
                    if (counter1 + 1 == intArray[i + 2])
                    {
                        Console.WriteLine(counter2 + "," + counter1 + "," + intArray[i + 2]);
                    }
                    else
                    {
                        Console.WriteLine(counter2 + "," + counter1);
                    }
                }
                i++;
            }
            Console.ReadLine();
        }

        static void Loading(int milliSecs, ConsoleColor color)
        {
            string loading = "Loading";
            string dot = ".";
            Console.ForegroundColor = color;
            Console.Write(loading);
            Console.SetCursorPosition(0, 0);
            Thread.Sleep(milliSecs);
            Console.Write(loading + " " + dot);
            Console.SetCursorPosition(0, 0);
            Thread.Sleep(milliSecs);
            Console.Write(loading + " " + dot + dot);
            Console.SetCursorPosition(0, 0);
            Thread.Sleep(milliSecs);
            Console.Write(loading + " " + dot + dot + dot);
            Console.SetCursorPosition(10, 0);
            Thread.Sleep(milliSecs);
            Console.WriteLine(" ");
            Console.SetCursorPosition(9, 0);
            Thread.Sleep(milliSecs);
            Console.WriteLine(" ");
            Console.SetCursorPosition(8, 0);
            Thread.Sleep(milliSecs);
            Console.WriteLine(" ");
            Console.Clear();
        }
    }
}
