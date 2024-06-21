using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace RealEstate.Dapper.Application.Service
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationService(this IServiceCollection Services)
        {
            Services.AddMediatR(opt =>
            {
                opt.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });

            Services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
