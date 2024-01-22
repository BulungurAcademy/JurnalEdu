using JurnalEdu.Domain.Models.Base;
using JurnalEdu.Domain.Models.Sys;

namespace JurnalEdu.Domain.Models.Public;
public class Nationality : BaseInformationEntity<int>
{
    public string WbCode { get; set; }
    public ICollection<Person> Persons { get; set; } = new List<Person>();
}
