using EtheirysAPINetCore.Model.ClassJobs;

namespace EtheirysAPINetCore.Parameters
{
    public class ClassJobRequest : PaginationRequest<ClassJob>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }
        public string? Abbreviation { get; set; }
        public bool? CanQueueForDuty { get; set; }
    }
}
