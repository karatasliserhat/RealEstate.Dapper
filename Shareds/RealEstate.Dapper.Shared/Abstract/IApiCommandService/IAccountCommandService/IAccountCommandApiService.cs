using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiCommandService
{
    public interface IAccountCommandApiService
    {
        Task<TokenViewModel> UserLoginAsync(LoginUserModel loginUserModel);
    }
}
