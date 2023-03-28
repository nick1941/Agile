using System;

using static System.Console;

namespace BowlingGame
{
    class Program
    {
        static void Main ()
        {
            SetupConsole ();

            Game game = new Game();

            game.Add (5);
            game.Add (4);
            game.Add (4);
            game.Add (5);
            game.Add (6);
            game.Add (4);
            game.Add (5);
            game.Add (5);
            game.Add (10);
            game.Add (6);
            game.Add (1);
            game.Add (7);
            game.Add (3);
            game.Add (6);
            game.Add (4);
            game.Add (10);
            game.Add (2);
            game.Add (8);
            game.Add (6);

            WriteLine ("Frame  1, throw 1:  5");
            WriteLine ("Frame  1, throw 2:  4");
            WriteLine ("Frame  2, throw 1:  4");
            WriteLine ("Frame  2, throw 2:  5");
            WriteLine ("Frame  3, throw 1:  6");
            WriteLine ("Frame  3, throw 2:  4");
            WriteLine ("Frame  4, throw 1:  5");
            WriteLine ("Frame  4, throw 2:  5");
            WriteLine ("Frame  5, throw 1: 10");
            WriteLine ("Frame  6, throw 1:  6");
            WriteLine ("Frame  6, throw 2:  1");
            WriteLine ("Frame  7, throw 1:  7");
            WriteLine ("Frame  7, throw 2:  3");
            WriteLine ("Frame  8, throw 1:  6");
            WriteLine ("Frame  8, throw 2:  4");
            WriteLine ("Frame  9, throw 1: 10");
            WriteLine ("Frame 10, throw 1:  2");
            WriteLine ("Frame 10, throw 2:  8");
            WriteLine ("Frame 10, throw 3:  6");

            WriteLine ($"Final Score: {game.Score}");

            _ = ReadKey ();
        }

        // Initialize the console's coloring and height.
        private static void SetupConsole ()
        {
            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.White;
            WindowHeight = 50;

            Clear ();

        } // method SetupConsole

    }
}
