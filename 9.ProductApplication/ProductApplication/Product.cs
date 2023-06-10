using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    public class Product
    {
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }  
        public string UID { get; set; }
    }
}
