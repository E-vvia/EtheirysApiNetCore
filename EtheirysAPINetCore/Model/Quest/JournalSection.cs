using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Quest
{
    [Endpoint("journalsections")]
    public class JournalSection : Entity
    {
        public LocalizedString Name { get; set; } = new LocalizedString();
    }
}