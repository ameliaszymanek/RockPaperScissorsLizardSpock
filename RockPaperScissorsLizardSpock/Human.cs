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
            Console.WriteLine("Choose your gesture");
            string gesture = Console.ReadLine();
            return gesture;
        }

        public override void ChooseName()
        {
            Console.WriteLine("Choose your name for the game");
            name = Console.ReadLine();
        }


    }
}
