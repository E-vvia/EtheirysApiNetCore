using EtheirysAPINetCore.Model.Quest;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EtheirysAPINetCore.Parameters
{
    public class QuestRequest : PaginationRequest<Quest>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }
        public string[] PlayableBy { get; set; } = Array.Empty<string>();
        public string? UnlocksClassJob { get; set; }
        public string? JournalGenre { get; set; }
        public string? JournalCategory { get; set; }
        public string? JournalSection { get; set; }
        public bool? IsHouseRequired { get; set; }
        public bool? IsRepeatable { get; set; }
        public int? MinLevel { get; set; }
        public int? Level { get; set; }
        public int? MaxLevel { get; set; }

    }
}
