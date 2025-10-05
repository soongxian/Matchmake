using JodohFinder.DbContextEF;
using JodohFinder.Domain;
using JodohFinder.Role.UseCase;
using Microsoft.EntityFrameworkCore;

namespace JodohFinder.Role.Implementation.Service
{
    public class RoleBS : IRoleBS
    {
        private readonly DbContextCore _dbContext;

        public RoleBS(DbContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<JF_ROLE>> GetAsync(Guid? id, CancellationToken cancellationToken = default)
        {
            if (id is null)
            {
                return await _dbContext.JF_Role.ToListAsync(cancellationToken);
            }

            var role = await _dbContext.JF_Role.FirstOrDefaultAsync(r => r.ROLE_ID == id, cancellationToken);
            if (role is null)
            {
                return null;
            }
            return new List<JF_ROLE> { role };
        }
    }
}
