using Dapper;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbConnection _connection;

        public EmployeeRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        private readonly DynamicParameters _dynamicParameters;
        public async Task CreateAsync(Employee entity)
        {
            var query = "Insert Into Employees (EmployeeName,Title,Mail,PhoneNumber,ImageUrl,Status) Values(@employeeName,@title,@mail,@phoneNumber,@imageUrl,@status)";

            _dynamicParameters.Add("@employeeName", entity.EmployeeName);
            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@mail", entity.Mail);
            _dynamicParameters.Add("@phoneNumber", entity.PhoneNumber);
            _dynamicParameters.Add("@imageUrl", entity.ImageUrl);
            _dynamicParameters.Add("@status", entity.Status);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = $"Delete From Employees Where Id={id}";
            await _connection.ExecuteAsync(query);
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            var query = $"Select * From Employees Where Id={id}";
            var values = await _connection.QueryAsync<Employee>(query);
            return values.FirstOrDefault();
        }

        public async Task<List<Employee>> GetListAsync()
        {
            var query = $"Select * From Employees ";
            var values = await _connection.QueryAsync<Employee>(query);
            return values.ToList();
        }

        public async Task UpdateAsync(Employee entity)
        {
            var query = "Update Employees Set EmployeeName=@employeeName,Title=@title,Mail=@mail,PhoneNumber=@phoneNumber,ImageUrl=@imageUrl,Status=@status Where Id =@id";
            _dynamicParameters.Add("@employeeName", entity.EmployeeName);
            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@mail", entity.Mail);
            _dynamicParameters.Add("@phoneNumber", entity.PhoneNumber);
            _dynamicParameters.Add("@imageUrl", entity.ImageUrl);
            _dynamicParameters.Add("@status", entity.Status);
            _dynamicParameters.Add("@id", entity.Id);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }
    }
}
