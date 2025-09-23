namespace JodohFinder.Domain
{
    public partial class JF_USER
    {
        public JF_USER(string username, string password, Guid roleId)
        {
            USER_USERNAME = username;
            USER_PASSWORD = password;
            USER_ROLE_ID = roleId;
        }
    }
}
