using JurnalEdu.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JurnalEdu.Domain.Models.Public;
public class District : BaseInformationEntity<int>
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
    public int RegionId { get; set; }

    [ForeignKey(nameof(RegionId))]
    public Region Region { get; set; }
}