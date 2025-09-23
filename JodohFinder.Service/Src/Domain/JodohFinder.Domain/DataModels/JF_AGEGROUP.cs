namespace JodohFinder.Domain
{
    public partial class JF_AGEGROUP
    {
        public Guid AGE_GROUP_ID { get; set; }
        public string AGE_GROUP_CATEGORY { get; set; }

        public ICollection<JF_PARTICIPANT> JF_PARTICIPANT { get; set; }

        public JF_AGEGROUP()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }
}
