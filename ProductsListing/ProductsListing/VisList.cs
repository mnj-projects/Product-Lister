using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsListing
{
    public interface VisList
    {
        //add a line to the display
        void addLine(Product p);
        //remove a line from the display
        void removeLine(int num);
    }
}
