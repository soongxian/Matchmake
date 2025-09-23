namespace JodohFinder.Domain
{
    public partial class JF_VOUCHER
    {
        public Guid VOUCHER_ID { get; set; }
        public string VOUCHER_CODE { get; set; }
        public DateTime VOUCHER_CREDATE { get; set; }
        public DateTime? VOUCHER_USEDATE { get; set; }
        public string VOUCHER_STATUS { get; set; }

        public JF_USER JF_USER { get; set; }
        public JF_PARTICIPANT JF_PARTICIPANT { get; set; }

        public JF_VOUCHER()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }
}
