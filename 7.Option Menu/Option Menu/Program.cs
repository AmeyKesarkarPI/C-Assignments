using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Option_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor white = ConsoleColor.White;
            ConsoleColor red = ConsoleColor.Red;
            ConsoleColor green = ConsoleColor.Green;
            ConsoleColor blue = ConsoleColor.Blue;
            int milliSecs = 400;
            int[] intArray = { 10, 15, 1, 99, 75, 76, 114, 88, 89, 17, 16, 51, 33, 100, 101, 102 };
            bool exit = false;
            while (exit == false)
            {
                Loading(milliSecs,red);
                Loading(milliSecs, green);
                Loading(milliSecs, blue);
                Console.ForegroundColor = white;
                displayText(intArray);
                Console.WriteLine("\n1:Largest Number");
                Console.WriteLine("2:Smallest Number");
                Console.WriteLine("3:Calculte Average");
                Console.WriteLine("4:Calculate Sum");
                Console.WriteLine("5:Calculate Average");
                Console.WriteLine("ESC:Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int largestNumber = largestNum(intArray);
                        Console.WriteLine("Largest Number: " + largestNumber);
                        break;
                    case 2:
                        int smallestNumber = smallestNum(intArray);
                        Console.WriteLine("Smallest Number: " + smallestNumber);
                        break;
                    case 3:
                        double avg = calculateAvg(intArray);
                        Console.WriteLine("Average: " + avg);
                        break;
                    case 4:
                        int sum = calculateSum(intArray);
                        Console.WriteLine("Sum: " + sum);
                        break;
                    case 5:
                        successivePair(intArray);
                        break;
                    case 6:
                        exit = true;
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            Console.ReadLine();
        }
        static int largestNum(int[] intArray)
        {
            int largest = 0;
            int temp;
            for (int i = 0; i < intArray.Length; i++)
            {
                temp = intArray[i];
                if (temp > largest)
                {
                    largest = temp;
                }
            }
            return largest;
        }
        static int smallestNum(int[] intArray)
        {
            int smallest = intArray[0];
            int temp;
            for (int i = 0; i < intArray.Length; i++)
            {
                temp = intArray[i];
                if (temp < smallest)
                {
                    smallest = temp;
                }
            }
            return smallest;
        }
        static double calculateAvg(int[] intArray)
        {
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            double avg = sum / intArray.Length;
            return avg;
        }

        static int calculateSum(int[] intArray)
        {

            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            return sum;
        }
        static void successivePair(int[] intArray)
        {
            int i = 0;
            Console.WriteLine("Successive Pairs:");

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
        }
        static void displayText(int[] intArray)
        {
            int j = 0;
            Console.Write("Array = [");
            for (j = 0; j < intArray.Length; j++)
            {
                if (j == intArray.Length - 1)
                {
                    Console.Write(intArray[j] + "]");
                }
                else
                {
                    Console.Write(intArray[j] + ",");
                }
            }
        }

        static void Loading(int milliSecs ,ConsoleColor color)
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
