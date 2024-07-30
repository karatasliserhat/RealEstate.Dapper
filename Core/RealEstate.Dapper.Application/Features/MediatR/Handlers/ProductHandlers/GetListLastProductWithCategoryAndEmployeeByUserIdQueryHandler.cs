using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class GetListLastProductWithCategoryAndEmployeeByUserIdQueryHandler : IRequestHandler<GetListLastProductWithCategoryAndEmployeeByUserIdQuery, List<GetListProductWithCategoryAndEmployeeQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetListLastProductWithCategoryAndEmployeeByUserIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GetListProductWithCategoryAndEmployeeQueryResult>> Handle(GetListLastProductWithCategoryAndEmployeeByUserIdQuery request, CancellationToken cancellationToken)
        {

            return await _productRepository.GetListLastProductAsync(request.HowCount, request.UserId);
        }
    }
}
