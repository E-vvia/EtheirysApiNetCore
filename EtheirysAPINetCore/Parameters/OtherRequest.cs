using EtheirysAPINetCore.Model.Items;

namespace EtheirysAPINetCore.Parameters
{
    public class OtherRequest : PaginationRequest<Other>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }

        #region ItemLevel
        public int? MinItemLevel { get; set; }
        public int? ItemLevel { get; set; }
        public int? MaxItemLevel { get; set; }
        #endregion
        public int? Rarity { get; set; }
    }
}
