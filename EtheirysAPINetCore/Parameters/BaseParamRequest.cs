using EtheirysAPINetCore.Model.Items;

namespace EtheirysAPINetCore.Parameters
{
    public class BaseParamRequest : PaginationRequest<BaseParam>
    {
        public LanguageQuery? Language { get; set; }
        public string? Name { get; set; }
    }
}
