using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class GetProductByIdWithCategoryAndEmployeeQueryHandler : IRequestHandler<GetProductByIdWithCategoryAndEmployeeQuery, GetProductByIdWithCategoryAndEmployeeQueryResult>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdWithCategoryAndEmployeeQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetProductByIdWithCategoryAndEmployeeQueryResult> Handle(GetProductByIdWithCategoryAndEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetByIdWithCategoryAndEmployeeAsync(request.Id);
        }
    }
}
