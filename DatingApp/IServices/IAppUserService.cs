namespace DatingApp.IServices
{
    public interface IAppUserService
    {
        Task<List<AppUserDTO>> GetAppUsers(CancellationToken cancellationToken = default);

        Task<AppUserDTO?> GetAppUser(int id, CancellationToken cancellationToken = default);
    }
}
