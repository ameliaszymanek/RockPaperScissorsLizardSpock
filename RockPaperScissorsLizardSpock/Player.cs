using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player
    {
        //member variables (HAS A)
        public int score;
        public List<string> gestures;

        //constructor (BUILD)
        public Player()
        {
            score = 0;
            gestures = new List<string>() {"rock", "paper", "scissors", "lizard", "Spock" };
        }
        
        //member methods (CAN DO)
        public string ChooseGesture()
        {
            //
        }


    }
}
