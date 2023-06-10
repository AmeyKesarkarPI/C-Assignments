using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ProductCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProdcutCatalog
{
    public class ImportExcel
    {

        public List<Specification> specifications { get; set; } = new List<Specification>();
        public ImportExcel()
        {
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FilePath = Path.Combine(FilePath, "exportoexcel.xlsx");
            Console.Clear();
            ImportList<viewProduct>(DemoProducts.viewProductsArr, FilePath, "Product");
            Console.WriteLine("Product Catalog Imported Successfully !!!");
        }

        public bool ImportList<T>(List<viewProduct> list, string FilePath, string SheetName)
        {
            list.Clear();
            bool Exported = false;
            using (IXLWorkbook workbook = new XLWorkbook(FilePath))
            {
                var ws = workbook.Worksheet(SheetName);
                int col = ws.Column(1).LastCellUsed().Address.RowNumber;

                for (int i = 0; i < col - 1; i++ )
                {
                    viewProduct vp = new viewProduct();
                    Specification sp = new Specification();
                    vp.BrandName = ws.Cell(i + 2,1).Value.ToString();
                    vp.ModelName = ws.Cell(i + 2, 2).Value.ToString();
                    vp.Price = Convert.ToInt32(ws.Cell(i + 2, 3).Value);
                    vp.PopularityStatus = ws.Cell(i + 2, 4).Value.ToString();
                    string cat = ws.Cell(i + 2, 5).Value.ToString(); 
                    string[] catArr = cat.Split(',');
                    vp.categories = catArr;
                    vp.StockStatus = ws.Cell(i + 2, 6).Value.ToString();
                    string spec = ws.Cell(i + 2, 7).Value.ToString();
                    string[] specArr = spec.Split(',');
                    for (int k = 0; k < specArr.Length ; k++)
                    {
                        if(i == k)
                        {
                            string[] specific = specArr[k].Split(':');
                            sp.Name = specific[0];
                            sp.Value = specific[1];
                        }
                    }

                    specifications.Add(sp);
                    vp.specifications = specifications;
                    vp.Mfgdate = Convert.ToDateTime(ws.Cell(i + 2, 8).Value);
                    list.Add(vp);
                }
            }
            return Exported;
        }
    }
}
