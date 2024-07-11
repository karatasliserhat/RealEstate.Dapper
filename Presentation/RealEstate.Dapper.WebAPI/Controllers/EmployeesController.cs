using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public EmployeesController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<IActionResult> GetListEmployee()
        {
            return Ok(await _mediatr.Send(new GetEmployeeQuery()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            return Ok(await _mediatr.Send(new GetEmployeeByIdQuery(id)));
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeCommand createEmployeeCommand)
        {
            await _mediatr.Send(createEmployeeCommand);
            return Created();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _mediatr.Send(new RemoveEmployeeCommand(id));
            return Ok($"{id} li Employee Silinmiştir.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeCommand updateEmployeeCommand)
        {
            await _mediatr.Send(updateEmployeeCommand);
            return Ok("Employee Güncellenmiştir. ");
        }
    }
}
