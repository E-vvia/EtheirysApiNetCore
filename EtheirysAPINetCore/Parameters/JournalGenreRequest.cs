using EtheirysAPINetCore.Model.Quest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtheirysAPINetCore.Parameters
{
    public class JournalGenreRequest : PaginationRequest<JournalGenre>
    {
        public LanguageQuery Language { get; set; } = LanguageQuery.EN;
        public string? Name { get; set; }
    }
}
