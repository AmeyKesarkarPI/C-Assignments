using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApplication
{
    public class AgeFilter : Pages
    {
        public AgeFilter(Pages PreviousPage)
        {
            PageName = "Age Filter";
            this.PreviousPage = PreviousPage;
        }

        public override void DisplayMenu()
        {
            CalculateAge();
        }
        public override void CalculateAge()
        {
            foreach (var item in PersonList.Where(y => y.Age > 18).ToList())  
            {
                Console.WriteLine("First Name: " + item.FullName + " -- " + item.Age + " years");
            }
        }
    }
}
