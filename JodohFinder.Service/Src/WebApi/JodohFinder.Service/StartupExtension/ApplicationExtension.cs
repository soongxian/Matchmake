using JodohFinder.Role.Implementation;
using JodohFinder.Role.UseCase;
using JodohFinder.User.Service;
using JodohFinder.User.UseCase;
using MediatR;
using System.Reflection;

namespace JodohFinder.Service
{
    public static class ApplicationExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRoleBS, RoleBS>();
            services.AddMediatR(typeof(GetRolesQuery).GetTypeInfo().Assembly);

            services.AddScoped<IUserBS, UserBS>();
            services.AddMediatR(typeof(GetUserQuery).GetTypeInfo().Assembly);
        }
    }
}
