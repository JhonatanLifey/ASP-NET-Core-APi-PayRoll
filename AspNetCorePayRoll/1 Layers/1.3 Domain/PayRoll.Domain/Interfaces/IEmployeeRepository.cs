using PayRoll.Domain.Common;
using PayRoll.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PayRoll.Domain.Interfaces
{
    public interface IEmployeeRepository : IAsyncRepository<Employee>
    {

        Task<IEnumerable<Employee>> GetEmployees();


        Task<IEnumerable<Employee>> GetEmployeesByCompany(int id);


        Task<Employee> GetEmployeeById(int idCompany, int idEmployee);

        Task<Employee> GetEmployeeByCompanyIdEmployeeId(int CompanyId, int EmployeeId);

    }
}
