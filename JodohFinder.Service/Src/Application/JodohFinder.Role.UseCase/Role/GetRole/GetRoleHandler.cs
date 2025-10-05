using JodohFinder.Domain;
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
            List<JF_ROLE> roles;

            if (request.Id.HasValue)
            {
                var role = await _roleBS.GetByIdAsync(request.Id.Value);
                if (role is null)
                {
                    throw new GuardNotFoundException(request.Id.Value.ToString());
                }
                roles = role;
            }
            else
            {
                roles = await _roleBS.GetAllAsync(cancellationToken);
            }

            return roles.Select(r => r.JF_RoleToDto()).ToList();
        }
    }
}
