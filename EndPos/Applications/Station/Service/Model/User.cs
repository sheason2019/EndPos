namespace EndPos.Applications.Station.Service.Model;

public class User
{
  public int Id { get; set; }

  public required string Key { get; set; }

  public required string Name { get; set; }

  public required byte[] PasswordHash { get; set; }

  public required byte[] PasswordSalt { get; set; }

  public DateTime CreatedAt { get; set; } = DateTime.Now;

  public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
