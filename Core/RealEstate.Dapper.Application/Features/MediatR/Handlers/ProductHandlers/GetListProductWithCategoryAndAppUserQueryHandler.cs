using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class GetListProductWithCategoryAndAppUserQueryHandler : IRequestHandler<GetListProductWithCategoryAndAppUserQuery, List<GetListProductWithCategoryAndAppUserQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetListProductWithCategoryAndAppUserQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GetListProductWithCategoryAndAppUserQueryResult>> Handle(GetListProductWithCategoryAndAppUserQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetListProductWithAppUserAndCategory();
        }
    }
}
