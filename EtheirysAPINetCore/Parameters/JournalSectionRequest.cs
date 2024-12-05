using EtheirysAPINetCore.Model.Quest;

namespace EtheirysAPINetCore.Parameters
{
    public class JournalSectionRequest : PaginationRequest<JournalSection>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }
    }
}
