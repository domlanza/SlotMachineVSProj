using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2(string qs)
        {
            InitializeComponent();
            //Take balance input and put it in form 2
            txtBalance.Text = qs;
            txtGame1.Visible = true;
            txtGame2.Visible = true;
            txtGame3.Visible = true;
            txtGame1.Enabled = true;
            txtGame2.Enabled = true;
            txtGame3.Enabled = true;


        }

        //declaring each item
        public static int p1;
        public static int p2;
        public static int p3;

        int currentbalance;
        //Click event when user clicks on button 1 to put into bet Text box
        private void btnBet1_Click(object sender, EventArgs e)
        {
            //Convert to a string
            currentbalance = Int32.Parse(txtBalance.Text);
            //if balance is greater than or equal to 1 allow for button to pressed
            if (currentbalance >= 1)
            {
                txtBet.Text = "1";
            }
            else {
                MessageBox.Show("Error Insufficient Funds You Cannot Play Anymore");
                //END GAME
            }
        }

        private void btnBet5_Click(object sender, EventArgs e)
        {
            //Convert to a string
            int currentbalance = Int32.Parse(txtBalance.Text);
            //if balance is greater than or equal to 1 allow for button to pressed
            if (currentbalance >= 5)
            {
                txtBet.Text = "5";
            }
            else
            {
                MessageBox.Show("Error Insufficient Funds Select A Lower Bet");
            }
        }

        private void btnBet10_Click(object sender, EventArgs e)
        {
            //Convert to a string
            int currentbalance = Int32.Parse(txtBalance.Text);
            //if balance is greater than or equal to 1 allow for button to pressed
            if (currentbalance >= 10)
            {
                txtBet.Text = "10";
            }
            else
            {
                MessageBox.Show("Error Select a Lower Bet");
            }
        }

          private void btnSpin_Click(object sender, EventArgs e)
        {
            //check is balance is higher than the bet
            //  if (balance >= bet)
            // {
            //balance = balance - bet;
            //lblbalance.Text = balance.toString();
            //}
            p1 = RandomNumber.Random(1, 4);
            p2 = RandomNumber.Random(1, 4);
            p3 = RandomNumber.Random(1, 4);


            //If image is there place in picture box
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = Image.FromFile(p1.ToString() + ".png");

            if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
            pictureBox2.Image = Image.FromFile(p2.ToString() + ".png");

            if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
            pictureBox3.Image = Image.FromFile(p3.ToString() + ".png");

            //set countofWin
            //count = 0;
            //results add to balance
            //add balance
            if (p1 == 3) currentbalance = currentbalance + 5;
            if (p1 == 2 && p2 == 2) currentbalance = currentbalance + 10;
            if (p1 == 3 && p2 == 3) currentbalance = currentbalance + 10;
            if (p1 == 1 && p2 == 1 && p3 == 1) currentbalance = currentbalance + 20;
            if (p1 == 2 && p2 == 2 && p3 == 2) currentbalance = currentbalance + 30;
            if (p1 == 3 && p2 == 3 && p3 == 3) currentbalance = currentbalance + 50;
            lblBalance.Text = currentbalance.ToString();

            txtGame1.Text = p1.ToString();
            txtGame2.Text = p2.ToString();
            txtGame3.Text = p3.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile("1.png");
            Image image2 = Image.FromFile("2.png");
            Image image3 = Image.FromFile("3.png");

            pictureBox1.Image = image;
            pictureBox2.Image = image2;
            pictureBox3.Image = image3;
        }
    }
}
