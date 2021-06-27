// Runecarving | JotunnModStub
// a Valheim mod that adds rune-themed item augmentation
// built on skeleton using Jötunn
// 
// File:    Runecarving.cs
// Project: Runecarving

using BepInEx;
using UnityEngine;
using BepInEx.Configuration;
using Jotunn.Utils;

namespace Runecarving
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    //[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class Runecarving : BaseUnityPlugin
    {
        public const string PluginGUID = "com.AhiranDev.Runecarving";
        public const string PluginName = "Runecarving";
        public const string PluginVersion = "0.0.1";

        private void Awake()
        {
            // Do all your init stuff here
            // Acceptable value ranges can be defined to allow configuration via a slider in the BepInEx ConfigurationManager: https://github.com/BepInEx/BepInEx.ConfigurationManager
            Config.Bind<int>("Main Section", "Example configuration integer", 1, new ConfigDescription("This is an example config, using a range limitation for ConfigurationManager", new AcceptableValueRange<int>(0, 100)));

            // Jotunn comes with its own Logger class to provide a consistent Log style for all mods using it
            Jotunn.Logger.LogInfo("Runecarving has dug in");
        }

#if DEBUG
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F6))
            { // Set a breakpoint here to break on F6 key press
            }
        }
#endif
    }
}