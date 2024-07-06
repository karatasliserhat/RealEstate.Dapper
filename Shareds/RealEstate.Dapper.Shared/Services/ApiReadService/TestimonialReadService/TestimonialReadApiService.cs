using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class TestimonialReadApiService : BaseReadApiService<ResultTestimonialViewModel>, ITestimonialReadApiService
    {
        public TestimonialReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
