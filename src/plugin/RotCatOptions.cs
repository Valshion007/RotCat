using BepInEx.Logging;
using Menu.Remix.MixedUI;
using Menu.Remix.MixedUI.ValueTypes;
using UnityEngine;

namespace RotCat;
public class RotCatOptions : OptionInterface {
    private readonly ManualLogSource Logger;
    private UIelement[] UIArrPlayerOptions;

    public RotCatOptions(RotCat pluginInstance, ManualLogSource logSource) {
        Logger = logSource;
    }

    public override void Initialize() {
        OpTab opTab = new OpTab(this, "OptionsLongLegs");
        this.Tabs = new[]
        {
            opTab
        };

        UIArrPlayerOptions = new UIelement[]
        {
            new OpLabel(260f, 570f, "Options", true),
           
        };
        opTab.AddItems(UIArrPlayerOptions);
    }
}
