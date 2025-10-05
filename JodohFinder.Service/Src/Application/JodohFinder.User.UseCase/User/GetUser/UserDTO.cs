namespace JodohFinder.User.UseCase
{
    public class UserDTO
    {
        public Guid USER_ID { get; set; } = Guid.Empty;
        public string USER_USERNAME { get; set; } = string.Empty;
        public string USER_PASSWORD { get; set; } = string.Empty;
        public Guid USER_ROLE_ID { get; set; } = Guid.Empty;
    }
}
