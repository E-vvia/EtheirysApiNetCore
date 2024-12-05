using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Items
{
    [Endpoint("itemcategories")]
    public record ItemCategory : Entity
    {
        public LocalizedString Name { get; set; } = new();
        public int Icon { get; set; }
    }
}
