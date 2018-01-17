using System.Collections.Generic;

namespace IAGrim.Database.Model
{
    public class DatabaseItemDto {
        public string Name { get; set; }

        public string Record { get; set; }
        public ISet<RecipeDbStatRow> Stats { get; } = new HashSet<RecipeDbStatRow>();
    }
}
