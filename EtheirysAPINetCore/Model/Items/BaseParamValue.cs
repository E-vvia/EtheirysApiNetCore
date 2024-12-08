using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.Items
{
    public class BaseParamValue
    {
        public int Id { get; set; }
        public LocalizedString Name { get; set; } = new LocalizedString();
        public LocalizedString Description { get; set; } = new LocalizedString();
        public int Value { get; set; }
    }
}
