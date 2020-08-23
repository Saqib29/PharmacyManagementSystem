using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee
    {
        string empid;
        public string EmpId
        {
            get { return empid; }
            set { empid = value; }
        }
        string empname;
        public string EmpName
        {
            get { return empname; }
            set { empname = value; }
        }
        int empage;
        public int EmpAge
        {
            get { return empage; }
            set { empage = value; }
        }
        string empphonenum;
        public string EmpPhoneNum
        {
            get { return empphonenum; }
            set { empphonenum = value; }
        }
        double empsalary;
        public double EmpSalary
        {
            get { return empsalary; }
            set { empsalary = value; }
        }
        string empdesignation;
        public string EmpDesignation
        {
            get { return empdesignation; }
            set { empdesignation = value; }
        }
        string empaddress;
        public string EmpAddress
        {
            get { return empaddress; }
            set { empaddress = value; }
        }
        int roll;
        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }
    }
}
