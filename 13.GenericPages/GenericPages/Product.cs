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
    public class Product
    {
        public string PageName { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public static GenericWrapper<Product> prodlist = new GenericWrapper<Product>();
        public Product()
        {
        }

        public virtual void DisplayOptions()
        {

        }
    }

    public class AddProduct : Product
    {

        public AddProduct()
        {
            PageName = "Add";
        }


        public override void DisplayOptions()
        {
            Product p = new Product();
            Console.WriteLine("Enter Product Name:");
            p.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Product Price:");
            p.Price = GetReader.GetInteger("Incorrect Price!!!\nEnter Proper Price:");
            Console.WriteLine("Product Added Successfully");
            Product.prodlist.Add(p);
        }
    }

    class ViewProduct : Product
    {
        public ViewProduct()
        {
            PageName = "View";
        }

        public override void DisplayOptions()
        {
            Console.WriteLine("Products:");
            foreach (var p in Product.prodlist.MainList)
            {
                Console.WriteLine("Name:" + p.ProductName + " -- " + p.Price + " rupees");
            }
        }
    }

    class ExportProduct : Product
    {
        public ExportProduct()
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

                for (int i = 0; i < Product.prodlist.MainList.Count; i++)
                {
                    ws.Cell(i + 2, 1).Value = Product.prodlist.MainList[i].ProductName;
                    ws.Cell(i + 2, 2).Value = Product.prodlist.MainList[i].Price;
                }
                workbook.SaveAs(FilePath);
            }
            Console.WriteLine("File Exported Successfully!!!");
        }
    }
}
