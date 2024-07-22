using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Model;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class LoginUserQuery : IRequest<LoginUserQueryResult>
    {
        public LoginUserModel loginUserModel { get; set; }

        public LoginUserQuery(LoginUserModel loginUserModel)
        {
            this.loginUserModel = loginUserModel;
        }
    }
}
