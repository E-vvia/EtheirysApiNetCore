using EtheirysAPINetCore.Endpoints;

namespace EtheirysAPINetCore.Model.Items
{
    [Endpoint("EquipSlots")]
    public record EquipSlot : Entity
    {
        public int MainHand { get; set; }
        public int OffHand { get; set; }
        public int Head { get; set; }
        public int Body { get; set; }
        public int Gloves { get; set; }
        public int Waist { get; set; }
        public int Legs { get; set; }
        public int Feet { get; set; }
        public int Ears { get; set; }
        public int Neck { get; set; }
        public int Wrists { get; set; }
        public int FingerL { get; set; }
        public int FingerR { get; set; }
        public int SoulCrystal { get; set; }
    }
}
