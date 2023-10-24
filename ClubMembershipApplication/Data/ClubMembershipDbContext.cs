using Microsoft.EntityFrameworkCore;

namespace ClubMembershipApplication;

public class ClubMembershipDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}ClubMembershipDb.db");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<User> Users { get; set; }
}
