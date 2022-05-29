using PayRoll.Domain.Entities;
using PayRoll.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Persistence.Repositories
{
    public class EmployeeMongoRepository : IEmployeeRepository
    {
        public Task<Employee> AddAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Employee>> GetAsync(Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Employee>> GetAsync(Expression<Func<Employee, bool>> predicate = null, Func<IQueryable<Employee>, IOrderedQueryable<Employee>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Employee>> GetAsync(Expression<Func<Employee, bool>> predicate = null, Func<IQueryable<Employee>, IOrderedQueryable<Employee>> orderBy = null, List<Expression<Func<Employee, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByCompanyIdEmployeeId(int CompanyId, int EmployeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int idCompany, int idEmployee)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employee = Enumerable.Range(1, 10).Select(x => new Employee
            {
                EmployeeId = x,
                EmployeeName = $" Name MongoDB {x}",
                EmployeeDateStart = DateTime.Now
            });

            await Task.Delay(10);

            return employee;
        }

        public Task<IEnumerable<Employee>> GetEmployeesByCompany(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
