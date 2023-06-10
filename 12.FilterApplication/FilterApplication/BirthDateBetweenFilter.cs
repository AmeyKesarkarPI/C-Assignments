using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApplication
{
    public class BirthDateBetweenFilter : Pages
    {
        public BirthDateBetweenFilter(Pages PreviousPage)
        {
            PageName = "BirthDate (2000-2005)";
            this.PreviousPage = PreviousPage;
        }

        public override void DisplayMenu()
        {
            StartsWith();
        }

        public override void StartsWith()
        {
            foreach (var item in PersonList.Where(y => y.Age < 18 && y.Age >= 13).ToList())
            {
                Console.WriteLine("First Name: " + item.FullName + " -- " + item.Age + " years");
            }
        }
    }
}
