using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PlateNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] States = { "MH", "GJ", "RJ", "TN", "KA", "KE", "TL", "OD", "WB", "BH", "CH", "AP", "UP", "MP", "HP", "PU", "JK", "AS" };
            Console.WriteLine("Enter Number Plate");
            string plateNo = Console.ReadLine().ToLower().Trim();
            if (plateNo[3] == ' ')
            {
                string[] plateIdt = plateNo.Split(' ');
                string plate = plateIdt[0].ToString().ToUpper(); 
                if (States.Contains(plate)) 
                {
                    if (Convert.ToInt32(plateIdt[1]) <= 99 && Convert.ToInt32(plateIdt[1]) > 0) 
                    {
                        if (plateIdt[3].Length == 2 && plateIdt[3] == "AA") 
                        {
                            if (Convert.ToInt32(plateIdt[4]) >= 1000 && Convert.ToInt32(plateIdt[4]) <= 9999) 
                            {
                                Console.WriteLine("Valid number plate");
                            }
                        }
                    }
                }
            } else if (plateNo[3] == '-')
            {
                string[] plateIdt = plateNo.Split('-');
                string plate = plateIdt[0].ToString().ToUpper();
                if (States.Contains(plate))
                {
                    if (Convert.ToInt32(plateIdt[1]) <= 99 && Convert.ToInt32(plateIdt[1]) > 0)
                    {
                        if (plateIdt[3].Length == 2 && plateIdt[3] == "AA")
                        {
                            if (Convert.ToInt32(plateIdt[4]) >= 1000 && Convert.ToInt32(plateIdt[4]) <= 9999)
                            {
                                Console.WriteLine("Valid number plate");
                            }
                        }
                    }
                }
            } else 
            {
                Console.WriteLine("Enter correct Number plate");
            }
            Console.ReadLine();
        }
    }
}
