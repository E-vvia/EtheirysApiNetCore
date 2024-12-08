using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Quest
{
    [Endpoint("journalgenres")]
    public class JournalGenre : Entity
    {
        public int Icon { get; set; }
        public LocalizedString Name { get; set; } = new LocalizedString();
        public JournalCategory? JournalCategory { get; set; } = null;
    }
}
