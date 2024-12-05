using EtheirysAPINetCore.Model.Items;

namespace EtheirysAPINetCore.Parameters
{
    public class GearRequest : PaginationRequest<Gear>
    {
        public enum EquipSlots
        {
            All,
            MainHand,
            OffHand,
            Head,
            Body,
            Gloves,
            Waist,
            Legs,
            Feet,
            Ears,
            Neck,
            Wrists,
            FingerL,
            FingerR,
            SoulCrystal
        }

        public EquipSlots[] CanEquip { get; set; } = [];

        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string[] UsedBy { get; set; } = [];
        public string? RepairedBy { get; set; }
        public int? Rarity { get; set; }
        public string? Name { get; set; }

        #region ItemLevel
        public int? MinItemLevel { get; set; }
        public int? ItemLevel { get; set; }
        public int? MaxItemLevel { get; set; }
        #endregion

        #region EquipLevel
        public int? MinEquipLevel { get; set; }
        public int? EquipLevel { get; set; }
        public int? MaxEquipLevel { get; set; }
        #endregion

        #region PhysicalDamage
        public int? MinPhysicalDamage { get; set; }
        public int? PhysicalDamage { get; set; }
        public int? MaxPhysicalDamage { get; set; }
        #endregion

        #region MagicalDamage
        public int? MinMagicalDamage { get; set; }
        public int? MagicalDamage { get; set; }
        public int? MaxMagicalDamage { get; set; }
        #endregion

        #region BlockRate
        public int? MinBlockRate { get; set; }
        public int? BlockRate { get; set; }
        public int? MaxBlockRate { get; set; }
        #endregion

        #region PhysicalDefense
        public int? MinPhysicalDefense { get; set; }
        public int? PhysicalDefense { get; set; }
        public int? MaxPhysicalDefense { get; set; }
        #endregion

        #region MagicalDefense
        public int? MinMagicalDefense { get; set; }
        public int? MagicalDefense { get; set; }
        public int? MaxMagicalDefense { get; set; }
        #endregion

        #region Booleans
        public bool? CanBeHq { get; set; }
        public bool? IsGlamourous { get; set; }
        public bool? IsUnique { get; set; }
        public bool? IsUntradable { get; set; }
        public bool? IsIndisposable { get; set; }
        #endregion
    }
}
