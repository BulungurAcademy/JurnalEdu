using JurnalEdu.Core.Enums;
using System.ComponentModel.DataAnnotations;
namespace JurnalEdu.Domain.Models.Base;
public abstract class BaseInformationEntity<T>
{
    [Key]
    [Range(1, int.MaxValue)]
    public T Id { get; set; }

    [Required]
    [StringLength(50)]
    public string OrderCode { get; set; }

    [Required]
    [StringLength(500)]
    public string FullName { get; set; }

    [Required]
    [StringLength(250)]
    public string ShortName { get; set; }

    [Required]
    public State State { get; set; }

    [Required]
    public DateTime CreatedAt { get; } = DateTime.Now;
}