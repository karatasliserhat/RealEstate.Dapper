using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;

        public RemoveCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepository.DeleteAsync(request.Id);
        }
    }
}
