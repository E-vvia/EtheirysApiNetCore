using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Items
{
    [Endpoint("itemcategories")]
    public class ItemCategory : Entity
    {
        public LocalizedString Name { get; set; } = new LocalizedString();
        public int Icon { get; set; }
    }
}
