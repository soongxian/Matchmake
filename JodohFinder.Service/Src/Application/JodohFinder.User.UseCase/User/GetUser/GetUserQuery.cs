using MediatR;

namespace JodohFinder.User.UseCase
{
    public class GetUserQuery : IRequest<List<UserDTO>>
    {
        public Guid? userId { get; set; }
    }
}
