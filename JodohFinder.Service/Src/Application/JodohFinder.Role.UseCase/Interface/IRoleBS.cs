using JodohFinder.Domain;

namespace JodohFinder.Role.UseCase
{
    public interface IRoleBS
    {
        Task<List<JF_ROLE>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<JF_ROLE> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
