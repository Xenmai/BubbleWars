using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;
using FreneticGameCore;
using FreneticGameGraphics.ClientSystem;
using FreneticGameGraphics.ClientSystem.EntitySystem;

namespace BubbleWars.MainGame
{
    /*
     * Hey! Read the information in GameProgram.cs
     * 
     * (2D game reference not fully complete!)
     * 
     * First steps to take:
     * 
     * - Load in any assets you may have available.
     * 
     * - Get the world you want here to start appearing, then add ways to control it!
    */

    /// <summary>
    /// The game starting point.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The game client window.
        /// </summary>
        public GameClientWindow Window;

        /// <summary>
        /// The primary game engine.
        /// </summary>
        public GameEngine3D Engine;

        /// <summary>
        /// Runs the game.
        /// </summary>
        public void Run()
        {
            // Create a window, 2D mode by default.
            Window = new GameClientWindow(threed: false);
            // Add an event for when the window is set up but not loaded yet.
            Window.OnWindowSetUp += WindowSetup;
            // Add an event to listen for when the window loads.
            Window.OnWindowLoad += WindowLoad;
            // Start the client systems.
            Window.Start();
        }

        /// <summary>
        /// Fires when the window is set up but not loaded.
        /// </summary>
        public void WindowSetup()
        {
            // Grab the engine reference.
            Engine = Window.Engine3D;
            // Configure any other options core here...
        }

        /// <summary>
        /// Fires when the window loads.
        /// </summary>
        public void WindowLoad()
        {
            // Track the escape key press for quick-closing.
            Window.Window.KeyDown += Window_KeyDown;
            // TODO: Sample 2D objects.
            // Spawn or configure additional objects here...
        }

        /// <summary>
        /// Handles escape key pressing to exit.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event data.</param>
        private void Window_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            // If the key pressed is Escape
            if (e.Key == Key.Escape)
            {
                // Close the main engine window! This will cause the entire game to shut down!
                Window.Window.Close();
            }
        }
    }
}
