using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Items
{
    [Endpoint("items")]
    public record Item : Entity
    {
        public string Type { get; set; } = string.Empty;
        public ItemCategory Category { get; set; } = new ItemCategory();
        public LocalizedString Name { get; set; } = new LocalizedString();
        public LocalizedString Description { get; set; } = new LocalizedString();
        public int Icon { get; set; }
        public int StackSize { get; set; }
        public int Rarity { get; set; }
    }
}
