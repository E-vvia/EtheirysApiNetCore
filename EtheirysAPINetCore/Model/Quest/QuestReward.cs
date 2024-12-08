using EtheirysAPINetCore.Model.Items;

namespace EtheirysAPINetCore.Model.Quest
{
    public class QuestReward
    {
        public Item Item { get; set; } = new Item();
        public int Count { get; set; }
        public bool IsOptional { get; set; }
    }
}
