using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.ClassJobs
{
    [Endpoint("classjobs")]
    public record ClassJob : Entity
    {
        public LocalizedString Name { get; set; } = null!;
        public LocalizedString Abbreviation { get; set; } = null!;
        public int HitPointsModifier { get; set; }
        public int ManaPointsModifier { get; set; }
        public int StrengthModifier { get; set; }
        public int VitalityModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int IntelligenceModifier { get; set; }
        public int MindModifier { get; set; }
        public int PietyModifier { get; set; }
        public int? ParentClassJobId { get; set; }
        public int StartingLevel { get; set; }
        public bool IsLimitedJob { get; set; }
        public bool CanQueueForDurty { get; set; }
    }
}
