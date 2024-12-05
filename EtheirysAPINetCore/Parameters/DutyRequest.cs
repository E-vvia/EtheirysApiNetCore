using EtheirysAPINetCore.Model.Duty;

namespace EtheirysAPINetCore.Parameters
{
    public class DutyRequest : PaginationRequest<Duty>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int? MinClassJobLevel { get; set; }
        public int? ClassJobLevel { get; set; }
        public int? MaxClassJobLevel { get; set; }
    }
}
