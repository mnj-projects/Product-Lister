using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProductsListing
{
    public class ListBridge : Bridger
    {
        protected VisList vis;
        //------
        public ListBridge(VisList v)
        {
            vis = v;
        }
        //-----
        public virtual void addData(ArrayList ar)
        {
            for (int i = 0; i < ar.Count; i++)
            {
                Product p = (Product)ar[i];
                vis.addLine(p);
            }
        }
    }
}
