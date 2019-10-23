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
            //DisplayRules();
            //player1Move, player2Move DetermineRoundWinner();
            //DisplayWinner();

        }

        private void DetermineWhoIsPlaying();
        {
        //
        }


        private void DisplayRules();
        {
        //
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
