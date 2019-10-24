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


        //member methods (CAN DO)
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose your gesture");
            gesture = Console.ReadLine();
        }

        public override void ChooseName()
        {
            Console.WriteLine("Choose your name for the game");
            name = Console.ReadLine();
        }


    }
}
