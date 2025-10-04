using MediatR;

namespace JodohFinder.Role.UseCase
{
    public class GetRolesQuery : IRequest<List<RoleDTO>>
    {
    }
}
