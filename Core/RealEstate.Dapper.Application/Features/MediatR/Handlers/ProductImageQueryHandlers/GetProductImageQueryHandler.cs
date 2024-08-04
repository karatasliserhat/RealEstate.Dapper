using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductImageQueryHandlers
{
    public class GetProductImageQueryHandler : IRequestHandler<GetProductImageQuery, List<GetProductImageQueryResult>>
    {
        private readonly IProductImagesRepository _productsImagesRepository;

        public GetProductImageQueryHandler(IProductImagesRepository productsImagesRepository)
        {
            _productsImagesRepository = productsImagesRepository;
        }

        public async Task<List<GetProductImageQueryResult>> Handle(GetProductImageQuery request, CancellationToken cancellationToken)
        {
            return await _productsImagesRepository.GetProductImageListByProductId(request.ProductId);
        }
    }
}
