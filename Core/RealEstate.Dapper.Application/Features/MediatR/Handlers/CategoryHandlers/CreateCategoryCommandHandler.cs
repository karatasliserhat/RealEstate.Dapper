using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.CategoryHandlers
{

    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepository.CreateAsync(_mapper.Map<Category>(request));
        }
    }
}
