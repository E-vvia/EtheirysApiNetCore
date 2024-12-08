using EtheirysAPINetCore.Model.Localization;

namespace EtheirysAPINetCore.Model.ClassJobs
{
    public class ClassJobReference
    {
        public int Id { get; set; }
        public LocalizedString Name { get; set; } = null!;
        public LocalizedString Abbreviation { get; set; } = null!;
    }
}
