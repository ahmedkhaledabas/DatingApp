namespace DatingApp.IRepository
{
    public interface IUsersRepo
    {
        Task<List<AppUser>> GetUsers();

        Task<AppUser> GetUser(int id);


    }
}
