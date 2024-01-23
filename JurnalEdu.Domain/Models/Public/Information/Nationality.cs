using JurnalEdu.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace JurnalEdu.Domain.Models.Public;
public class Nationality : BaseInformationEntity<int>
{
    [StringLength(50)]
    public string WbCode { get; set; }
}