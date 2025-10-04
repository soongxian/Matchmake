using MediatR;

namespace JodohFinder.User.UseCase
{
    public class AddUserCommand : IRequest<string>
    {
        public string USER_USER_NAME { get; set; }
        public string USER_PASSWORD { get; set; }
        public int USER_ROLE_ID { get; set; }
    }
}
