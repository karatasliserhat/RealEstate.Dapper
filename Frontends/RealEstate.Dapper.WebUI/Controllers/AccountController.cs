using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace RealEstate.Dapper.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountCommandApiService _accountCommandApiService;

        public AccountController(IAccountCommandApiService accountCommandApiService)
        {
            _accountCommandApiService = accountCommandApiService;
        }

        public IActionResult Login()
        {
            return View(new LoginUserModel());
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserModel loginUserModel)
        {
            var values = await _accountCommandApiService.UserLoginAsync(loginUserModel);
            if (values is not null)
            {

                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(values.Token);

                var claims = token.Claims.ToList();

                if (values.Token is not null)
                {
                    claims.Add(new Claim("realestatetoken", values.Token));
                    var claimIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
                    var authProps = new AuthenticationProperties
                    {
                        ExpiresUtc = values.ExpireDate,
                        IsPersistent = true
                    };

                    await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity), authProps);
                    return RedirectToAction("Index", "EstateAgentMyAds", new { area = "EstateAgent" });
                }
            }
            return View(new LoginUserModel());
        }
    }
}
