using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Page m = new Page();
                m.DisplayOptions();
            }while (true);
        }
    }
}
