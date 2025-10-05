namespace JodohFinder.Domain
{
    public partial class JF_VOUCHER
    {
        public JF_VOUCHER(Guid voucherId, string voucherCode, DateTime voucherCreDate, Guid voucherCreBy, int voucherIsUsed)
        {
            VOUCHER_ID = voucherId;
            VOUCHER_CODE = voucherCode;
            VOUCHER_CREDATE = voucherCreDate;
            VOUCHER_CREBY = voucherCreBy;
            VOUCHER_ISUSED = voucherIsUsed;
        }
    }
}
