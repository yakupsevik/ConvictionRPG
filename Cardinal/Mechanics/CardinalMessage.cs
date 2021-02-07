using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvictionRPG
{
    class CardinalMessage
    {
        public static string newLine = "\n";

        public static void Greeting()
        {

            // Greeting for player

            System.Console.WriteLine("Welcome to Conviction!");

            System.Console.ReadKey();

            System.Console.WriteLine(newLine);

            System.Console.WriteLine("Are you ready to play Conviction? Get your hype pants on...");

            System.Console.WriteLine(newLine);

            System.Console.ReadKey();

            System.Console.WriteLine("Press any key to begin the play.");

            System.Console.ReadKey();

        }

        public void welcomeMessage()
        {
            var nameArr = new[]
          {@"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                   ,---.,---.,   ..    ,|,---.--.--|,---.,   .                    ",
             @"                   |    |   ||\  ||    |||      |  ||   ||\  |                    ",
             @"                   |    |   || \ | \  / ||      |  ||   || \ |                    ",
             @"                   `---'`---'`  `'  `'  ``---'  `  ``---'`  `'                    ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"           Press any key to begin the best two minutes of your life.              ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
            };

            //  System.Console.WindowWidth = 160;

            System.Console.WriteLine(newLine);

            foreach (string line in nameArr)
            {
                System.Console.WriteLine(line);
            }

            System.Console.ReadKey();

            Greeting();

            System.Console.ReadKey();

        }

        public void quitMessage()
        {

            var nameArr = new[]
           {@"                                                                                   ",
             @"                                                                                  ",
             @"             ,---.,---.,   ..    ,|,---.--.--|,---.,   .                          ",
             @"             |    |   ||\  ||    |||      |  ||   ||\  |                          ",
             @"             |    |   || \ | \  / ||      |  ||   || \ |                          ",
             @"             `---'`---'`  `'  `'  ``---'  `  ``---'`  `'                          ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"			  See ya! :3														     ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
            };

            //  System.Console.WindowWidth = 160;

            System.Console.WriteLine(newLine);

            foreach (string line in nameArr)
            {
                System.Console.WriteLine(line);
            }

            System.Threading.Thread.Sleep(2000);

            System.Environment.Exit(0);

        }

        public void exitMessage()
        {

            var nameArr = new[]
           {@"                                                                                   ",
             @"                                                                                  ",
             @"             ,---.,---.,   ..    ,|,---.--.--|,---.,   .                          ",
             @"             |    |   ||\  ||    |||      |  ||   ||\  |                          ",
             @"             |    |   || \ | \  / ||      |  ||   || \ |                          ",
             @"             `---'`---'`  `'  `'  ``---'  `  ``---'`  `'                          ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"			 Menu														             ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
            };

            //  System.Console.WindowWidth = 160;

            System.Console.WriteLine(newLine);

            foreach (string line in nameArr)
            {
                System.Console.WriteLine(line);
            }

            System.Threading.Thread.Sleep(2000);

            System.Environment.Exit(0);

        }

        public void MainMenu_Border()
        {
            var nameArr = new[]
          {@"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                   ,---.,---.,   ..    ,|,---.--.--|,---.,   .                    ",
             @"                   |    |   ||\  ||    |||      |  ||   ||\  |                    ",
             @"                   |    |   || \ | \  / ||      |  ||   || \ |                    ",
             @"                   `---'`---'`  `'  `'  ``---'  `  ``---'`  `'                    ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"           Press any key to begin the best two minutes of your life.              ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
            };

            //  System.Console.WindowWidth = 160;

            System.Console.WriteLine(newLine);

            foreach (string line in nameArr)
            {
                System.Console.WriteLine(line);
            }

            System.Console.ReadKey();
        }
    }
}
