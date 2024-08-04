using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductDetailHandlers
{
    public class GetProductAndDetailListQueryHandler : IRequestHandler<GetProductAndDetailListQuery, List<GetProductAndDetailListQueryResult>>
    {
        private readonly IProductDetailRepository _productDetailRepository;

        public GetProductAndDetailListQueryHandler(IProductDetailRepository productDetailRepository)
        {
            _productDetailRepository = productDetailRepository;
        }

        public async Task<List<GetProductAndDetailListQueryResult>> Handle(GetProductAndDetailListQuery request, CancellationToken cancellationToken)
        {
            return await _productDetailRepository.GetProductAndDetailListAsync();
        }
    }
}
