namespace DatingApp.Services
{
    public class AppUserServices : IAppUserService
    {
        private readonly IUsersRepo usersRepo;

        public AppUserServices(IUsersRepo usersRepo)
        {
            this.usersRepo = usersRepo;
        }

        public async Task<AppUserDTO?> GetAppUser(int id, CancellationToken cancellationToken = default)
        {
            var user = await usersRepo.GetUser(id, cancellationToken);
            return user is null ? null : MapAppUser.UserToDTO(user);
        }

        public async Task<List<AppUserDTO>> GetAppUsers(CancellationToken cancellationToken = default)
        {
            var users = await usersRepo.GetUsers(cancellationToken);
            return MapAppUser.UsersToDTOs(users);
        }
    }
}
