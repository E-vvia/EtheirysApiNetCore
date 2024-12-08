using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Items
{
    [Endpoint("BaseParams")]
    public class BaseParam : Entity
    {
        public LocalizedString Name { get; set; } = new LocalizedString();
        public LocalizedString Description { get; set; } = new LocalizedString();
        public int OneHandWeaponPercent { get; set; }
        public int OffHandPercent { get; set; }
        public int HeadPercent { get; set; }
        public int ChestPercent { get; set; }
        public int HandsPercent { get; set; }
        public int WaistPercent { get; set; }
        public int LegsPercent { get; set; }
        public int FeetPercent { get; set; }
        public int EarringPercent { get; set; }
        public int NecklacePercent { get; set; }
        public int BraceletPercent { get; set; }
        public int RingPercent { get; set; }
        public int TwoHandWeaponPercent { get; set; }
        public int UnderArmorPercent { get; set; }
        public int ChestHeadPercent { get; set; }
        public int ChestHeadLegsFeetPercent { get; set; }
        public int LegsFeetPercent { get; set; }
        public int HeadChestHandsLegsFeetPercent { get; set; }
        public int ChestLegsGlovesPercent { get; set; }
        public int ChestLegsFeetPercent { get; set; }
    }
}
