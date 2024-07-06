using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly ITestimonialRepository _testimonialRepository;
        private readonly IMapper _mapper;

        public GetTestimonialQueryHandler(ITestimonialRepository testimonialRepository, IMapper mapper)
        {
            _testimonialRepository = testimonialRepository;
            _mapper = mapper;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetTestimonialQueryResult>>(await _testimonialRepository.GetListAsync());
        }
    }
}
