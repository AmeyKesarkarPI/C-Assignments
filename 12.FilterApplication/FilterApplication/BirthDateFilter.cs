using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApplication
{
    public class BirthDateFilter : Pages
    {
        public BirthDateFilter(Pages PreviousPage)
        {
            PageName = "BirthDate = (1993)";
            this.PreviousPage = PreviousPage;
        }


        public override void DisplayMenu()
        {
            StartsWith();
        }

        public override void StartsWith()
        {

            foreach (var item in PersonDboList.Select(y => new PersonDbo{FName = FName, LName = LName, BirthDate = DateTime.Parse("1993-01-01")}).ToList())
            {
                Console.WriteLine("First Name: " + item.FName + " " + item.LName + " -- " + item.BirthDate + " years");
            }
        }
    }
}
