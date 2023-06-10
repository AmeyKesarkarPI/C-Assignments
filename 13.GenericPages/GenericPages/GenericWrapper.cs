using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPages
{
    public class GenericWrapper<T> 
    {
        public List<T> MainList = new List<T>();
        public GenericWrapper()
        {
            MainList = new List<T>();
        }

        public void Add(T t)
        {
            MainList.Add(t);
        }
    }
}
