using Dapper;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;

        public TestimonialRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        public async Task CreateAsync(Testimonial entity)
        {
            var query = "Insert Into Testimonials (NameSurname,Comment,Title,Status) Values(@nameSurname,@comment,@title,@status)";
            _dynamicParameters.Add("@nameSurname", entity.NameSurname);
            _dynamicParameters.Add("@comment", entity.Comment);
            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@status", entity.Status);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            await _connection.ExecuteAsync($"Delete From Testimonials Where Id ={id}");
        }

        public async Task<Testimonial> GetByIdAsync(int id)
        {
            var values = await _connection.QueryAsync<Testimonial>($"Select * From Testimonials Where Id={id}");
            return values.FirstOrDefault();
        }

        public async Task<List<Testimonial>> GetListAsync()
        {
            var values = await _connection.QueryAsync<Testimonial>($"Select * From Testimonials");
            return values.ToList();
        }

        public async Task UpdateAsync(Testimonial entity)
        {
            var query = "Update Testimonials Set NameSurname=@nameSurname,Comment=@comment,Title=@title,Status=@status Where Id=@id";
            _dynamicParameters.Add("@id", entity.Id);
            _dynamicParameters.Add("@nameSurname", entity.NameSurname);
            _dynamicParameters.Add("@comment", entity.Comment);
            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@status", entity.Status);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }
    }
}
