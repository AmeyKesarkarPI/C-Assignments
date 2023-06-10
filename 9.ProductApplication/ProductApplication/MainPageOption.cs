using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    internal class MainPageOption
    {
        public List<MainPage> ListMainPageOption;

        public MainPageOption()
        {
            ListMainPageOption = new List<MainPage>();
            ListMainPageOption.Add(new AddProductPage());
            ListMainPageOption.Add(new ViewAllProductPage());
            ListMainPageOption.Add(new EditProductPage());
            ListMainPageOption.Add(new DeleteProductPage());
            ListMainPageOption.Add(new ShowProductHistory());
        }
    }
}
