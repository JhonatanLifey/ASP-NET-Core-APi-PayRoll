using PayRoll.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Domain.Interfaces
{
    public interface IEmployeeRepository
    {

        Task<IEnumerable<Employee>> GetEmployees();

        Task<Employee> GetEmployeeByID(int id);

    }
}
