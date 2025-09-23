namespace JodohFinder.Domain
{
    public partial class JF_VOUCHER
    {
        public JF_VOUCHER(string voucherCode, DateTime voucherCreDate, string voucherStatus, Guid userId)
        {
            VOUCHER_CODE = voucherCode;
            VOUCHER_CREDATE = voucherCreDate;
            VOUCHER_STATUS = voucherStatus;
            VOUCHER_USERID = userId;
        }
    }
}
