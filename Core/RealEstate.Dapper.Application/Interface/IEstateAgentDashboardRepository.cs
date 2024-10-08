﻿using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IEstateAgentDashboardRepository
    {
        Task<int> ProductCountByEmployeeIdAsync(int id);
        Task<int> ProductCountByStatusTrueAsync(int id);
        Task<int> ProductCountByStatusFalseAsync(int id);
        Task<List<GetLastFiveCityCountQueryResult>> GetLastFiveCountCity();
    }
}
