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
    //Class: SlotMachine 
    //Class Description: This class handles the game controls of the SLOT MACHINE GAME
    public class SlotMachine
    {
        //attributes
        private int bank = 10000000;
        private int moneyCollected = 0;
        private int Betplaced = 1;
        //Creates the slot class object and allows the slotmachine to generate random number for each wheel
        private Slot s1 = new Slot();
        //holds the random numbers returned from slot
        private int[] slotstops = new int[3];
        //Create the table class object and allows slotmachine direct access to it for looking up winning combonations
        private Table table = new Table();
       
        
        //Empty constructor
       public SlotMachine()
        {

        }

        //spin each slot for random number in each wheel
        public void SpinSlots()
        {
            int start = 0;
            int end = 3;
            
            while(start < end)
            {
                slotstops[start] = s1.Spin();
                start++;
            }
            

        }

        //returns array of random numbers generated and stored in slotmachine slotstops attribute
        public int[] getStop()
        {
            return slotstops;
        }


        ////checks table class against values returned from slot class/slotstop attribute
        public int chkTable(int[] combo) {
            
            
            int num = table.isWinner(combo);

            return num;
        }

        ////collects bet if loss occurs
        public void collectBet(int x) {

            moneyCollected += x;
            
        }

        ////pays player value stored in jackpot refererce if win occurs
        public int getJackpot() {

            int pay = bank;
            bank = 0;

            return pay;
        }
        //get balance
        public int getBalance()
        {
            return bank;
        }

        //get bet placed
        public int getBetPlaced()
        {
            return Betplaced;
        }
        //change the bet
        public void changeBet(int x)
        {
            Betplaced = x;
            
        }
        //set the balance
        public void setBalance(int x)
        {
            bank = x;

        }



    }
}
