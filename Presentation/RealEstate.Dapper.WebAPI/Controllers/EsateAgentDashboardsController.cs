using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results.EstateAgentQueries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EsateAgentDashboardsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public EsateAgentDashboardsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetProductCount()
        {
            return Ok(await _mediatR.Send(new GetProductCountQuery()));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> ProductCountByEmployeeId(int id)
        {
            return Ok(await _mediatR.Send(new GetProductCountByEmployeeIdQuery(id)));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> ProductCountByStatusFalse(int id)
        {
            return Ok(await _mediatR.Send(new GetProductCountByStatusFalseQuery(id)));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> ProductCountByStatusTrue(int id)
        {
            return Ok(await _mediatR.Send(new GetProductCountByStatusTrueQuery(id)));
        }
    }
}
