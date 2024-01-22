using JurnalEdu.Domain.Models.Base;
using JurnalEdu.Domain.Models.Sys;

namespace JurnalEdu.Domain.Models.Public;
public class Region : BaseInformationEntity<int>
{
    public string Code { get; set; }
    public string Soato { get; set; }
    public string? RoamingCode { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public ICollection<District> Districts { get; set; } = new List<District>();
    public ICollection<Person> Persons { get; set; } = new List<Person>();
}