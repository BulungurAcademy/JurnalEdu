using JurnalEdu.Core.Enums;
namespace JurnalEdu.Domain.Models.Base;
public class BaseInformationEntity<T>
{
    public T Id { get; set; }
    public string OrderCode { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
    public State State { get; set; }
    public DateTime CreatedAt { get; } = DateTime.Now;
}