using JodohFinder.User.UseCase.User.UpdateUser;
using MediatR;

namespace JodohFinder.User.UseCase
{
    internal class UpdateUserHandler : IRequestHandler<UpdateUserCommand, UserDTO>
    {
        private readonly IUserBS _userBS;

        public UpdateUserHandler(IUserBS userBS)
        {
            _userBS = userBS;
        }

        public async Task<UserDTO> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userBS.UpsertUserAsync(request.USER_ID, request.USER_USER_NAME, request.USER_PASSWORD, request.USER_ROLE_ID, cancellationToken);
            return user.JF_UserToDto();
        }
    }
}
