using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AccountHandlers
{
    public class LoginUserQueryHandler : IRequestHandler<LoginUserQuery, LoginUserQueryResult>
    {
        private readonly IAccountRepository _accountRepository;

        public LoginUserQueryHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<LoginUserQueryResult> Handle(LoginUserQuery request, CancellationToken cancellationToken)
        {
            return await _accountRepository.LoginAsync(request.loginUserModel);
        }
    }
}
