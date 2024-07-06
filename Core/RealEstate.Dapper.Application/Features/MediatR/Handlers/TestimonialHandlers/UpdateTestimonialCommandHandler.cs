using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly ITestimonialRepository _testimonialRepository;
        private readonly IMapper _mapper;

        public UpdateTestimonialCommandHandler(ITestimonialRepository testimonialRepository, IMapper mapper)
        {
            _testimonialRepository = testimonialRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _testimonialRepository.UpdateAsync(_mapper.Map<Testimonial>(request));
        }
    }
}
