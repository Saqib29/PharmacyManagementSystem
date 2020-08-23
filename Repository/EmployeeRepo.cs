using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Interfaces;
using System.Data.SqlClient;

namespace Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        DatabaseConnectionClass dcc;

        public EmployeeRepo()
        {
            dcc = new DatabaseConnectionClass();
        }
        public bool InsertEmployee(Employee emp)
        {
            string query = "INSERT into Employees values('" + emp.EmpId + "', '" + emp.EmpName + "', " + emp.EmpAge + " , '" + emp.EmpPhoneNum + "', " + emp.EmpSalary + " ,  '" + emp.EmpDesignation + "', '" + emp.EmpAddress + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp) { return false; }
            finally { dcc.CloseConnection(); }
        }
        public bool DeleteEmployee(Employee emp)
        {
            string query = "DELETE from Employees WHERE Id = '" + emp.EmpId + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                dcc.CloseConnection();
                return false;
            }
            finally { dcc.CloseConnection(); }
        }
        public bool UpdateEmployee(Employee emp)
        {
            string query = "UPDATE Employees SET  Name = '"+ emp.EmpName +"', Age = '"+ emp.EmpAge +"', Phone = '"+ emp.EmpPhoneNum +"', Salary = '"+ emp.EmpSalary +"', Designation = '"+ emp.EmpDesignation +"', Address = '"+ emp.EmpAddress +"' WHERE Id = '" + emp.EmpId + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally { dcc.CloseConnection(); }
        }
        public Employee GetEmployee(string empId)
        {

            Employee emp = null;
            
            string query = "SELECT * from Employees WHERE Id = '"+empId+"'";
            dcc.ConnectWithDB();

            SqlDataReader sdr = dcc.GetData(query);
            
            while (sdr.Read())
            {
                emp = new Employee();
                emp.EmpId = sdr["Id"].ToString();
                emp.EmpName = sdr["Name"].ToString();
                emp.EmpAge = Convert.ToInt32(sdr["Age"]);
                emp.EmpPhoneNum = sdr["Phone"].ToString();
                emp.EmpSalary = Convert.ToDouble(sdr["Salary"]);
                emp.EmpDesignation = sdr["Designation"].ToString();
                emp.EmpAddress = sdr["Address"].ToString();
            }
            dcc.CloseConnection();

            return emp;            
            
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> emplist = new List<Employee>();

            string query = "SELECT * FROM Employees";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Employee emp = new Employee();
                emp.EmpId = sdr["Id"].ToString();
                emp.EmpName = sdr["Name"].ToString();
                emp.EmpAge = Convert.ToInt32(sdr["Age"]);
                emp.EmpPhoneNum = sdr["Phone"].ToString();
                emp.EmpSalary = Convert.ToInt32(sdr["Salary"]);
                emp.EmpDesignation = sdr["Designation"].ToString();
                emp.EmpAddress = sdr["Address"].ToString();
                emplist.Add(emp);
            }
            dcc.CloseConnection();
            return emplist;
        }
    }
}
