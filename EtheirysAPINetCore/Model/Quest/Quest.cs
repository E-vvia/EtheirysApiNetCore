using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.ClassJobs;
using EtheirysAPINetCore.Model.Localization;
using System.Collections.Generic;
using System.Linq;

namespace EtheirysAPINetCore.Model.Quest
{
    [Endpoint("quests")]
    public class Quest : Entity
    {
        public LocalizedString Name { get; set; } = new LocalizedString();
        public LocalizedString Description { get; set; } = new LocalizedString();
        public IEnumerable<ClassJobReference>? UsableClassJobs { get; set; } = Enumerable.Empty<ClassJobReference>();
        public ClassJobReference? UnlocksClassJob { get; set; } = null;
        public bool IsHouseRequired { get; set; }
        public bool IsRepeatable { get; set; }
        public int GilReward { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public JournalGenre? JournalGenre { get; set; } = new JournalGenre();
        public IEnumerable<QuestReward> Rewards { get; set; } = Enumerable.Empty<QuestReward>();
    }
}
