using EtheirysAPINetCore.Model.Duty;

namespace EtheirysAPINetCore.Parameters
{
    public class DutyTypeRequest : PaginationRequest<DutyType>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }
    }
}
