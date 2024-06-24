using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepository.UpdateAsync(_mapper.Map<Category>(request));
        }
    }
}
