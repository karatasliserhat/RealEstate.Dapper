using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Queries;

namespace RealEstate.Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public ContactsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> GetContact()
        {
            return Ok(await _mediatR.Send(new GetContactQuery()));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> GetContactById(int id)
        {
            return Ok(await _mediatR.Send(new GetContactByIdQuery(id)));
        }
        [HttpGet("[Action]/{HowContactCount}")]
        public async Task<IActionResult> GetLastContact(int HowContactCount)
        {
            return Ok(await _mediatR.Send(new GetLastContactQuery(HowContactCount)));
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand createContactCommand)
        {
            await _mediatR.Send(createContactCommand);
            return Created();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _mediatR.Send(new RemoveContactCommand(id));
            return Ok("İletişim Mesajı Silindi");
        }
    }
}
