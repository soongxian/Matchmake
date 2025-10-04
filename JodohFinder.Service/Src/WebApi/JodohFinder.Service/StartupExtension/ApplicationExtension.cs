using JodohFinder.Role.Implementation;
using JodohFinder.Role.UseCase;
using MediatR;
using System.Reflection;

namespace JodohFinder.Service.StartupExtension
{
    public static class ApplicationExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRoleBS, RoleBS>();
            services.AddMediatR(typeof(GetRolesQuery).GetTypeInfo().Assembly);
        }
    }
}
