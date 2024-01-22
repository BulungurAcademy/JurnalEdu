using JurnalEdu.Core.Enums;
using JurnalEdu.Core.Extensions;
using JurnalEdu.Domain.Models.Public;

namespace JurnalEdu.Domain.Models.Sys;
public class Person
{
    public int Id { get; set; }

    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }

    public DateTime BirthDate { get; set; }
    public Gender? Gender { get; set; }
    public string Pinfl { get; set; }
    public string Inn { get; set; }

    public int BirthCountryId { get; set; }
    public Country Country { get; set; }

    public int BirthRegionId { get; set; }
    public Region BirthRegion { get; set; }

    public int BirthDistrictId { get; set; }
    public District BirthDistrict { get; set; }

    public int? Nationalityid { get; set; }
    public Nationality? Nationality { get; set; }

    public int? CitizenshipId { get; set; }
    public Citizenship? Citizenship { get; set; }

    public int? LivingRegionId { get; set; }
    public Region? LivingRegion { get; set; }

    public int? LivingDistrictId { get; set; }
    public District? LivingDistrict { get; set; }

    public State State { get; set; }
    public string PassportSeria { get; set; }
    public string PassportNumber { get; set; }
    public DateTime? PassportDate { get; set; }
    public DateTime? PassportExpiration { get; set; }
    public string? PassportGivenName { get; set; }

    public DateTime CreatedAt { get; } = DateTime.Now;

    public string GetFullFIO() => StringExtensions.GetFullFIO(this.LastName ,this.FirstName, this.MiddleName);
    public string GetFIO() => StringExtensions.GetFIO($"{this.LastName} {this.FirstName} {this.MiddleName}");
}