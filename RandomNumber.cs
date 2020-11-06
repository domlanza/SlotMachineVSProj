using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachineGame_Drafts_Lanza
{

    //Written by Rodney Drafts and Dominic Lanza
    //Class: RandomNumber
    //Class Description: This class generates a random number


    //Creates the Random Numbers to for the slots to process
    public class RandomNumber
    {
         private Random gen;
        
        //Default constructor that instantiates a new Random Number
        public RandomNumber() {
            gen = new Random();
        }

        //this method generates a non negative random number between 0 and 4
        public int pickRandom()
        {
            //hardcoded method from Random Class in FCL
            int num = gen.Next(4);
            return num;
        }
    }
}
