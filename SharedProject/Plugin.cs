using Barotrauma;
using HarmonyLib;
using System.Runtime.CompilerServices;

[assembly: IgnoresAccessChecksTo("Barotrauma")]
[assembly: IgnoresAccessChecksTo("DedicatedServer")]
[assembly: IgnoresAccessChecksTo("BarotraumaCore")]

namespace MyModName;
public partial class Plugin : IAssemblyPlugin
{
    public static Plugin Instance { get; private set; } = null!;
    public static string Name => "My Mod Name";
    public static string ShortName => "MyMod";
    public static string Id => "mymod";
    public Harmony harmony = new(Id);
    public Networking Networking = new();

    public void Initialize()
    {
        Logging.Info($"Welcome to \"{Name}\"!");
#if SERVER
        InitializeServer();
#elif CLIENT
        InitializeClient();
#endif
        Logging.Info($"{Name} initialized!");
    }

    public void OnLoadCompleted()
    {
        // After all plugins have loaded
        // Put code that interacts with other plugins here.
    }

    public void PreInitPatching()
    {
        Instance = this;
        // Not yet supported: Called during the Barotrauma startup phase before vanilla content is loaded.
    }

    public void Dispose()
    {
        // Cleanup your plugin!
        Instance = null!;
        harmony.UnpatchSelf();
    }
}
