namespace JodohFinder.Domain
{
    public class JF_USER
    {
        public Guid USER_ID { get; set; }
        public string USER_USERNAME { get; set; }
        public string USER_PASSWORD { get; set; }

        public Guid RoleId { get; set; }
    }
}
