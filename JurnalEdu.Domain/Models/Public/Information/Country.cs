using JurnalEdu.Domain.Models.Base;
using JurnalEdu.Domain.Models.Sys;
namespace JurnalEdu.Domain.Models.Public;
public class Country : BaseInformationEntity<int>
{
    public string CountryCode { get; set; }
    public ICollection<Region> Regions { get; set; } = new List<Region>();
    public ICollection<Person> Persons { get; set; } = new List<Person>();
}