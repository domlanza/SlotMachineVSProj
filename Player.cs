using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachineGame_Drafts_Lanza
{

    //Written by Rodney Drafts and Dominic Lanza
    //Class: Player
    //Class Description: this class is simply to create a player who plays the slot machine game
    //stores information such as their name, balanace, and spin


    public class Player
    {
        //attributes for player
        private string Name; 
        private int balance = 50; 
        private int Age;
        private int winnings;

        // Empty Parameterless Constructor
        public Player() {

        }

        //Constructor defining player's name
        public Player(string name,int age)
        {
            Name = name;
            Age = age;
        }
        //Get balance method
        public int getBalance()
        {
            return balance;
        }
        //Set balance method
        public void setBalance(int bal)
        {
            this.balance = bal;
        }
        //Get name method for Player
        public string getName()
        {
            return Name;
        }
        //Set player
        public void setPlayer(string name)
        {
            Name = name;
        }

        //Subtracts money from player money
        public void PlaceBet(int betPlaced) {
            balance = balance - betPlaced;
        }
        //Adds money to player's balance
        public void collectWinnings(int n) {
            balance += n;
            winnings += n;
        }

        public int getWin()
        {
            return winnings;
        }
  
    }
}
