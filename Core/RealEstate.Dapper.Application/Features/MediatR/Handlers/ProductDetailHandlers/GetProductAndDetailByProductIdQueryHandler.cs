using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductDetailHandlers
{
    public class GetProductAndDetailByProductIdQueryHandler : IRequestHandler<GetProductAndDetailByProductIdQuery, GetProductAndDetailByProductIdQueryResult>
    {
        private readonly IProductDetailRepository _productDetailRepository;

        public GetProductAndDetailByProductIdQueryHandler(IProductDetailRepository productDetailRepository)
        {
            _productDetailRepository = productDetailRepository;
        }

        public async Task<GetProductAndDetailByProductIdQueryResult> Handle(GetProductAndDetailByProductIdQuery request, CancellationToken cancellationToken)
        {
            return await _productDetailRepository.GetProductAndDetailByProductIdAsync(request.ProductId);
        }
    }
}
