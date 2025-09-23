namespace JodohFinder.Domain
{
    public partial class JF_ROLE
    {
        public Guid ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }

        public ICollection<JF_USER> JF_USER { get; set; }

    }
}
