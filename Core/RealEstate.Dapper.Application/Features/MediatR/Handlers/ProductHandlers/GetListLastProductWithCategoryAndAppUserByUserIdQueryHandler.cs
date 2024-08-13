using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class GetListLastProductWithCategoryAndAppUserByUserIdQueryHandler : IRequestHandler<GetListLastProductWithCategoryAndAppUserByUserIdQuery, List<GetListProductWithCategoryAndAppUserQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetListLastProductWithCategoryAndAppUserByUserIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GetListProductWithCategoryAndAppUserQueryResult>> Handle(GetListLastProductWithCategoryAndAppUserByUserIdQuery request, CancellationToken cancellationToken)
        {

            return await _productRepository.GetListLastProductAsync(request.HowCount, request.UserId);
        }
    }
}
