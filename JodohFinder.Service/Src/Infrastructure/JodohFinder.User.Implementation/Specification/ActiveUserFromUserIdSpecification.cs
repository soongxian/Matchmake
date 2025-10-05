using Ardalis.Specification;
using JodohFinder.Domain;

namespace JodohFinder.User.Implementation
{
    public class ActiveUserFromUserIdSpecification : Specification<JF_USER>
    {
        public ActiveUserFromUserIdSpecification(Guid userId)
        {
            Query.Where(a => a.USER_ID == userId);
        }
    }
}
