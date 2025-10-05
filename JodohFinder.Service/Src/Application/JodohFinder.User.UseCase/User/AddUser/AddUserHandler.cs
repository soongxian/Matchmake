using MediatR;

namespace JodohFinder.User.UseCase
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, UserDTO>
    {
        private readonly IUserBS _userBS;

        public AddUserHandler(IUserBS userBS)
        {
            _userBS = userBS;
        }

        public async Task<UserDTO> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userBS.UpsertUserAsync(Guid.NewGuid(), request.USER_USER_NAME, request.USER_PASSWORD, request.USER_ROLE_ID);

            return user.JF_UserToDto();
        }
    }
}
