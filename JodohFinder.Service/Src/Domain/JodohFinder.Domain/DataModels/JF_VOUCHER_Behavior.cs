namespace JodohFinder.Domain
{
    public partial class JF_VOUCHER
    {
        public JF_VOUCHER CreateVoucher(Guid voucherId, string voucherCode, DateTime voucherCreDate, Guid voucherCreBy, int voucherIsUsed)
        {
            var record = new JF_VOUCHER(
                voucherId: voucherId,
                voucherCode: voucherCode,
                voucherCreDate: voucherCreDate,
                voucherCreBy: voucherCreBy,
                voucherIsUsed: voucherIsUsed
            );

            return record;
        }
    }
}
