using JodohFinder.Domain;

namespace JodohFinder.User.UseCase
{
    public interface IUserBS
    {
        Task<List<JF_USER>> GetAsync(Guid? userId, CancellationToken cancellationToken = default);
        Task<JF_USER> UpsertUserAsync(Guid userId, string userUsername, string userPassword, Guid userRoleId, CancellationToken cancellationToken = default);
        Task<JF_USER> DeleteUserAsync(Guid userId, CancellationToken cancellationToken = default);
    }
}
