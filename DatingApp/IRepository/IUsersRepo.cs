namespace DatingApp.IRepository
{
    public interface IUsersRepo
    {
        Task<List<AppUser>> GetUsers(CancellationToken cancellationToken = default);

        Task<AppUser?> GetUser(int id, CancellationToken cancellationToken = default);
    }
}
