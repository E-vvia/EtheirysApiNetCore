using EtheirysAPINetCore.Model.Items;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EtheirysAPINetCore.Parameters
{
    public class ItemRequest : PaginationRequest<Item>
    {
        public enum ItemTypes
        {
            All,
            Gear,
            Material,
            MedicineMeal,
            Other
        }
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public int? Rarity { get; set; }
        public string? Name { get; set; }
        public ItemTypes[] Type { get; set; } = Array.Empty<ItemTypes>();
    }
}
