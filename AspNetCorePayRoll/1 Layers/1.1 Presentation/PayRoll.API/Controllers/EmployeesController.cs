using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayRoll.Domain.Interfaces;
using PayRoll.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayRoll.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees() 
        {
            var employee = await _employeeRepository.GetEmployees();

            return Ok(employee);
        }
    }
}
