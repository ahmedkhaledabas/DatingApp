namespace DatingApp.Data
{
    public class DatingAppDbContext : DbContext
    {
        public DatingAppDbContext(DbContextOptions<DatingAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppUser> users { get; set; } = null!;
    }
}
