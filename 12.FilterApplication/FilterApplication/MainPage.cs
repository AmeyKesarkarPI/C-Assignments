using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApplication
{
    public class MainPage : Pages
    {
        public MainPage()
        {
            PageName = "Main Page";
            OptionList.Add(new AgeFilter(this));
            OptionList.Add(new FNameFilter(this));
            OptionList.Add(new BirthDateFilter(this));
            OptionList.Add(new BirthDateBetweenFilter(this));
        }
    }
}
