using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variable (HAS A)
        private Player player1;
        private Player player2;




        //constructor (BUILDER)
        //public Game()
        //{
        //    player1 = new Player();
        //    player2 = new Player();
        //}



        //member method (CAN DO)
        public void RunGame()
        {

            GameType();
            DisplayRules();
            //player1Move, player2Move DetermineRoundWinner();
            //DisplayWinner();

        }

        public string GameType()
        {
            Console.WriteLine("Do you have a friend to play with or would you like to play against the compooper? " +
            "Type 'human' for playing with another human or type 'compooper' to play against the computer.");
            string choice = Console.ReadLine();
            return choice;
        }
        public void CreatePlayers(string numberPlayers)
        {
            if (numberPlayers = "human")
            {
                player1 = new Human();
                player2 = new Human();
            }
            else if (numberPlayers = "computer")
            {
                player1 = new Human();
                player2 = new Computer();
            }
        }

            switch (choice)
            {
                case "human":
                    Console.WriteLine("Enjoy your two player game. May the best human win!");
                    break;
                case "computer":
                    Console.WriteLine("Enjoy your game. May you be smarter than the computer.");
                    break;
                default:
                    Console.WriteLine("Choose either 'human' or 'computer'.");
                    break;
            }
            return choice;
        }


        private void DisplayRules()
        {
            Console.WriteLine("Rules for Rock Paper Scissors Lizard Spock: Player can choose between the five gestures of rock, paper, scissors, lizard, or Spock. Rock crushes scissors, scissors cuts paper, Paper covers Rockrock crushes lizard, lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper, paper disproves Spock, and Spock vaporizes rock. Best two out of three wins.");

        }

        private void DetermineRoundWinner()
        {
            //player1Move, player2Move
        }

        private void DisplayWinner()
        {
            //
        }

    }
}
