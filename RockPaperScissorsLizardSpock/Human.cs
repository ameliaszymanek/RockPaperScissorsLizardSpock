using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {

        //member variables (HAS A)


        //constructor (BUILD)
        public Human()
        {
            ChooseName();
        }

        //member methods (CAN DO)
        public override string ChooseGesture()
        {
            Console.WriteLine(name + " choose your gesture");
            string gesture = Console.ReadLine().ToLower();
            foreach (string choice in gestures)
            {
                if (gesture == choice)
                {
                    break;
                }
                else if (choice == gestures[gestures.Count - 1])
                {
                    Console.WriteLine("ERROR: Must enter valid gesture.");
                    return ChooseGesture();
                }
            }
            return gesture;
        }

        public override void ChooseName()
        {
            Console.WriteLine("Choose your name for the game");
            name = Console.ReadLine();
        }


    }
}
