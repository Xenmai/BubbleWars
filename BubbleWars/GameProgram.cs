using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using FreneticGameCore;
using BubbleWars.MainGame;

namespace BubbleWars
{
    /*
     * HEY! You've created a new game project using Frenetic Game Engine! Congratulations!
     * 
     * 
     * See starting tips in MainGame/Game.cs!
     * 
     * 
     * Some recommendations and tips for you in general:
     * 
     * - Adjust the AssemblyInfo.cs file (in the Properties folder).
     * 
     * - Make sure everything in the project is up-to-date (Such as the .NET version).
     * 
     * - Set up a git repo for the project
     * 
     * - Replace the FreneticGame{Core|Graphics} and related references with a git submodule
     * of the engine via GitHub, and keep add them as local projects to the solution.
     * 
     * - READ ANY ALL (OFFICIAL) DOCUMENTATION ON THE ENGINE THAT YOU CAN FIND.
     * Documentation is a magical thing!
     * 
     * - If you get lost, check the Contact info on https://freneticllc.com (Open in an actual browser!)
     * It will among other things lead you to an open channel for discussion and help-getting
     * alongside private contact information for security-critical bugs!
     * 
     * - There is at least one legal file in the project (which is clearly labeled, both in name and content),
     * Keep that file safe and untouched.
     * 
     * - Duplicate the data folder (in bin/Debug) to bin/Release and switch configuration to Release in
     * your code editor to enable better run speeds.
     * Be prepared, however, to switch back to debug to deal with error messages!
     * 
     * - Have fun, and good luck!
    */

    /// <summary>
    /// Main entry point for the game program.
    /// </summary>
    public class GameProgram : Program
    {
        /// <summary>
        /// The name of the game.
        /// </summary>
        public const string MyGameName = "BubbleWars";

        /// <summary>
        /// The version of the game. Automatically read from file.
        /// </summary>
        public static readonly string MyGameVersion = Assembly.GetCallingAssembly().GetName().Version.ToString();

        /// <summary>
        /// The description of the game version.
        /// </summary>
        public const string MyGameVersionDescription = "Pre-Alpha";

        /// <summary>
        /// Constructs the Game Program.
        /// </summary>
        public GameProgram()
            : base(MyGameName, MyGameVersion, MyGameVersionDescription)
        {
        }

        /// <summary>
        /// Main entry point for the game program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {
            // Set up the program.
            PreInit(new GameProgram());
            // Set up the system console.
            SysConsole.Init();
            // Construct and run the game itself.
            new Game().Run();
        }
    }
}
