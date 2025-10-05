using JodohFinder.Role.Implementation.Service;
using JodohFinder.Role.UseCase;
using JodohFinder.User.Implementation.Service;
using JodohFinder.User.UseCase;
using JodohFinder.Voucher.Implementation;
using JodohFinder.Voucher.UseCase;
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

            services.AddScoped<IVoucherBS, VoucherBS>();
            services.AddMediatR(typeof(GetVoucherQuery).GetTypeInfo().Assembly);
        }
    }
}
