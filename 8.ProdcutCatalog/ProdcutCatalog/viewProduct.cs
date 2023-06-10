using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog
{
    public class viewProduct
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public float Price { get; set; }
        public string[] categories { get; set; }
        public List<Specification> specifications { get; set; }
        public int StockQuantity { get; set; }
        public int Popularity { get; set; }
        public string StockStatus { get; set; }
        public string PopularityStatus { get; set; }
        public DateTime Mfgdate { get; set; }
    }
}
