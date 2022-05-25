using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICRUD_PUTRequest.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        List<Employee> CreateEmployee(Employee emp);
        Employee UpdateEmployee(Employee emp);
        bool DeleteEmployee(int id);
    }
}
