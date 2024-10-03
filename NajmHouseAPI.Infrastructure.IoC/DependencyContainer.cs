using Microsoft.Extensions.DependencyInjection;
using NajmHouseAPI.Application.Interfaces;
using NajmHouseAPI.Application.Services;
using NajmHouseAPI.Domian.Interface;
using NajmHouseAPI.Domian.Interface.Base;
using NajmHouseAPI.Infrastructure.Data.Repository;
using NajmHouseAPI.Infrastructure.Data.Repository.Base;

namespace NajmHouseAPI.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void AddIoCService(this IServiceCollection services)
        {
            // IoC - Inversion Of Control
            // Application         
            services.AddScoped<ICourseServices, CourseServices>();

            // Domain.Interfaces > Infrastructure.Data.Repositories
            
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
