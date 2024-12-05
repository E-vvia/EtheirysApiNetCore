using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.ClassJobs;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Quest
{
    [Endpoint("quests")]
    public record Quest : Entity
    {
        public LocalizedString Name { get; set; } = new();
        public LocalizedString Description { get; set; } = new();
        public IEnumerable<ClassJobReference>? UsableClassJobs { get; set; } = [];
        public ClassJobReference? UnlocksClassJob { get; set; } = new();
        public bool IsHouseRequired { get; set; }
        public bool IsRepeatable { get; set; }
        public int GilReward { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public JournalGenre? JournalGenre { get; set; } = new();
        public IEnumerable<QuestReward> Rewards { get; set; } = [];
    }
}
