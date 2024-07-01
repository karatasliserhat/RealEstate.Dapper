namespace RealEstate.Dapper.Shared.Abstract.IApiCommandService
{
    public interface IBaseCommandApiService<UpdateViewModel,CreateViewModel> where UpdateViewModel : class where CreateViewModel : class
    {
        Task<HttpResponseMessage> UpdateAsync(UpdateViewModel updateViewModel);
        Task<HttpResponseMessage> DeleteAsync(int id);
        Task<HttpResponseMessage> CreateAsync(CreateViewModel createViewModel);
    }
}
