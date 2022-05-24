using PayRoll.Domain.Entities;
using PayRoll.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Persistence.Repositories
{
    public class EmployeeMongoRepository : IEmployeeRepository
    {
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employee = Enumerable.Range(1, 10).Select(x => new Employee
            {
                employee_ID = x,
                employee_Name = $" Name MongoDB {x}",
                employee_DateStart = DateTime.Now
            });

            await Task.Delay(10);

            return employee;
        }
    }
}
