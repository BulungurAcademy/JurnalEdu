using JurnalEdu.Domain.Models.Base;
namespace JurnalEdu.Domain.Models.Public;
public class Country : BaseInformation<int>
{
    public string CountryCode { get; set; }
}