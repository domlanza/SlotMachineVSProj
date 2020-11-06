using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachineGame_Drafts_Lanza
{
    //Written by Rodney Drafts and Dominic Lanza
    //Class: Global Data
    //Class Description: This class instaniates both forms in the Slot Machine and the player,
    //slotmachine itself, and the imagelist
    public class GlobalData
    {
        public static Player player;
        public static SlotMachine SlotMachine;
        public static ImageList ImageList;


        public static Form PlayerWelcome = new frmPlayerWelcome();
        public static Form SlotMachineGame = new frmSlotMachineGame();

    }
}
