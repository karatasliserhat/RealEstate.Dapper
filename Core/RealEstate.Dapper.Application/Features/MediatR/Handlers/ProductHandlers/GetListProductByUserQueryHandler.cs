using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class GetListProductByUserQueryHandler : IRequestHandler<GetListProductByUserQuery, List<GetListProductByUserQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetListProductByUserQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GetListProductByUserQueryResult>> Handle(GetListProductByUserQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetListProductByUserAsync(request.EmployeeId);
        }
    }
}
