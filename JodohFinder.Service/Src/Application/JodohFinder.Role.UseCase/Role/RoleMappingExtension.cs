using JodohFinder.Domain;

namespace JodohFinder.Role.UseCase
{
    public static class RoleMappingExtensions
    {
        public static RoleDTO JF_RoleToDto(this JF_ROLE role)
        {
            return new RoleDTO
            {
                ROLE_ID = role.ROLE_ID,
                ROLE_NAME = role.ROLE_NAME
            };
        }
    }
}
