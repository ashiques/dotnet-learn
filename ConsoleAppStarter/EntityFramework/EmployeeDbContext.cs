using Microsoft.EntityFrameworkCore;
namespace ConsoleAppStarter;

public class EmployeeDbContext : DbContext
{
    public DbSet<Employees> employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User Id=myuser;Password=secret;Database=mydatabase");
    }

}