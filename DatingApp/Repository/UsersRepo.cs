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
            //if (user is not null)
            //{
            return user;
            //}
            //throw new NullReferenceException();
        }

        public async Task<List<AppUser>> GetUsers()
        {
            List<AppUser>? users = await context.users.ToListAsync();
            return users;
        }
    }
}
