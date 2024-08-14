using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class GetProductListBySearchQueryHandler : IRequestHandler<GetProductListBySearchQuery, List<GetListProductWithCategoryAndAppUserQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductListBySearchQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GetListProductWithCategoryAndAppUserQueryResult>> Handle(GetProductListBySearchQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductBySearchList(request.SearchKeyValue, request.CategoryId, request.City);
        }
    }
}
