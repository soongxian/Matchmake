using JodohFinder.Guard;
using MediatR;

namespace JodohFinder.User.UseCase
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, List<UserDTO>>
    {
        private IUserBS _userBS;

        public GetUserHandler(IUserBS userBS)
        {
            _userBS = userBS;
        }

        public async Task<List<UserDTO>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            Guid? userId = request.userId ?? null;
            var user = await _userBS.GetAsync(userId);
            if (user is null)
            {
                throw new GuardNotFoundException(userId.ToString());
            }

            return user.Select(r => r.JF_UserToDto()).ToList();
        }
    }
}
