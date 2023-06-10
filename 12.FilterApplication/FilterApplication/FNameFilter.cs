using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApplication
{
    public class FNameFilter : Pages
    {
        public FNameFilter(Pages PreviousPage)
        {
            PageName = "FirstName Starts With S";
            this.PreviousPage = PreviousPage;
        }

        public override void DisplayMenu()
        {
            StartsWith();
        }

        public override void StartsWith()
        {
            foreach (var item in PersonList.Where(y => y.FullName[y.FullName.Length]  == 'S' ).ToList())
            {
                Console.WriteLine("First Name: " + item.FullName + " -- " + item.Age + " years");
            }
        }
    }
}
