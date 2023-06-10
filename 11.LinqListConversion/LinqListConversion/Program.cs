using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinqListConversion
{
    public class Program
    {
        public class AllFunctions
        {
            DateTime now = DateTime.Now;
            public double age;
        }

        static void Main(string[] args)
        {
            PersonData InsPersonDBO = new PersonData();
            Person InsPerson = new Person();
            //AllFunctions fns = new AllFunctions();
            //List<PersonDetails> ListPersonDetails = new List<PersonDetails>();
            //List<PersonDBODetails> ListPersonDBODetails = new List<PersonDBODetails>();

            InsPerson.ListPersonDetails = InsPersonDBO.ListPersonDBODetails.Select(x => new PersonDetails { FullName = String.Concat(x.FirstName + " " + x.LastName), Age = DateTime.Now.Year - x.DOB.Year }).ToList();

            foreach (var v in InsPerson.ListPersonDetails)
            {
                Console.WriteLine("Name:" + v.FullName);
                Console.WriteLine("Age:" + v.Age + " years");
            }
            Console.ReadLine();
        }

    }
}
