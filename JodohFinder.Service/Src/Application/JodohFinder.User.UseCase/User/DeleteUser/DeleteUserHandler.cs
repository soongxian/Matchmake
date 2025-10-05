using MediatR;

namespace JodohFinder.User.UseCase
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, string>
    {
        private readonly IUserBS _userBS;

        public DeleteUserHandler(IUserBS userBS)
        {
            _userBS = userBS;
        }

        public async Task<string> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userBS.DeleteUserAsync(request.USER_ID, cancellationToken);
            return user.USER_ID.ToString();
        }
    }
}
