using BepInEx;
using BepInEx.Logging;

namespace R2API;

[BepInPlugin(OrbAPI.PluginGUID, OrbAPI.PluginName, OrbAPI.PluginVersion)]
public sealed class OrbPlugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger { get; set; }

    private void Awake()
    {
        Logger = base.Logger;
    }

    private void OnDestroy()
    {
        OrbAPI.UnsetHooks();
    }
}
