using System;

namespace IAGrim.UI.Misc
{
    class RequestRecipeArgument : EventArgs {
        public string RecipeRecord { get; set; }
        public string Callback { get; set; }
    }
}
