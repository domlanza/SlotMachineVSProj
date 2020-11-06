using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachineGame_Drafts_Lanza
{

    //Written by Rodney Drafts and Dominic Lanza
    //Class: Slot 
    //Class Description: This class generates a random number associated to each slot
    //mostly built upon RandomNumber Class
    class Slot
    {
        //Instaniate random number generator
        private RandomNumber randomgen = new RandomNumber();
        //Create a num
        private int num;

        //Empty Constructor
        public Slot()
        {

        }

        //generates a random number for slot
        public int Spin()
        {
            num = randomgen.pickRandom();
            //MessageBox.Show(num.ToString());
            return num;
        }




       
    }
}
