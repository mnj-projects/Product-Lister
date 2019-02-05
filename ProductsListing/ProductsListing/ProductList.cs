using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsListing
{
    public class ProductList : VisList
    {
        private ListBox list;
        //-----
        public ProductList(ListBox lst)
        {
            list = lst;
        }
        //-----
        public void addLine(Product p)
        {
            list.Items.Add(p.getName());
        }
        //-----
        public void removeLine(int num)
        {
            if (num >= 0 && num < list.Items.Count)
            {
                list.Items.Remove(num);
            }
        }
    }
}
