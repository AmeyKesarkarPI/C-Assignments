using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML;
using ClosedXML.Excel;

namespace GenericPages
{
    public class Person
    {
        public string PageName { get; set; }
        public string PersonName { get; set; }
        public string FriendName { get; set; }
        public static GenericWrapper<Person> perlist = new GenericWrapper<Person>();
        public Person()
        {
        }

        public virtual void DisplayOptions()
        {

        }
    }

    class AddPerson : Person
    {
        public AddPerson()
        {
            PageName = "Add";
        }

        public override void DisplayOptions()
        {
            Person m = new Person();
            Console.WriteLine("Enter Your Name:");
            m.PersonName = Console.ReadLine();
            Console.WriteLine("Enter Friend Name:");
            m.FriendName = Console.ReadLine();
            Console.WriteLine("Person Added Successfully");
            Person.perlist.Add(m);
        }
    }

    class ViewPerson : Person
    {
        public ViewPerson()
        {
            PageName = "View";
        }

        public override void DisplayOptions()
        {
            Console.WriteLine("Products:");
            foreach (var p in Person.perlist.MainList)
            {
                Console.WriteLine(p.PersonName + " and " + p.FriendName + " are friends");
            }
        }
    }

    class ExportPerson : Person
    {
        public ExportPerson()
        {
            PageName = "Export";
        }

        public override void DisplayOptions()
        {
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FilePath = Path.Combine(FilePath, "exportoexcel.xlsx");
            using (IXLWorkbook workbook = new XLWorkbook())
            {
                var ws = workbook.AddWorksheet("GenericExport");

                ws.Cell(1, 1).Value = "Person Name";
                ws.Cell(1, 2).Value = "Friend Name";

                for (int i = 0; i < Person.perlist.MainList.Count; i++)
                {
                    ws.Cell(i + 2, 1).Value = Person.perlist.MainList[i].PersonName;
                    ws.Cell(i + 2, 2).Value = Person.perlist.MainList[i].FriendName;
                }
                workbook.SaveAs(FilePath);
            }
            Console.WriteLine("File Exported Successfully!!!");
        }
    }
}
