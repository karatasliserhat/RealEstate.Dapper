using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.TestimonialHandlers
{
    public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommand>
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public RemoveTestimonialCommandHandler(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _testimonialRepository.DeleteAsync(request.Id);
        }
    }
}
