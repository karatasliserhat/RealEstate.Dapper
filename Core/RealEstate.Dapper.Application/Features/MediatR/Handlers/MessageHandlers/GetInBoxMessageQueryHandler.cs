using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;


namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.MessageHandlers
{
    public class GetInBoxMessageQueryHandler : IRequestHandler<GetInBoxMessageQuery, List<GetInBoxMessageQueryResult>>
    {
        private readonly IMessageRepository _messageRepository;

        public GetInBoxMessageQueryHandler(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task<List<GetInBoxMessageQueryResult>> Handle(GetInBoxMessageQuery request, CancellationToken cancellationToken)
        {
            return await _messageRepository.GetInBoxMessage(request.ReceiveId, request.HowCount);
        }
    }
}
