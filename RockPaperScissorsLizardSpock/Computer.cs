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
        private Generate randomName;
        private List<string> computerName;
       

        //constructor (BUILD)
        public Computer()
        {
            randomGesture = new Random();
            randomName = new Generate();
            computerName = new List<string>() { "Joyce", "Maria", "Christine", "Lucia", "Renee" };
        }
        

    //member methods (CAN DO)
    public override string ChooseGesture()
        {
            int randomNumber = randomGesture.Next(0, gestures.Count);
                string generatedGesture = gestures[randomNumber];
                return generatedGesture;
        }

        public override string ChooseName()
        {
            int nameGenerator = randomName.Next(0, computerName.Count);
                string generatedName = computerName[nameGenerator];
                return generatedName;
        }

    }
}
