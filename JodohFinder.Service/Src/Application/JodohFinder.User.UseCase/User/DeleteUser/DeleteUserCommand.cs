using MediatR;

namespace JodohFinder.User.UseCase
{
    public class DeleteUserCommand : IRequest<string>
    {
        public Guid USER_ID { get; set; }
    }
}
