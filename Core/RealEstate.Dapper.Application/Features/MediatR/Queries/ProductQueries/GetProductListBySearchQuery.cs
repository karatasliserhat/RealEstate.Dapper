using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Features.MediatR.Queries
{
    public class GetProductListBySearchQuery : IRequest<List<GetListProductWithCategoryAndAppUserQueryResult>>
    {
        public string SearchKeyValue { get; set; }
        public int CategoryId { get; set; }
        public string City { get; set; }
        public GetProductListBySearchQuery(string searchKeyValue, int categoryId, string city)
        {
            SearchKeyValue = searchKeyValue;
            CategoryId = categoryId;
            City = city;
        }
    }
}
