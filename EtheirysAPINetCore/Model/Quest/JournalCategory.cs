using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Quest
{
    [Endpoint("journalcategories")]
    public class JournalCategory : Entity
    {
        public LocalizedString Name { get; set; } = new LocalizedString();
        public JournalSection? JournalSection { get; set; } = null;
    }
}