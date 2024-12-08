using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Duty
{
    [Endpoint("duties")]
    public class Duty : Entity
    {
        public LocalizedString Name { get; set; } = null!;
        public LocalizedString Description { get; set; } = null!;
        public DutyType Type { get; set; } = null!;
        public int ClassJobLevel { get; set; }
    }
}
