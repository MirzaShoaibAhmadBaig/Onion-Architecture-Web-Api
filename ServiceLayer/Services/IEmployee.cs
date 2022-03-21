using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
  public  interface IEmployee
    {

        IEnumerable<EmployeeDetails> GetEmployees();

        EmployeeDetails GetEmployeeById(int id);

        string SaveEmployee(EmployeeDetails employee);

        string DeleteEmployee(EmployeeDetails employee);
        string Updateemployee(EmployeeDetails employee);
    }
}
