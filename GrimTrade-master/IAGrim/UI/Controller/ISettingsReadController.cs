namespace IAGrim.UI.Controller
{
    interface ISettingsReadController {
        bool MinimizeToTray { get; }
        bool MergeDuplicates { get; }
        bool TransferAnyMod { get; }
        bool SecureTransfers { get; }
        bool ShowRecipesAsItems { get; }
        bool AutoUpdateModSettings { get; }
    }
}
