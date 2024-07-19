using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class DealOfTheDayTrueCommandHandler : IRequestHandler<DealOfTheDayTrueCommand>
    {
        private readonly IProductRepository _productRepository;

        public DealOfTheDayTrueCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(DealOfTheDayTrueCommand request, CancellationToken cancellationToken)
        {
            await _productRepository.DealOfTheDayTrue(request.Id);
        }
    }
}
