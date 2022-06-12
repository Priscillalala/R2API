using BepInEx;

namespace R2API;

[BepInPlugin(DamageAPI.PluginGUID, DamageAPI.PluginName, DamageAPI.PluginVersion)]
public sealed class DamageTypePlugin : BaseUnityPlugin
{
    private void OnEnable()
    {
        DamageAPI.SetHooks();
    }

    private void OnDisable()
    {
        DamageAPI.UnsetHooks();
    }
}
