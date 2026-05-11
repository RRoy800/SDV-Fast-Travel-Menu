using System;
using Microsoft.Xna.Framework;
using Netcode;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.BellsAndWhistles;

namespace StardewValleyMod
{
    /// <summary>The mod entry point.</summary>
    internal sealed class ModEntry : Mod
    {
        /*********
         ** Public methods
         *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
        }


        /*********
         ** Private methods
         *********/
        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            // ignore if player hasn't loaded a save yet
            if (!Context.IsWorldReady)
                return;
            if (e.Button == SButton.U)
            {
                this.Monitor.Log($"{Game1.player.Name} pressed {e.Button}.", LogLevel.Debug);
                //this.Monitor.Log($"{Game1.locations.Count}", LogLevel.Debug);
                    foreach (var location in Game1.player.locqationsVisited)
                    {
                        this.Monitor.Log(location, LogLevel.Debug);
                    }
            }
            //else if () ; //figure out to teleport to something like the blacksmith specifically
        }
    }
}