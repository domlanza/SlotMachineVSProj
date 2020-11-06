using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachineGame_Drafts_Lanza

{
    //new
    public partial class frmSlotMachineGame : Form
    {
        public frmSlotMachineGame()
        {
            InitializeComponent();
            txtBalance.Text = "50";
            txtWinnings.Text = "0";
        }
        
        //ImageList created for visual display within game
        ImageList pics = new ImageList();
        //Timer shuffles images using Tick event to simulate spin appearence
        Timer t = new Timer();




        //Click event when user clicks on bet
        int clickCounter = 0;
        private void btnBet_Click(object sender, EventArgs e)
        {

            if (clickCounter == 0)
            {
                int bet = 1;
                txtBet.Text = bet.ToString();
                clickCounter++;
            }
            else if (clickCounter == 1)
            {
                int bet = 5;
                txtBet.Text = bet.ToString();
                clickCounter++;
            }
            else if (clickCounter == 2)
            {
                int bet = 10;
                txtBet.Text = bet.ToString();
                clickCounter = 0;
            }
            btnConfirm.Enabled = true;

        }
        //click event that checks certain conditions of the game  before continuing game
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            int balplay = GlobalData.player.getBalance();
            int balslot = GlobalData.SlotMachine.getBalance();
            int bet = Int32.Parse(txtBet.Text);

            //checks to see if bet can be covered
            if (bet > balplay || bet > balslot)
            {
                MessageBox.Show("not enough to cover bet");
                return;
            }
            //checks to see if bet placed
            if (txtBet.Text == "0" || txtBet.Text == "") //makes sure proper bet placed before and after a turn
            {
                MessageBox.Show("please enter a bet");
                return;
            }
            //checks to see if either player or slotmachine has money
            if(balplay == 0)
            {
                MessageBox.Show("Your out of money,Goodbye");
                return;
            }
            if (balslot == 0)
            {
                MessageBox.Show("We are out of money,Goodbye");
                return;

            }

                MessageBox.Show("ok,good to go");
                int Spinbalance = balplay - bet;
                txtBalance.Text = Spinbalance.ToString();
                btnSpin.Enabled = true;
                GlobalData.SlotMachine.changeBet(bet);
                btnBet.Enabled = false;
                btnConfirm.Enabled = false;

        }

        //Spins the wheels in the game with help from the timer and calls spinslots method
        //Most slotmachines already know the outcome of the wheels before the player stops them
        private void btnSpin_Click(object sender, EventArgs e)
        {

            t.Interval = 50;
            t.Start();
            t.Tick += T_Tick;
            btnStop.Enabled = true;
            GlobalData.SlotMachine.SpinSlots();
            btnConfirm.Enabled = false;
            btnStop.Enabled = true;

        }
        //randomly displays images within image list
        private void T_Tick(object sender, EventArgs e)
        {
            pb1.Image = pics.getRanImage();
            pb2.Image = pics.getRanImage();
            pb3.Image = pics.getRanImage();
        }

        
   
        //stops the wheels in the slotmachine/stops timer
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnSpin.Enabled = false;
            btnStop.Enabled = false;
            btnPayout.Enabled = true;
            t.Stop();
            //random numbers already stored into SlotMachine slotstops attribute
            int[] stops = GlobalData.SlotMachine.getStop();

            int x = stops[0];
            int y = stops[1];
            int z = stops[2];


            txt1.Text = x.ToString();
            txt2.Text = y.ToString();
            txt3.Text = z.ToString();
            this.SuspendLayout();
            pb1.Image = pics.getImage(x);
            pb2.Image = pics.getImage(y);
            pb3.Image = pics.getImage(z);
            this.ResumeLayout();

            //checks table for possible win
            int num = GlobalData.SlotMachine.chkTable(stops);

            //holds bet as int
            int bet = Convert.ToInt32(txtBet.Text);

            int win = Convert.ToInt32(txtWinnings.Text);

            //no win, collect bet
            if (num == 0)
            {
                GlobalData.SlotMachine.collectBet(bet);
                txtBet.Text = "0";
                btnBet.Enabled = true;
                btnConfirm.Enabled = true;
                btnStop.Enabled = false;

                int balplay = GlobalData.player.getBalance();
                //MessageBox.Show("player bal = " + balplay.ToString());
                int newbalance = balplay - bet;
                GlobalData.player.setBalance(newbalance); 
                //MessageBox.Show("new bal = " + GlobalData.player.getBalance().ToString());
                txtBalance.Text = GlobalData.player.getBalance().ToString();

            }//jackpot
            if (num == 777)
            {
                txtBet.Text = "0";
                MessageBox.Show("Jackpot", "Congrats!!!!");
                txtWinnings.Text = GlobalData.SlotMachine.getBalance().ToString();
                GlobalData.SlotMachine.setBalance(0);
                btnBet.Enabled = false;
                btnConfirm.Enabled = false;
                btnSpin.Enabled = false;
                btnStop.Enabled = false;

            }//table val
                txtBet.Text = "0";
                win += num;
                txtWinnings.Text = win.ToString();
                btnBet.Enabled = true;
                btnConfirm.Enabled = true;
                btnStop.Enabled = false;

        }


        //adds winnings to players balance if win occured
        private void btnPayout_Click(object sender, EventArgs e)
        {
            int winnings = Int32.Parse(txtWinnings.Text);
            if (winnings == 0)
            {
                MessageBox.Show("you have no winnings to payout");
                return;
            }

            int balplay = GlobalData.player.getBalance();
            txtWinnings.Text = "0";
            GlobalData.player.collectWinnings(winnings);
            txtBalance.Text = GlobalData.player.getBalance().ToString();

        }

        //exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


