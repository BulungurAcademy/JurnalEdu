using JurnalEdu.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JurnalEdu.Domain.Models.Public;

[Index(nameof(Soato), IsUnique = true)]
public class Region : BaseInformationEntity<int>
{
    [StringLength(50)]
    public string Code { get; set; }

    [Required]
    [StringLength(50)]
    public string Soato { get; set; }

    [StringLength(50)]
    public string? RoamingCode { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int CountryId { get; set; }

    [ForeignKey(nameof(CountryId))]
    public Country Country { get; set; }
}