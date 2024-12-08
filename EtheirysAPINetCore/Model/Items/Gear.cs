using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.ClassJobs;
using System.Collections.Generic;
using System.Linq;

namespace EtheirysAPINetCore.Model.Items
{
    [Endpoint("Gear")]
    public class Gear : Item
    {
        public EquipSlot? EquipSlot { get; set; }
        public int ItemLevel { get; set; }
        public int EquipLevel { get; set; }
        public int VendorValue { get; set; }
        public int VendorCost { get; set; }
        public bool Lot { get; set; }
        public bool CanBeHq { get; set; }
        public int DyeCount { get; set; }
        public bool IsCrestWorthy { get; set; }
        public bool IsAdvancedMeldingPermitted { get; set; }
        public bool IsGlamourous { get; set; }
        public bool IsUnique { get; set; }
        public bool IsUntradable { get; set; }
        public bool IsIndisposable { get; set; }
        public int PhysicalDamage { get; set; }
        public int MagicalDamage { get; set; }
        public int BlockRate { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicalDefense { get; set; }
        public int MateriaSlotCount { get; set; }
        public int Desynth { get; set; }
        public Item? RepairItem { get; set; }
        public IEnumerable<BaseParamValue> BaseParamValues { get; set; } = Enumerable.Empty<BaseParamValue>();
        public IEnumerable<BaseParamValue> BaseParamValuesSpecial { get; set; } = Enumerable.Empty<BaseParamValue>();
        public IEnumerable<ClassJobReference> UsedBy { get; set; } = Enumerable.Empty<ClassJobReference>();
        public ClassJobReference RepairedBy { get; set; } = new ClassJobReference();
    }
}
