namespace JodohFinder.Domain
{
    public partial class JF_PARTICIPANT
    {
        public Guid PARTICIPANT_ID { get; set; }
        public string PARTICIPANT_NAME { get; set; }
        public string PARTICIPANT_GENDER { get; set; }
        public string PARTICIPANT_CONTACT { get; set; }
        public DateTime PARTICIPANT_CREDATE { get; set; }

        public Guid VOUCHER_ID { get; set; }
        public Guid PARTICIPANT_AGEGROUP_ID { get; set; }


        public JF_VOUCHER JF_VOUCHER { get; set; }
        public JF_AGEGROUP JF_AGEGROUP { get; set; }
    }
}
