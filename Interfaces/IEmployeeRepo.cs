using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Interfaces
{
    public interface IEmployeeRepo
    {
        bool InsertEmployee(Employee emp);
        bool DeleteEmployee(Employee emp);
        bool UpdateEmployee(Employee emp);
        Employee GetEmployee(string empId);
        List<Employee> GetAllEmployees();
    }
}
