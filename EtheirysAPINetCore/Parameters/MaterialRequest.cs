using EtheirysAPINetCore.Model.Items;

namespace EtheirysAPINetCore.Parameters
{
    public class MaterialRequest : PaginationRequest<Material>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }
        public int? Rarity { get; set; }
    }
}
