using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class GetListProductWithCategoryAndEmployeeQueryHandler : IRequestHandler<GetListProductWithCategoryAndEmployeeQuery, List<GetListProductWithCategoryAndEmployeeQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetListProductWithCategoryAndEmployeeQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GetListProductWithCategoryAndEmployeeQueryResult>> Handle(GetListProductWithCategoryAndEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetListProductWithEmployeeAndCategory();
        }
    }
}
