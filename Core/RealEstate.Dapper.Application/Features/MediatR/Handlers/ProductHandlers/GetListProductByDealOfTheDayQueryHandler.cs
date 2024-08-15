using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class GetListProductByDealOfTheDayQueryHandler : IRequestHandler<GetListProductByDealOfTheDayQuery, List<GetListProductWithCategoryAndAppUserQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetListProductByDealOfTheDayQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GetListProductWithCategoryAndAppUserQueryResult>> Handle(GetListProductByDealOfTheDayQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetListProductByDealOfTheDayTrue();
        }
    }
}
