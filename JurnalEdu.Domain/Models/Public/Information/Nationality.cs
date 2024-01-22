using JurnalEdu.Domain.Models.Base;

namespace JurnalEdu.Domain.Models.Public;
public class Nationality : BaseInformationEntity<int>
{
    public string WbCode { get; set; }
}
