using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace ProductsListing
{
    public partial class Form1 : Form
    {
        private ArrayList products;
        private VisList prodList, gridList;

        private System.Windows.Forms.DataGrid grdProd;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }



        private void DisplayData()
        {
            products = new ArrayList();
            readFile(products); 
            //string[] pro = File.ReadAllLines(@"products.txt", Encoding.UTF8);
            //products.AddRange(pro);
            prodList = new ProductList(lsProd);
            //Bridge to product VisList
            Bridger lbr = new ListBridge(prodList);
            //put the data into the product list
            lbr.addData(products);
            //create the grid VisList
            gridList = new GridList(grdProd);
            //Bridge to the grid list
            Bridger gbr = new ListBridge(gridList);
            //put the data into the grid display
            gbr.addData(products);
        }
        private void readFile(ArrayList products)
        {
            csFile fl = new csFile("products.txt");
            fl.OpenForRead();
            string s = fl.readLine();
            while (s != null)
            {
                Product p = new Product(s);
                products.Add(p);
                s = fl.readLine();
            }
            fl.close();
        }
        
    }
}
