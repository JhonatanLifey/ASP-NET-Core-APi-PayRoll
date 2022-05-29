using Microsoft.EntityFrameworkCore;
using PayRoll.Domain.Entities;
using PayRoll.Domain.Interfaces;
using PayRoll.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Persistence.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {

        private readonly DB_PayRollContext _context;

        public EmployeeRepository(DB_PayRollContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployees() 
        {

            var employees = await _context.Employees.ToListAsync();
            
            return employees;
        }


        public async Task<Employee> GetEmployeeByID(int id)
        {

            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);

            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByCompany(int id)
        {

            var employee = await _context.Employees.Where(x => x.CompanyId == id).ToListAsync();

            return employee;
        }
        public async Task<Employee> GetEmployeeByCompanyIdEmployeeId(int CompanyId, int EmployeeId)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.CompanyId == CompanyId && x.EmployeeId == EmployeeId);

            return employee;
        }

        public Task<Employee> GetEmployeeById(int idCompany, int idEmployee)
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

        public Task<Employee> AddAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
