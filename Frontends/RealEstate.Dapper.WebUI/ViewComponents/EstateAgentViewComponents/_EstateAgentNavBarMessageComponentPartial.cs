using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.Shared.Abstract.IUserServices;

namespace RealEstate.Dapper.WebUI.ViewComponents.EstateAgentViewComponents
{
    public class _EstateAgentNavBarMessageComponentPartial : ViewComponent
    {
        private readonly IMessageReadApiService _messageReadApiService;
        private readonly IUserService _userService;

        public _EstateAgentNavBarMessageComponentPartial(IUserService userService, IMessageReadApiService messageReadApiService)
        {
            _userService = userService;
            _messageReadApiService = messageReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int howCount = 3;
            return View(await _messageReadApiService.GetInBoxMessageListAsync(int.Parse(_userService.GetUser), howCount));
        }
    }
}
