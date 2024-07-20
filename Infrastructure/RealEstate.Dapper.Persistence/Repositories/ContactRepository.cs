using Dapper;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;

        public ContactRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        public async Task CreateAsync(Contact entity)
        {
            var query = "Insert Into Contacts(Name,Subject,Email,Message,SendDate) Values(@name,@subject,@email,@message,@sendDate)";
            _dynamicParameters.Add("@name", entity.Name);
            _dynamicParameters.Add("@subject", entity.Subject);
            _dynamicParameters.Add("@email", entity.Email);
            _dynamicParameters.Add("@message", entity.Message);
            _dynamicParameters.Add("@sendDate", entity.SendDate);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = $"Delete From Contacts Where Id={id}";
            await _connection.ExecuteAsync(query);
        }

        public async Task<Contact> GetByIdAsync(int id)
        {
            var query = $"Select * From Contacts Where Id={id}";
            var values = await _connection.QueryAsync<Contact>(query);

            return values.FirstOrDefault();
        }

        public async Task<List<Contact>> GetListAsync()
        {
            var query = "Select * From Contacts";
            var values = await _connection.QueryAsync<Contact>(query);
            return values.ToList();
        }

        public async Task<List<Contact>> GetListLastContactAsync(int HowContactCount)
        {
            var query = $"Select Top({HowContactCount}) * From Contacts Order By Id Desc";
            var values = await _connection.QueryAsync<Contact>(query);
            return values.ToList();
        }

        public async Task UpdateAsync(Contact entity)
        {
            var query = "Update Contacts Set Name=@name, Subject=@subject, Email=@email, Message=@message Where Id =@id";
            _dynamicParameters.Add("@name", entity.Name);
            _dynamicParameters.Add("@subject", entity.Subject);
            _dynamicParameters.Add("@email", entity.Email);
            _dynamicParameters.Add("@message", entity.Message);
            _dynamicParameters.Add("@id", entity.Id);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }
    }
}
