using JurnalEdu.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;
namespace JurnalEdu.Domain.Models.Public;
public class Country : BaseInformationEntity<int>
{
    [StringLength(50)]
    public string CountryCode { get; set; }
}