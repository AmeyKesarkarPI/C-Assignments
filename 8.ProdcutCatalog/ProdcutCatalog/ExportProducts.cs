using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ProductCatalog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdcutCatalog
{
    public class ExportProducts
    {
        public ExportProducts()
        {
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FilePath = Path.Combine(FilePath, "exportoexcel.xlsx");
            ExportList<viewProduct>(DemoProducts.viewProductsArr, FilePath, "Product");
            Console.WriteLine("Product Catalog Exported to Excel !!!");
        }

        public bool ExportList<T>(List<viewProduct> list, string FilePath, string SheetName)
        {
            bool Exported = false;
            using (IXLWorkbook workbook = new XLWorkbook())
            {
                var ws = workbook.AddWorksheet(SheetName);

                ws.Cell(1, 1).Value = "Brand Name";
                ws.Cell(1, 2).Value = "Model Name";
                ws.Cell(1, 3).Value = "Price";
                ws.Cell(1, 4).Value = "Popularity Status";
                ws.Cell(1, 5).Value = "Categories";
                ws.Cell(1, 6).Value = "Stock Status";
                ws.Cell(1, 7).Value = "Specifications";
                ws.Cell(1, 8).Value = "Expiry Date";

                for (int i = 0; i < list.Count; i++)
                {
                    ws.Cell(i + 2, 1).Value = list[i].BrandName;
                    ws.Cell(i + 2, 2).Value = list[i].ModelName;
                    ws.Cell(i + 2, 3).Value = list[i].Price;
                    ws.Cell(i + 2, 4).Value = list[i].PopularityStatus;
                    for (int j = 0; j < list[i].categories.Count(); j++)
                    {
                        if(j == list[i].categories.Count() - 1)
                        {
                            ws.Cell(i + 2, 5).Value += list[i].categories[j];
                        }else
                        {
                            ws.Cell(i + 2, 5).Value += list[i].categories[j] + ", ";
                        }
                    }
                    ws.Cell(i + 2, 6).Value = list[i].StockStatus; 
                    for (int k = 0; k < list[i].specifications.Count(); k++)
                    {
                        if (k == list[i].specifications.Count() - 1)
                        {
                            ws.Cell(i + 2, 7).Value += list[i].specifications[k].Name + " : " + list[i].specifications[k].Value;
                        }
                        else
                        {
                            ws.Cell(i + 2, 7).Value += list[i].specifications[k].Name + " : " + list[i].specifications[k].Value + " , ";
                        }
                    }
                    ws.Cell(i + 2, 8).Value = list[i].Mfgdate.AddMonths(6);
                }
                workbook.SaveAs(FilePath);
                Exported = true;

            }
            return Exported;
        }
    }
}
