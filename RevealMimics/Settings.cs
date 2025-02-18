using BepInEx.Configuration;
using IdleSlayerMods.Common.Config;

namespace RevealMimics;

internal sealed class Settings(ConfigFile cfg) : BaseConfig(cfg)
{
    internal ConfigEntry<bool> ShouldRevealMultipliers;
    internal ConfigEntry<bool> ShouldRevealDuplicator;
    internal ConfigEntry<bool> ShouldRevealArmoryChest;

    protected override void SetBindings()
    {
        ShouldRevealMultipliers = Bind("General", "ShouldRevealMultipliers", true,
            "Should reveal multipliers in chest hunt");
        ShouldRevealDuplicator = Bind("General", "ShouldRevealDuplicator", true,
            "Should reveal duplicator item in chest hunt");
        ShouldRevealArmoryChest = Bind("General", "ShouldRevealArmoryChest", true,
            "Should reveal armory chest in chest hunt");
    }
}
