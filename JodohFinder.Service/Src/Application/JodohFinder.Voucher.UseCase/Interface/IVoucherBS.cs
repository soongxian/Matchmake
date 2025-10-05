using JodohFinder.Domain;

namespace JodohFinder.Voucher.UseCase
{
    public interface IVoucherBS
    {
        Task<List<JF_VOUCHER>> GetAsync(Guid? voucherId, int? voucherIsUsed, CancellationToken cancellationToken = default);
        Task<List<JF_VOUCHER>> UpsertAsync(int count, Guid voucherCreBy, CancellationToken cancellationToken = default);
        Task<List<JF_VOUCHER>> DeleteAsync(List<Guid> voucherId, CancellationToken cancellationToken = default);
    }
}
