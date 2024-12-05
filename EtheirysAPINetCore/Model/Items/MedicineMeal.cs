using EtheirysAPINetCore.Endpoints;

namespace EtheirysAPINetCore.Model.Items
{
    [Endpoint("medicinesmeals")]
    public record MedicineMeal : Item
    {
        public bool CanBeHq { get; set; }
        public int ItemLevel { get; set; }
        public int VendorValue { get; set; }
        public int VendorCost { get; set; }
        public int CastTime { get; set; }
        public int Cooldown { get; set; }
    }
}
