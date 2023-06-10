using System;
using System.Collections.Generic;

namespace GenericPages
{
    public class Page
    {
        public string PageName { get; set; }
        //public GenericWrapper<Product> GenWrapper;
        //public GenericWrapper<Mobile> GenWrapper;
        public GenericWrapper<Person> GenWrapper;

        public Page()
        {
            //    GenWrapper = new GenericWrapper<Product>();
            //    Product pr = new Product();
            //    GenWrapper.Add(new AddProduct());
            //    GenWrapper.Add(new ViewProduct());
            //    GenWrapper.Add(new ExportProduct());

            //GenWrapper = new GenericWrapper<Mobile>();
            //Mobile mo = new Mobile();
            //GenWrapper.Add(new AddMobile());
            //GenWrapper.Add(new ViewMobile());
            //GenWrapper.Add(new ExportMobile());

            GenWrapper = new GenericWrapper<Person>();
            GenWrapper.Add(new AddPerson());
            GenWrapper.Add(new ViewPerson());
            GenWrapper.Add(new ExportPerson());
        }

        public void DisplayOptions()
        {
            Console.Clear();
            Console.WriteLine(GenWrapper.MainList[GenWrapper.MainList.Count - 1]);
            foreach (var MOpt in GenWrapper.MainList)
            {
                Console.WriteLine(GenWrapper.MainList.IndexOf(MOpt) + 1 + " -- " + MOpt.PageName);
            }
            int choice = GetReader.GetInteger("Incorrect Price!!!\nEnter Proper Price:");

            if (choice >= GenWrapper.MainList.Count + 1)
            {
                Console.Clear();
                this.DisplayOptions();
            }

            Console.Clear();
            GenWrapper.MainList[choice - 1].DisplayOptions();
            //ProductWrapper.MainList[choice].AskChoice();
            Console.ReadLine();
        }
        public virtual void Add()
        {

        }

        public virtual void View()
        {

        }

        public virtual void Export()
        {

        }


    }
}