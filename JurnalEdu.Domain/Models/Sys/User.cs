using JurnalEdu.Core.Enums;
using JurnalEdu.Domain.Models.Public.Information;

namespace JurnalEdu.Domain.Models.Sys;
public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public string PasswordSalt { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string? RefreshToken { get; private set; }
    public DateTime? RefreshTokenExpireDate { get; private set; }
    public int OrganizationId { get; set; }
    public UserRole Role { get; set; }
    public State State { get; set; }
    public int PersonId { get; set; }
    public DateTime CreatedAt { get; } = DateTime.Now;
    public Organization Organization { get; set; }
    public Person Person { get; set; }

    public void MarkAsActive() => State = State.Active;
    public void MarkAsPassive() => State = State.Passive;
}
