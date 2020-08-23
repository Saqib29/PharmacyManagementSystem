using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Manager
    {
        string manid;
        public string ManId
        {
            get { return manid; }
            set { manid = value; }
        }
        string manname;
        public string ManName
        {
            get { return manname; }
            set { manname = value; }
        }
        int manage;
        
        string manphone;
        public string manPhone
        {
            get { return manphone; }
            set { manphone = value; }
        }
        string manaddress;
        public string ManAddress
        {
            get { return manaddress; }
            set { manaddress = value; }
        }
    }
}
