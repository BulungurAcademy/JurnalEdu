using JurnalEdu.Domain.Models.Base;
using JurnalEdu.Domain.Models.Sys;

namespace JurnalEdu.Domain.Models.Public;
public class District : BaseInformationEntity<int>
{
    public string Code { get; set; }
    public string Soato { get; set; }
    public string? RoamingCode { get; set; }
    public int RegionId { get; set; }
    public Region Region { get; set; }

    public ICollection<Person> Persons { get; set; } = new List<Person>();
}