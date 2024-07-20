using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiCommandService
{
    public interface IContactCommandApiService
    {
        Task<HttpResponseMessage> CreateContact(CreateContactViewModel createContactViewModel);
        

    }
}
