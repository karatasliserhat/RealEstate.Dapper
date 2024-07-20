using Microsoft.AspNetCore.SignalR;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.WebAPI.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public SignalRHub(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public async Task SendStatisticsCount()
        {
            var values = await _statisticsRepository.CategoryCount();

            await Clients.All.SendAsync("ReceiveCategoryCount", values);
        }
    }
}
