﻿using System;
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

            GameType();
            DisplayRules();
            
            while(player1.score < 2 && player2.score < 2)
            {
                string player1Gesture = player1.ChooseGesture();
                Console.WriteLine(player1 + "chose" + player1Gesture);

                string player2Gesture = player2.ChooseGesture();
                Console.WriteLine(player2 + "chose" + player2Gesture);

                DetermineRoundWinner(player1Gesture, player2Gesture);

            }
           
            DisplayWinner();

        }

        public void GameType()
        {
            Console.WriteLine("Do you have a friend to play with or would you like to play against the compooper? " +
            "Type 'human' for playing with another human or type 'compooper' to play against the computer.");
            string choice = Console.ReadLine();

            CreatePlayers(choice);
        }
        public void CreatePlayers(string choice)
        {
            if (choice == "human")
            {
                player1 = new Human();
                player2 = new Human();
            }
            else if (choice == "computer")
            {
                player1 = new Human();
                player2 = new Computer();
            }
        }

        private void DisplayRules()
        {
            Console.WriteLine("Rules for Rock Paper Scissors Lizard Spock: Player can choose between the five gestures of rock, paper, scissors, lizard, or Spock. Rock crushes scissors, scissors cuts paper, Paper covers Rockrock crushes lizard, lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper, paper disproves Spock, and Spock vaporizes rock. Best two out of three wins.");

        }

        private void DetermineRoundWinner(string player1Gesture, string player2Gesture)
        {
            if()
            {
                switch (player1Gesture)
                {
                    case "rock":
                        switch (player2Gesture)
                        {
                            case "lizard":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                            case "scissors":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                        }
                        break;
                    case "lizard":
                        switch (player2Gesture)
                        {
                            case "spock":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                            case "paper":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                        }
                        break;
                    case "spock":
                        switch (player2Gesture)
                        {
                            case "scissors":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                            case "rock":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                        }
                        break;
                    case "scissors":
                        switch (player2Gesture)
                        {
                            case "paper":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                            case "lizard":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                        }
                        break;
                    case "paper":
                        switch (player2Gesture)
                        {
                            case "rock":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                            case "spock":
                                player1.score++;
                                Console.WriteLine(player1 + " won this round.");
                                break;
                        }
                        break;

                } 
                else if ()
                {
                    switch (player1Gesture)
                    {
                        case "rock":
                            switch (player2Gesture)
                            {
                                case "rock":                                 
                                    Console.WriteLine("It's a tie!");
                                    break;
                            }
                            break;
                        case "lizard":
                            switch (player2Gesture)
                            {
                                case "lizard":
                                    Console.WriteLine("It's a tie!");
                                    break;
                            }
                            break;
                        case "spock":
                            switch (player2Gesture)
                            {
                                case "spock":
                                    Console.WriteLine("It's a tie!");
                                    break;
                            }
                            break;
                        case "scissors":
                            switch (player2Gesture)
                            {
                                case "scissors":
                                    Console.WriteLine("It's a tie!");
                                    break;
                            }
                            break;
                        case "paper":
                            switch (player2Gesture)
                            {
                                case "paper":
                                    Console.WriteLine("It's a tie!");
                                    break;
                            }
                            break;
                    }


                else()
                {
                        player2.score++;
                        Console.WriteLine(player2 + " won this round.");
                    }
            }
        }


        private void DisplayWinner()
        {
            //
        }

    }
}
