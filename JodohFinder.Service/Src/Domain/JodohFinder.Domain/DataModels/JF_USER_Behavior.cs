namespace JodohFinder.Domain
{
    public partial class JF_USER
    {
        public JF_USER CreateUser(Guid userId, string userUsername, string userPassword, Guid userRoleId)
        {
            var record = new JF_USER(
                userId: userId,
                userUsername: userUsername,
                userPassword: userPassword,
                userRoleId: userRoleId
            );

            return record;
        }

        public JF_USER UpdateUser(string userPassword)
        {
            Update(userPassword);
            return this;
        }
    }
}
