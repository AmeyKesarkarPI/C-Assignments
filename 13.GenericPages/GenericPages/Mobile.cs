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
    public class Mobile
    {
        public string PageName { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public static GenericWrapper<Mobile> moblist = new GenericWrapper<Mobile>();
        public Mobile()
        {
        }



        public virtual void DisplayOptions()
        {

        }
    }

    class AddMobile : Mobile
    {
        public AddMobile()
        {
            PageName = "Add";
        }

        public override void DisplayOptions()
        {
            Mobile m = new Mobile();
            Console.WriteLine("Enter Mobile Name:");
            m.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Mobile Price:");
            m.Price = GetReader.GetInteger("Incorrect Price!!!\nEnter Proper Price:");
            Console.WriteLine("Mobile Added Successfully");
            Mobile.moblist.Add(m);
        }
    }

    class ViewMobile : Mobile
    {
        public ViewMobile()
        {
            PageName = "View";
        }

        public override void DisplayOptions()
        {
            Console.WriteLine("Products:");
            foreach (var p in Mobile.moblist.MainList)
            {
                Console.WriteLine("Name:" + p.ProductName + " -- " + p.Price + " rupees");
            }
        }
    }

    class ExportMobile : Mobile
    {
        public ExportMobile()
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

                ws.Cell(1, 1).Value = "Product Name";
                ws.Cell(1, 2).Value = "Price";

                for (int i = 0; i < Mobile.moblist.MainList.Count; i++)
                {
                    ws.Cell(i + 2, 1).Value = Mobile.moblist.MainList[i].ProductName;
                    ws.Cell(i + 2, 2).Value = Mobile.moblist.MainList[i].Price;
                }
                workbook.SaveAs(FilePath);
            }
            Console.WriteLine("File Exported Successfully!!!");
        }
    }
}
