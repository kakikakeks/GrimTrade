using System.Collections.Generic;

namespace IAGrim.Services.Crafting.dto
{
    class CraftableRecipes {
        public List<ComponentListEntry> Relics { get; set; }
        public List<ComponentListEntry> Misc { get; set; }
        public List<ComponentListEntry> Components { get; set; }
    }
}
