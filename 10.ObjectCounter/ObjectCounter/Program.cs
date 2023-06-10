using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCounter
{

    public class Persons
    {
        public static int Id { get; set; }

        public Persons()
        {
            Id += 1;
            Console.WriteLine(Id);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Persons p1 = new Persons();
            Persons p2 = new Persons();
            Persons p3 = new Persons();
            Persons p4 = new Persons();
            Console.ReadLine();
        }
    }
}
