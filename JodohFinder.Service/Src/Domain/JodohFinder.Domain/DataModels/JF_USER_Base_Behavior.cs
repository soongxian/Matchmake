namespace JodohFinder.Domain
{
    public partial class JF_USER
    {
        public JF_USER(Guid userId, string userUsername, string userPassword, Guid userRoleId)
        {
            USER_ID = userId;
            USER_USERNAME = userUsername;
            USER_PASSWORD = userPassword;
            USER_ROLE_ID = userRoleId;
        }

        public void Update(string userPassword)
        {
            USER_PASSWORD = userPassword;
        }
    }
}
