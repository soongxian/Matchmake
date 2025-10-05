using Ardalis.Specification;
using JodohFinder.Domain;

namespace JodohFinder.User.Implementation
{
    public class ActiveUserFromUsernameSpecification : Specification<JF_USER>
    {
        public ActiveUserFromUsernameSpecification(string userUsername)
        {
            Query.Where(a => a.USER_USERNAME == userUsername);
        }
    }
}
