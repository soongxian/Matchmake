using MediatR;

namespace JodohFinder.Role.UseCase
{
    public class GetRolesQuery : IRequest<List<RoleDTO>>
    {
        public Guid? Id { get; set; }
    }
}
