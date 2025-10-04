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
            var roles = await _roleBS.GetAllAsync(cancellationToken);

            return roles.Select(r => new RoleDTO
            {
                ROLE_ID = r.ROLE_ID,
                ROLE_NAME = r.ROLE_NAME
            }).ToList();
        }
    }
}
