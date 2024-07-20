using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IContactRepository:IGenericRepository<Contact>
    {
        Task<List<Contact>> GetListLastContactAsync(int HowContactCount);
    }
}
