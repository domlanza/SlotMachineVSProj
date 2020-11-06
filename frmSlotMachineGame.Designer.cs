namespace SlotMachineGame_Drafts_Lanza
{
    partial class frmSlotMachineGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlotMachineGame));
            this.lblWinnings = new System.Windows.Forms.Label();
            this.txtWinnings = new System.Windows.Forms.TextBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnPayout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.Location = new System.Drawing.Point(300, 388);
            this.lblWinnings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(82, 20);
            this.lblWinnings.TabIndex = 3;
            this.lblWinnings.Text = "Winnings";
            // 
            // txtWinnings
            // 
            this.txtWinnings.Location = new System.Drawing.Point(402, 390);
            this.txtWinnings.Margin = new System.Windows.Forms.Padding(2);
            this.txtWinnings.Multiline = true;
            this.txtWinnings.Name = "txtWinnings";
            this.txtWinnings.ReadOnly = true;
            this.txtWinnings.Size = new System.Drawing.Size(75, 20);
            this.txtWinnings.TabIndex = 5;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(61, 388);
            this.lblBet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(37, 20);
            this.lblBet.TabIndex = 7;
            this.lblBet.Text = "Bet";
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(107, 388);
            this.txtBet.Margin = new System.Windows.Forms.Padding(2);
            this.txtBet.Multiline = true;
            this.txtBet.Name = "txtBet";
            this.txtBet.ReadOnly = true;
            this.txtBet.Size = new System.Drawing.Size(75, 22);
            this.txtBet.TabIndex = 10;
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSpin.Enabled = false;
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(288, 426);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(110, 36);
            this.btnSpin.TabIndex = 12;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnPayout
            // 
            this.btnPayout.Enabled = false;
            this.btnPayout.Location = new System.Drawing.Point(593, 430);
            this.btnPayout.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(106, 29);
            this.btnPayout.TabIndex = 15;
            this.btnPayout.Text = "Pay Out";
            this.btnPayout.UseVisualStyleBackColor = true;
            this.btnPayout.Click += new System.EventHandler(this.btnPayout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(723, 68);
            this.label4.TabIndex = 16;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBet.Location = new System.Drawing.Point(11, 426);
            this.btnBet.Margin = new System.Windows.Forms.Padding(2);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(100, 29);
            this.btnBet.TabIndex = 19;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirm.Location = new System.Drawing.Point(138, 426);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(98, 29);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm Bet";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(421, 426);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 36);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(593, 85);
            this.txt3.Margin = new System.Windows.Forms.Padding(2);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(75, 35);
            this.txt3.TabIndex = 25;
            this.txt3.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(386, 96);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(75, 35);
            this.txt2.TabIndex = 26;
            this.txt2.Visible = false;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(161, 96);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(75, 35);
            this.txt1.TabIndex = 27;
            this.txt1.Visible = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::SlotMachineGame_Drafts_Lanza.Properties.Resources.three;
            this.pb1.InitialImage = global::SlotMachineGame_Drafts_Lanza.Properties.Resources.three;
            this.pb1.Location = new System.Drawing.Point(138, 168);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(108, 83);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 22;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::SlotMachineGame_Drafts_Lanza.Properties.Resources.three;
            this.pb2.InitialImage = global::SlotMachineGame_Drafts_Lanza.Properties.Resources.three;
            this.pb2.Location = new System.Drawing.Point(369, 168);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(108, 83);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 28;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::SlotMachineGame_Drafts_Lanza.Properties.Resources.three;
            this.pb3.InitialImage = null;
            this.pb3.Location = new System.Drawing.Point(593, 168);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(108, 83);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 29;
            this.pb3.TabStop = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(741, 388);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(75, 22);
            this.txtBalance.TabIndex = 31;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(644, 390);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(74, 20);
            this.lblBalance.TabIndex = 30;
            this.lblBalance.Text = "Balance";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(748, 430);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 29);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSlotMachineGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlotMachineGame_Drafts_Lanza.Properties.Resources.slots;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 466);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPayout);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.txtWinnings);
            this.Controls.Add(this.lblWinnings);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSlotMachineGame";
            this.Text = "Slot#101";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWinnings;
        private System.Windows.Forms.TextBox txtWinnings;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnPayout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnExit;
    }
}