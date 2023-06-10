using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqListConversion
{
    public class PersonData
    {
        public List <PersonDBODetails> ListPersonDBODetails  = new List <PersonDBODetails> ();
        public PersonDBODetails ObjPersonDBODetails { get; set; }

        public PersonData()
        {
            for (int i = 1; i <= 5; i++)
            {
                ObjPersonDBODetails = new PersonDBODetails();
                int prev = -i;
                ObjPersonDBODetails.DOB = DateTime.Now.AddYears(prev);
                ObjPersonDBODetails.FirstName = "Ayush";
                ObjPersonDBODetails.LastName = "Shirke";
                ListPersonDBODetails.Add(ObjPersonDBODetails);
            }


            for (int i = 1; i <= 5; i++)
            {
                ObjPersonDBODetails = new PersonDBODetails();
                int prev = -i * i;
                ObjPersonDBODetails.DOB = DateTime.Now.AddYears(prev);
                ObjPersonDBODetails.FirstName = "Chaitanya";
                ObjPersonDBODetails.LastName = "Rane";
                ListPersonDBODetails.Add(ObjPersonDBODetails);
            }
        }
    }
}
