using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayRoll.Aplication.CQRS.Features.Employees.Commands.DeleteEmploye;
using PayRoll.Aplication.CQRS.Features.Employees.Commands.UpdateEmployee;
using PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeeByCompanyIdEmployeeId;
using PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeesByCompany;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace PayRoll.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IMediator _mediator;
        

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{CompanyId:int}", Name = "GetEmployeeByCompanyId")]
        [ProducesResponseType(typeof(IEnumerable<EmployeeVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<EmployeeVm>>> GetEmployeeByCompanyId(int CompanyId)
        {
            var query = new GetEmployeesListQuery(CompanyId);
            var employee = await _mediator.Send(query);

            return Ok(employee);
        }

        [HttpGet("{CompanyId:int}/{EmployeeId:int}", Name= "GetEmployeeByCompanyIdEmployeeId")]
        [ProducesResponseType(typeof(IEnumerable<EmployeeVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<EmployeeVm>>> GetEmployeeByCompanyIdEmployeeId(int CompanyId, int EmployeeId)
        {
            var query = new GetEmployeeByCompanyIdEmployeeIdQuery(CompanyId, EmployeeId);
            var employee = await _mediator.Send(query);

            return Ok(employee);
        }

        [HttpPut(Name = "UpdateEmployee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]

        public async Task<ActionResult> UpdateEmployee([FromBody] UpdateEmployeeCommand command)
        {

            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{CompanyId:int}/{EmployeeId:int}", Name = "DeleteEmployee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]

        public async Task<ActionResult> DeleteEmployee(int CompanyId, int EmployeeId)
        {
            var command = new DeleteEmployeeCommand() { CompanyId = CompanyId, EmployeeId = EmployeeId };
            await _mediator.Send(command);
            return NoContent();
        }


    }
}
