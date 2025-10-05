using JodohFinder.Domain;

namespace JodohFinder.Role.UseCase
{
    public interface IRoleBS
    {
        Task<List<JF_ROLE>> GetAsync(Guid? id, CancellationToken cancellationToken = default);
    }
}
