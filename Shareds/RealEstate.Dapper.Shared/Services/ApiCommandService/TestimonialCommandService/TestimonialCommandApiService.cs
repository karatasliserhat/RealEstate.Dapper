using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class TestimonialCommandApiService : BaseCommandApiService<UpdateTestimonialViewModel, CreateTestimonialViewModel>, ITestimonialCommandApiService
    {
        public TestimonialCommandApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
