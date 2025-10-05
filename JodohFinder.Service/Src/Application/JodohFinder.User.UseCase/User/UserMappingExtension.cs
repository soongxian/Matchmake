using JodohFinder.Domain;

namespace JodohFinder.User.UseCase
{
    public static class UserMappingExtension
    {
        public static UserDTO JF_UserToDto(this JF_USER role)
        {
            return new UserDTO
            {
                USER_ID = role.USER_ID,
                USER_USERNAME = role.USER_USERNAME,
                USER_PASSWORD = role.USER_PASSWORD,
                USER_ROLE_ID = role.USER_ROLE_ID
            };
        }
    }
}
