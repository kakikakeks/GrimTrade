using IAGrim.Database.Interfaces;
using System.Collections.Generic;

namespace IAGrim.Database
{
    public class SearchResult {
        public List<PlayerHeldItem> Items { get; set; }
        public int NumResults { get; set; }
    }
}
