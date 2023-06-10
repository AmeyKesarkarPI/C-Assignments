using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNum = 11;
            int count = 0;
            for (int i =0; i < intNum; i++)
            {
                if (i % 2 == 0) 
                {
                    count++;
                }
            }
            Console.WriteLine(count + " odd numbers exists from 0  to " + intNum);
            Console.ReadLine();
        }
    }
}
