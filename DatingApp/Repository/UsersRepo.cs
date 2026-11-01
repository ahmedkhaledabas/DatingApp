namespace DatingApp.Repository
{
    public class UsersRepo : IUsersRepo
    {
        private readonly DatingAppDbContext context;

        public UsersRepo(DatingAppDbContext context)
        {
            this.context = context;
        }

        public Task<AppUser?> GetUser(int id, CancellationToken cancellationToken = default)
        {
            return context.users
                .AsNoTracking()
                .FirstOrDefaultAsync(user => user.Id == id, cancellationToken);
        }

        public Task<List<AppUser>> GetUsers(CancellationToken cancellationToken = default)
        {
            return context.users
                .AsNoTracking()
                .OrderBy(user => user.Id)
                .ToListAsync(cancellationToken);
        }
    }
}
