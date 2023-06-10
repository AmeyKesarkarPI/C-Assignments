using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Desired IP Address:");
            string ip = Console.ReadLine();
            bool tryAgain = true;
            validateIP(ip);
        }

        static void validateIP(string ip) 
        {
            if (ip[3] == '.')
            {
                int[] subParts = Array.ConvertAll(ip.Split('.'), int.Parse);
                if (subParts[0] == 192)
                {
                    if (subParts[1] <= 0 && subParts[1] >= 255)
                    {
                        Console.WriteLine("Enter valid IP Address:");
                    }
                    else if (subParts[1] <= 0 && subParts[1] >= 255)
                    {
                        Console.WriteLine("Enter valid IP Address:");
                    }
                    else if (subParts[1] <= 0 && subParts[1] >= 255)
                    {
                        Console.WriteLine("Enter valid IP Address:");
                    }
                    else
                    {
                        Console.WriteLine("Valid IP Address:");
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid IP Address:");
                }
            }
            else if (ip[3] == ':')
            {
                int[] subParts = Array.ConvertAll(ip.Split(':'), int.Parse);
                if (subParts[0] == 192)
                {
                    if (subParts[1] <= 0 && subParts[1] >= 255)
                    {
                        Console.WriteLine("Enter valid IP Address:");
                    }
                    else if (subParts[1] <= 0 && subParts[1] >= 255)
                    {
                        Console.WriteLine("Enter valid IP Address:");
                    }
                    else if (subParts[1] <= 0 && subParts[1] >= 255)
                    {
                        Console.WriteLine("Enter valid IP Address:");
                    }
                    else
                    {
                        Console.WriteLine("Valid IP Address:");
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid IP Address:");
                }
            }
            else if (ip[3] == '-')
            {
                int[] subParts = Array.ConvertAll(ip.Split('-'), int.Parse);
                if (subParts[0] == 192)
                {
                    if (subParts[1] <= 0 && subParts[1] >= 255)
                    {
                        Console.WriteLine("Enter valid IP Address:");
                    }
                    else if (subParts[1] <= 0 && subParts[1] >= 255)
                    {
                        Console.WriteLine("Enter valid IP Address:");
                    }
                    else if (subParts[1] <= 0 && subParts[1] >= 255)
                    {
                        Console.WriteLine("Enter valid IP Address:");
                    }
                    else
                    {
                        Console.WriteLine("Valid IP Address:");
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid IP Address:");
                }
            }
            else
            {
                Console.WriteLine("Enter proper IP address");
            }

            Console.ReadLine();
        }
    }
}
