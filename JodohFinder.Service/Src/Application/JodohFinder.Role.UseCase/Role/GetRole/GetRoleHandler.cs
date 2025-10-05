using JodohFinder.Guard;
using MediatR;

namespace JodohFinder.Role.UseCase.Role.GetRole
{
    public class GetRoleHandler : IRequestHandler<GetRolesQuery, List<RoleDTO>>
    {
        private readonly IRoleBS _roleBS;

        public GetRoleHandler(IRoleBS roleBS)
        {
            _roleBS = roleBS;
        }

        public async Task<List<RoleDTO>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
        {
            Guid? roleId = request.Id ?? null;
            var role = await _roleBS.GetAsync(roleId);
            if (role is null)
            {
                throw new GuardNotFoundException(roleId.ToString());
            }

            return role.Select(r => r.JF_RoleToDto()).ToList();
        }
    }
}
