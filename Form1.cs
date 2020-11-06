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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBalance.Enabled = false;
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
                    Application.Exit();

                }
                else {
                    btnPlay.Visible = true;
                }
            }
            catch {

            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form slotmachine = new Form2(txtBalance.Text);

            slotmachine.Show();
        }
    }
}
