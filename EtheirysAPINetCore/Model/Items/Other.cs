using EtheirysAPINetCore.Endpoints;

namespace EtheirysAPINetCore.Model.Items
{
    [Endpoint("others")]
    public record Other : Item
    {
        public int ItemLevel { get; set; }
        public int VendorValue { get; set; }
        public int VendorCost { get; set; }
        public int CastTime { get; set; }
        public int Cooldown { get; set; }
    }
}
