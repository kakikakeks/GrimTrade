using IAGrim.Services.Dto;

namespace IAGrim.Database.Model
{
    public class RecipeDbStatRow : DBSTatRow {
        public DatabaseItemDto Parent { get; set; }
    }
}
