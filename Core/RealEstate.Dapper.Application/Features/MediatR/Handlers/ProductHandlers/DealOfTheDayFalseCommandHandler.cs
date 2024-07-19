using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ProductHandlers
{
    public class DealOfTheDayFalseCommandHandler : IRequestHandler<DealOfTheDayFalseCommand>
    {
        private readonly IProductRepository _productRepository;

        public DealOfTheDayFalseCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(DealOfTheDayFalseCommand request, CancellationToken cancellationToken)
        {
            await _productRepository.DealOfTheDayFalse(request.Id);
        }
    }
}
