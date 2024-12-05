using EtheirysAPINetCore.Model.Items;

namespace EtheirysAPINetCore.Parameters
{
    public class ItemCategoryRequest : PaginationRequest<ItemCategory>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }

    }
}
