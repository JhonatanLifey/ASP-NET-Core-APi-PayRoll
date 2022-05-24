using Microsoft.EntityFrameworkCore;
using PayRoll.Domain.Entities;
using PayRoll.Domain.Interfaces;
using PayRoll.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<PayRollEmployee>> GetEmployees() 
        {

            var employee = await _context.PayRollEmployees.ToListAsync();
            
            return employee;
        }

    }
}
