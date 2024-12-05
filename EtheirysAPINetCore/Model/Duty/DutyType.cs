using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Duty
{
    [Endpoint("DutyTypes")]
    public class DutyType
    {
        public int Id { get; set; }
        public LocalizedString Name { get; set; } = null!;
        public int Icon { get; set; }

    }
}
