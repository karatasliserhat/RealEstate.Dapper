using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly ITestimonialRepository _testimonialRepository;
        private readonly IMapper _mapper;

        public GetTestimonialByIdQueryHandler(ITestimonialRepository testimonialRepository, IMapper mapper)
        {
            _testimonialRepository = testimonialRepository;
            _mapper = mapper;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
           return  _mapper.Map<GetTestimonialByIdQueryResult>(await _testimonialRepository.GetByIdAsync(request.Id));
        }
    }
}
