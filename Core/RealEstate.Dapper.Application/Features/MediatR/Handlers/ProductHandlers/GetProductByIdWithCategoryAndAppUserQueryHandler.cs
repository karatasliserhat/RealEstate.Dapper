using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class GetProductByIdWithCategoryAndAppUserQueryHandler : IRequestHandler<GetProductByIdWithCategoryAndAppUserQuery, GetProductByIdWithCategoryAndAppUserQueryResult>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdWithCategoryAndAppUserQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetProductByIdWithCategoryAndAppUserQueryResult> Handle(GetProductByIdWithCategoryAndAppUserQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetByIdWithCategoryAndAppUserAsync(request.Id);
        }
    }
}
