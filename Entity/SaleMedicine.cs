using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SaleMedicine
    {
        string madid;
        public string MadId
        {
            get { return madid; }
            set { madid = value; }
        }
        string madname;
        public string MadName
        {
            get { return madname; }
            set { madname = value; }
        }
        string madcompanyname;
        public string MadCompanyname
        {
            get { return madcompanyname; }
            set { madcompanyname = value; }
        }
        string manufacturingdate;
        public string ManufacturingDate
        {
            get { return manufacturingdate; }
            set { manufacturingdate = value; }
        }
        string expiringdate;
        public string Expiringdate
        {
            get { return expiringdate; }
            set { expiringdate = value; }
        }
        string stockdate;
        public string StockDate
        {
            get { return stockdate; }
            set { stockdate = value; }
        }
        double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        string saledate;

        public string SaleDate
        {
            get { return saledate; }
            set { saledate = value; }
        }
    }
}
