﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

           

            Console.WriteLine("Welcome to the {0}. Can you tell me your name?", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring in today?");
            int bonk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}, would you like to join an game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "yeh")
            {
                Player player = new Player(playerName, bonk)
                {
                    ID = Guid.NewGuid()
                };
                using (StreamWriter file = new StreamWriter(@"C:\Users\lilyr\Logs\log.txt", true))
                {
                    file.WriteLine(player.ID);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.Read();
        }

    }
}
 