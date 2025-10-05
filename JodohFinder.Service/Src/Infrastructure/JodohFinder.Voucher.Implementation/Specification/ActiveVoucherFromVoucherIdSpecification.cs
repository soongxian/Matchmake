using Ardalis.Specification;
using JodohFinder.Domain;

namespace JodohFinder.Voucher.Implementation
{
    public class ActiveVoucherFromVoucherIdSpecification : Specification<JF_VOUCHER>
    {
        public ActiveVoucherFromVoucherIdSpecification(Guid voucherId)
        {
            Query.Where(v => v.VOUCHER_ID == voucherId);
        }
    }
}
