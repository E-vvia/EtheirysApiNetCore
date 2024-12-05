using EtheirysAPINetCore.Model.Items;

namespace EtheirysAPINetCore.Parameters
{
    public class ItemRequest : PaginationRequest<Item>
    {
        public enum ItemTypes
        {
            All,
            Gear,
            Material,
            MedicineMeal,
            Other
        }
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public int? Rarity { get; set; }
        public string? Name { get; set; }
        public ItemTypes[] Type { get; set; } = [];
    }
}
