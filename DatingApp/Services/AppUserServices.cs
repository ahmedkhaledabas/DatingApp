
namespace DatingApp.Services
{
    public class AppUserServices : IAppUserService
    {
        private readonly IUsersRepo usersRepo; 
        
        public AppUserServices(IUsersRepo usersRepo)
        {
            this.usersRepo = usersRepo;
        }

        public async Task<AppUserDTO> GetAppUser(int id)
        {
            AppUser? user = await usersRepo.GetUser(id);
            return MapAppUser.UserToDTO(user);
        }

        public async Task<List<AppUserDTO>> GetAppUsers()
        {
            List<AppUser>? users = await usersRepo.GetUsers();
            return MapAppUser.UsersToDTOs(users);
        }

    }
}
