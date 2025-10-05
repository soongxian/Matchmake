using Ardalis.Specification.EntityFrameworkCore;
using JodohFinder.DbContextEF;
using JodohFinder.Domain;
using JodohFinder.Guard;
using JodohFinder.User.UseCase;
using Microsoft.EntityFrameworkCore;

namespace JodohFinder.User.Implementation.Service
{
    public class UserBS : IUserBS
    {
        private readonly DbContextCore _dbContext;

        public UserBS(DbContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<JF_USER> DeleteUserAsync(Guid userId, CancellationToken cancellationToken = default)
        {
            var specification = new ActiveUserFromUserIdSpecification(userId);
            var user = await _dbContext.JF_User.WithSpecification(specification).FirstOrDefaultAsync();

            if (user is null)
            {
                throw new GuardNotFoundException(userId.ToString());
            }

            _dbContext.JF_User.Remove(user);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return user;
        }

        public async Task<List<JF_USER>> GetAsync(Guid? userId, CancellationToken cancellationToken = default)
        {
            if (userId == null)
            {
                return await _dbContext.JF_User.ToListAsync(cancellationToken);
            }

            var user = await _dbContext.JF_User.FirstOrDefaultAsync(r => r.USER_ID == userId, cancellationToken);
            if (user is null)
            {
                return null;
            }

            return new List<JF_USER> { user };
        }

        public async Task<JF_USER> UpsertUserAsync(Guid userId, string userUsername, string userPassword, Guid userRoleId, CancellationToken cancellationToken = default)
        {
            var specification = new ActiveUserFromUsernameSpecification(userUsername);
            var user = await _dbContext.JF_User.WithSpecification(specification).FirstOrDefaultAsync();

            if (user is null)
            {
                var newUser = new JF_USER().CreateUser(userId, userUsername, userPassword, userRoleId);

                await _dbContext.JF_User.AddAsync(newUser, cancellationToken);
                await _dbContext.SaveChangesAsync(cancellationToken);
                return newUser;
            }

            if (user.USER_ID != userId)
            {
                throw new GuardDuplicateException(user.USER_USERNAME.ToString());
            }

            user.UpdateUser(userPassword);
            _dbContext.JF_User.Update(user);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return user;
        }
    }
}
