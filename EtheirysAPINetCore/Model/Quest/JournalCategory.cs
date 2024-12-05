using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Quest
{
    [Endpoint("journalcategories")]
    public record JournalCategory : Entity
    {
        public LocalizedString Name { get; set; } = new();
        public JournalSection? JournalSection { get; set; } = new();
    }
}