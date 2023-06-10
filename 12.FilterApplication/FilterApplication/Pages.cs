using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FilterApplication
{
    public class Pages
    {
        public List<Pages> OptionList = new List<Pages>();
        public string PageName { get; set; }
        public Pages PreviousPage { get; set; }
        public List<Persons> PersonList = new List<Persons>();
        public List<PersonDbo> PersonDboList = new List<PersonDbo>();
        public Persons Person { get; set; }
        public PersonDbo PersonDbo { get; set; }

        public double Age { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual void InitializeList()
        {
            for (int i = 1; i < 6; i++)
            {
                PersonDbo = new PersonDbo();
                int prev = -i;
                //BirthDate = DateTime.Now.AddYears(prev);
                BirthDate = DateTime.Parse("1993-01-01");
                FName = "sayush";
                LName = "rane";
                PersonDbo.BirthDate = BirthDate;
                PersonDbo.FName = FName;
                PersonDbo.LName = LName;
                PersonDboList.Add(PersonDbo);
            }


            for (int i = 1; i < 6; i++)
            {
                PersonDbo = new PersonDbo();
                int prev = -i * i;
                BirthDate = DateTime.Now.AddYears(prev);
                FName = "ayush";
                LName = "shirke";
                PersonDbo.BirthDate = BirthDate;
                PersonDbo.FName = FName;
                PersonDbo.LName = LName;
                PersonDboList.Add(PersonDbo);
            }

            PersonList = PersonDboList.Select(x => new Persons { FullName = String.Concat(x.FName + " " + x.LName), Age = DateTime.Now.Year - x.BirthDate.Year }).ToList(); 
        }

        public virtual void CalculateAge()
        {

        }

        public virtual void StartsWith()
        {

        }

        public virtual void BirthDateEquals()
        {

        }

        public virtual void BirthDateBetween()
        {

        }

        public virtual void DisplayMenu()
        {
            Console.Clear();
            //Console.WriteLine(menu.MainMenuOption[menu.MainMenuOption.Count - 1]);
            foreach (var MOpt in OptionList)
            {
                Console.WriteLine(OptionList.IndexOf(MOpt) + 1 + " -- " + MOpt.PageName);
            }
            int choice = int.Parse(Console.ReadLine());

            if (choice >= OptionList.Count + 1)
            {
                Console.Clear();
                this.DisplayMenu();
            }

            Console.Clear();
            OptionList[choice - 1].InitializeList();
            OptionList[choice - 1].DisplayMenu();
            //menu.MainMenuOptions[choice].AskChoice();
            Console.ReadLine();
        }
    }
}
