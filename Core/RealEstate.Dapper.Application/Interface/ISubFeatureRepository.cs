using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Interface
{
    public interface ISubFeatureRepository
    {
        Task<List<GetSubFeatureQueryResults>> GetSubFeatureListAsync();
        Task<GetByIdSubFeatureQueryResults> GetByIdSubFeatureQueryAsync(int id);
    }
}
