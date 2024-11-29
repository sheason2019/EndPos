using Microsoft.EntityFrameworkCore;

namespace EndPos.Applications.Station.Service.Model;

public class StationContext(IConfiguration configuration) : DbContext
{
  public required DbSet<User> Users { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    var connectionString = configuration.GetConnectionString("StationContext");
    optionsBuilder.UseNpgsql(connectionString);
  }
}
