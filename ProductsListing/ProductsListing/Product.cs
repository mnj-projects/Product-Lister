using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsListing
{
    public class Product : IComparable
    {
        private string quantity;
        private string name;
        //-----
        public Product(string line)
        {
            int i = line.IndexOf("--");
            name = line.Substring(0, i).Trim();
            quantity = line.Substring(i + 2).Trim();
        }
        //-----
        public string getQuantity()
        {
            return quantity;
        }
        //-----
        public string getName()
        {
            return name;
        }
        //-----
        public int CompareTo(object p)
        {
            Product prod = (Product)p;
            return name.CompareTo(prod.getName());
        }
    }
}
