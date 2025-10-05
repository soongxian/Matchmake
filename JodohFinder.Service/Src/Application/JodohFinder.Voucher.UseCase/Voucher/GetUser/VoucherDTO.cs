namespace JodohFinder.Voucher.UseCase
{
    public class VoucherDTO
    {
        public Guid VOUCHER_ID { get; set; }
        public string VOUCHER_CODE { get; set; }
        public DateTime VOUCHER_CREDATE { get; set; }
        public Guid VOUCHER_CREBY { get; set; }
        public DateTime? VOUCHER_USEDATE { get; set; }
        public int VOUCHER_ISUSED { get; set; }
    }
}
