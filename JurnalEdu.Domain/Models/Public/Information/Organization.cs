using JurnalEdu.Domain.Models.Base;
using JurnalEdu.Domain.Models.Sys;

namespace JurnalEdu.Domain.Models.Public.Information;
public class Organization : BaseInformationEntity<int>
{
    public ICollection<User> Users { get; set; } = new List<User>();
}
