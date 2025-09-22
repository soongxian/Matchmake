namespace JodohFinder.Domain
{
    public class JF_AGEGROUP
    {
        public Guid AGE_GROUP_ID { get; set; }
        public string AGE_GROUP_NAME { get; set; }

        public ICollection<JF_PARTICIPANT> JF_PARTICIPANT { get; set; }
    }
}
