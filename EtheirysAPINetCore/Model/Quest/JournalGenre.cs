using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Quest
{
    [Endpoint("journalgenres")]
    public record JournalGenre : Entity
    {
        public int Icon { get; set; }
        public LocalizedString Name { get; set; } = new();
        public JournalCategory? JournalCategory { get; set; } = new();
    }
}
