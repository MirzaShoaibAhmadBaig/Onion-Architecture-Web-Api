using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployee
    {

        private  IRepository<EmployeeDetails> _repository;

        public EmployeeService(IRepository<EmployeeDetails> repository)
        {
            _repository = repository;

        }
        public string DeleteEmployee(EmployeeDetails employee)
        {
            throw new NotImplementedException();
        }

        public EmployeeDetails GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDetails> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public string SaveEmployee(EmployeeDetails employee)
        {
            throw new NotImplementedException();
        }

        public string Updateemployee(EmployeeDetails employee)
        {
            throw new NotImplementedException();
        }
    }
}
