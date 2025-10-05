using MediatR;

namespace JodohFinder.User.UseCase.User.UpdateUser
{
    public class UpdateUserCommand : IRequest<UserDTO>
    {
        public Guid USER_ID { get; set; }
        public string USER_USER_NAME { get; set; }
        public string USER_PASSWORD { get; set; }
        public Guid USER_ROLE_ID { get; set; }
    }
}
