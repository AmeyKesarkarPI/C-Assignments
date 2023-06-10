using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqListConversion
{
    public class Person
    {
        public double Age { get; set; }
        public string FullName { get; set; }
        public List<PersonDetails> ListPersonDetails { get; set; }
        public PersonDetails ObjPersonDetails { get; set; }

        public Person()
        {
        }
    }
}
