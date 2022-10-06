using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like ot join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //create new player object, initialized with their name,
                //and how much money they braught.
                //takes in variables from user: playerName and bank
                Player player = new Player(playerName, bank);

                //creates new game, polymorphism is occuring
                //exposes overloaded operators
                Game game = new TwentyOneGame();
                game += player;
                //property of player
                //set to true, to create a while loop,
                //stating while player is actively playing, play the game.
                //since this isActivelyPlaying property is set true, it is constantly checked. Once false, exits while loop
                player.isActivelyPlaying = true;

                //player has to be actively playing as well,
                //players balance must be greater than 0 or else player can't play.
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                //subtracts player from game
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}
