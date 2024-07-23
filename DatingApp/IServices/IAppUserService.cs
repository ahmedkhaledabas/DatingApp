
namespace DatingApp.IServices
{
    public interface IAppUserService
    {
        Task<List<AppUserDTO>> GetAppUsers();

        Task<AppUserDTO> GetAppUser(int id);
    }
}
