using JurnalEdu.Domain.Models.Sys;

namespace JurnalEdu.Domain.Models.Public;
public class Citizenship : Nationality
{
    public ICollection<Person> Persons { get; set; } = new List<Person>();
}
