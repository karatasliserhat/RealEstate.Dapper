using Microsoft.AspNetCore.Http;
using RealEstate.Dapper.Shared.Abstract.IUserServices;
using System.Security.Claims;

namespace RealEstate.Dapper.Shared.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public UserService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string GetUser => _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier.ToString()).Value;
    }
}
