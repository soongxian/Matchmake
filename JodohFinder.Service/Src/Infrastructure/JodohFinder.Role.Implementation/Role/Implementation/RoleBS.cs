using JodohFinder.DbContextEF;
using JodohFinder.Domain;
using JodohFinder.Role.UseCase;
using Microsoft.EntityFrameworkCore;

namespace JodohFinder.Role.Implementation
{
    public class RoleBS : IRoleBS
    {
        private readonly DbContextCore _dbContext;

        public RoleBS(DbContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<JF_ROLE>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.JF_Role.ToListAsync(cancellationToken);
        }

        public async Task<JF_ROLE> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var role = await _dbContext.JF_Role.FirstOrDefaultAsync(r => r.ROLE_ID == id, cancellationToken);

            if (role is null)
            {
                throw new KeyNotFoundException($"Role with id {id} not found.");
            }

            return role;
        }
    }
}
