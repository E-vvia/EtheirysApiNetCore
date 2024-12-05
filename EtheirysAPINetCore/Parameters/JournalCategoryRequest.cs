using EtheirysAPINetCore.Model.Quest;

namespace EtheirysAPINetCore.Parameters
{
    public class JournalCategoryRequest : PaginationRequest<JournalCategory>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }
    }
}
