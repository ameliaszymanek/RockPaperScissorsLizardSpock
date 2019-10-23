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
        public Game()
        {
            player1 = new Player();
            player2 = new Player();
        }



        //member method (CAN DO)
        public void RunGame()
        {

            //DetermineWhoIsPlaying();
            DisplayRules();
            //player1Move, player2Move DetermineRoundWinner();
            //DisplayWinner();

        }

        private void GameType();
        {
            Console.WriteLine("Do you have a friend to play with or would you like to play against the compooper? Type 'human' for playing with another human or type 'compooper' to play against the computer.");
            string GameTypeChoice = Console.ReadLine();
            
            switch(Game Type Choice)
            {
                case "human":
                    break;
                case "computer":
                    break;
                //do I need a default option?
            }

        }


        private void DisplayRules();
        {
            Console.WriteLine("Rules for Rock Paper Scissors Lizard Spock: Player can choose between the five gestures of rock, paper, scissors, lizard, or Spock. Rock crushes scissors, scissors cuts paper, Paper covers Rockrock crushes lizard, lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper, paper disproves Spock, and Spock vaporizes rock. Best two out of three wins.");

        }

        private void DetermineRoundWinner();
        {
        //player1Move, player2Move
        }

        private void DisplayWinner()
        { 
        //
        }
    
}
