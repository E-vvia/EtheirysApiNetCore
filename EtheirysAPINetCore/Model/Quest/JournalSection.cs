using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Quest
{
    [Endpoint("journalsections")]
    public record JournalSection : Entity
    {
        public LocalizedString Name { get; set; } = new();
    }
}