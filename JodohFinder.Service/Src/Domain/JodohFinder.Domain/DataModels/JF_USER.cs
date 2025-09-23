namespace JodohFinder.Domain
{
    public partial class JF_USER
    {
        public Guid USER_ID { get; set; }
        public string USER_USERNAME { get; set; }
        public string USER_PASSWORD { get; set; }

        public Guid USER_ROLE_ID { get; set; }

        public JF_ROLE JF_ROLE { get; set; }
    }
}
