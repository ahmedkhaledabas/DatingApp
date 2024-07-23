
namespace DatingApp.Repository
{
    public class UsersRepo : IUsersRepo
    {
        private readonly DatingAppDbContext context;

        public UsersRepo(DatingAppDbContext context)
        {
            this.context = context;
        }

        public async Task<AppUser> GetUser(int id)
        {
            AppUser? user = await context.users.FindAsync(id);
            if (user is not null)
            {
                return user;
            }
            return new AppUser();
        }

        public async Task<List<AppUser>> GetUsers()
        {
            List<AppUser>? users = await context.users.ToListAsync();
            if(users is not null && users.Count > 0)
            return users;
            //modified to class with obj , status , msg Props
            return new List<AppUser>();
        }
    }
}
