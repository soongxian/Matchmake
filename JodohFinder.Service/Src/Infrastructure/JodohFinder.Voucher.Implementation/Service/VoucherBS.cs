using Ardalis.Specification.EntityFrameworkCore;
using JodohFinder.DbContextEF;
using JodohFinder.Domain;
using JodohFinder.Guard;
using JodohFinder.User.Implementation;
using JodohFinder.Voucher.UseCase;
using Microsoft.EntityFrameworkCore;

namespace JodohFinder.Voucher.Implementation
{
    public class VoucherBS : IVoucherBS
    {
        private readonly DbContextCore _dbContext;

        public VoucherBS(DbContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<JF_VOUCHER>> DeleteAsync(List<Guid> voucherId, CancellationToken cancellationToken = default)
        {
            if (voucherId.Count <= 0)
            {
                throw new GuardInvalidException(voucherId.Count.ToString());
            }

            var vouchers = await _dbContext.JF_Voucher.Where(v => voucherId.Contains(v.VOUCHER_ID)).ToListAsync(cancellationToken);

            _dbContext.JF_Voucher.RemoveRange(vouchers);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return vouchers;
        }

        public async Task<List<JF_VOUCHER>> GetAsync(Guid? voucherId, int? voucherIsUsed, CancellationToken cancellationToken = default)
        {
            if (voucherId is null && voucherIsUsed is null)
            {
                return await _dbContext.JF_Voucher.ToListAsync(cancellationToken);
            }

            var query = _dbContext.JF_Voucher.AsQueryable();

            if (voucherId.HasValue)
            {
                query = query.Where(v => v.VOUCHER_ID == voucherId.Value);
            }

            if (voucherIsUsed.HasValue)
            {
                query = query.Where(v => v.VOUCHER_ISUSED == voucherIsUsed.Value);
            }

            var result = await query.ToListAsync(cancellationToken);

            return result;
        }

        public async Task<List<JF_VOUCHER>> UpsertAsync(int count, Guid voucherCreBy, CancellationToken cancellationToken = default)
        {
            if (count <= 0)
            {
                throw new GuardInvalidException(count.ToString());
            }

            var userSpecification = new ActiveUserFromUserIdSpecification(voucherCreBy);
            var user = await _dbContext.JF_User.WithSpecification(userSpecification).FirstOrDefaultAsync();

            if (user is null)
            {
                throw new GuardNotFoundException(voucherCreBy.ToString());
            }

            var vouchers = new List<JF_VOUCHER>();

            for (int i = 0; i < count; i++)
            {
                var voucherId = Guid.NewGuid();
                var voucherCode = GenerateVoucherCode();

                var voucher = new JF_VOUCHER().CreateVoucher(voucherId, voucherCode, DateTime.UtcNow, voucherCreBy, 0);

                vouchers.Add(voucher);
            }

            await _dbContext.JF_Voucher.AddRangeAsync(vouchers, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return vouchers;
        }

        private string GenerateVoucherCode()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Range(0, 10)
                .Select(_ => chars[random.Next(chars.Length)])
                .ToArray());
        }
    }
}
