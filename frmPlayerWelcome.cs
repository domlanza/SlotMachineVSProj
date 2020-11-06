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
    public partial class frmPlayerWelcome : Form
    {
        public frmPlayerWelcome()
        {
            InitializeComponent();
        }


        private void btnReady_Click(object sender, EventArgs e)
        {
            int age = 0;
            try
            {
                if (String.IsNullOrEmpty(txtName.Text))
                {
                    System.Windows.Forms.MessageBox.Show("Name Cannot be Blank. Renter");
                }
                if (String.IsNullOrEmpty(txtDate.Text))
                {
                    System.Windows.Forms.MessageBox.Show("Date Of Birth cannot be Blank. Renter");
                }
                if (String.IsNullOrEmpty(txtBalance.Text))
                {
                    System.Windows.Forms.MessageBox.Show("Balance cannot be blank. Renter");
                }
                if (txtBalance.Text.Length > 0)
                {
                    int balance = Convert.ToInt32(txtBalance.Text);
                }
                if (txtDate.Text.Length != 8)
                {
                    System.Windows.Forms.MessageBox.Show("Date of Birth must be entered in format above");
                }
                else
                {
                    int currentTime = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                    int dob = int.Parse(txtDate.Text);
                    age = (currentTime - dob) / 10000;
                }
                if (age < 21)
                {
                    System.Windows.Forms.MessageBox.Show("The authoritites have been contacted they are coming to arrest you. YOU MUST BE 21 OR OLDER TO PLAYER");
                    txtDate.Clear();
                    return;
                }
                else
                {
                    btnPlay.Visible = true;
                    GlobalData.player = new Player(txtName.Text,age);
                    MessageBox.Show("Welcome " + GlobalData.player.getName() + " your starting"
                        +"balance is $ " + GlobalData.player.getBalance().ToString());
                    GlobalData.SlotMachine = new SlotMachine();

                }
            }
            catch
            {

            }
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            Form f2 = new frmSlotMachineGame();
            f2.Show();
            Hide();
        }
    }
   }
