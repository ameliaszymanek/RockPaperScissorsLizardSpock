using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        //member variables (HAS A)
        private Random randomGesture;
        public string name;
        private List<string> computerName;


        //constructor (BUILD)
        public Computer()
        {
            ChooseName();
            randomGesture = new Random();
            computerName = new List<string>() { "Joyce", "Maria", "Christine", "Lucia", "Renee" };
        }
        

    //member methods (CAN DO)
    public override string ChooseGesture()
        {
            int randomNumber = randomGesture.Next(0, gestures.Count);
                string generatedGesture = gestures[randomNumber];
                return generatedGesture;
        }

        public override void ChooseName()
        {
            int nameGenerator = randomGesture.Next(0, computerName.Count);
            name = computerName[nameGenerator];
            

        }

    }
}
