using JurnalEdu.Core.Enums;
using JurnalEdu.Core.Extensions;
using JurnalEdu.Domain.Models.Public;
using System.Net.NetworkInformation;

namespace JurnalEdu.Domain.Models.Sys;
public class User
{
    public int Id { get; set; }

    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public string PasswordSalt { get; set; }

    public string ProheNumber { get; set; }
    public string Email { get; set; }

    public int PersonId { get; set; }
    public Person Person { get; set; }

    public UserRole Role { get; set; }
    public State State { get; set; }

    public string? RefreshToken { get; private set; }
    public DateTime? RefreshTokenExpireDate { get; private set; }

    public DateTime CreatedAt { get; } = DateTime.Now;

    public void MarkAsActive() => State = State.Active;
    public void MarkAsPassive() => State = State.Passive;
}
