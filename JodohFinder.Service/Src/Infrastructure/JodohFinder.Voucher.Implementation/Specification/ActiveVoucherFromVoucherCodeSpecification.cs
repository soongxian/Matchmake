using Ardalis.Specification;
using JodohFinder.Domain;

namespace JodohFinder.Voucher.Implementation
{
    public class ActiveVoucherFromVoucherCodeSpecification : Specification<JF_VOUCHER>
    {
        public ActiveVoucherFromVoucherCodeSpecification(string voucherCode)
        {
            Query.Where(v => v.VOUCHER_CODE == voucherCode);
        }
    }
}
