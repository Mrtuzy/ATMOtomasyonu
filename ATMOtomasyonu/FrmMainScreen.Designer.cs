namespace ATMOtomasyonu
{
    partial class FrmMainScreen
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
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnEft = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnAccountDetails = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDraft
            // 
            this.btnDraft.Location = new System.Drawing.Point(21, 38);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(149, 88);
            this.btnDraft.TabIndex = 1;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = true;
            this.btnDraft.Click += new System.EventHandler(this.btnDraft_Click);
            // 
            // btnEft
            // 
            this.btnEft.Location = new System.Drawing.Point(639, 38);
            this.btnEft.Name = "btnEft";
            this.btnEft.Size = new System.Drawing.Size(149, 88);
            this.btnEft.TabIndex = 2;
            this.btnEft.Text = "Eft";
            this.btnEft.UseVisualStyleBackColor = true;
            this.btnEft.Click += new System.EventHandler(this.btnEft_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(21, 181);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(149, 88);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnAccountDetails
            // 
            this.btnAccountDetails.Location = new System.Drawing.Point(639, 181);
            this.btnAccountDetails.Name = "btnAccountDetails";
            this.btnAccountDetails.Size = new System.Drawing.Size(149, 88);
            this.btnAccountDetails.TabIndex = 4;
            this.btnAccountDetails.Text = "AccountDetails";
            this.btnAccountDetails.UseVisualStyleBackColor = true;
            this.btnAccountDetails.Click += new System.EventHandler(this.btnAccountDetails_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(324, 393);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(86, 23);
            this.btnMainMenu.TabIndex = 5;
            this.btnMainMenu.Text = "MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAccountDetails);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnEft);
            this.Controls.Add(this.btnDraft);
            this.Name = "FrmMainScreen";
            this.Text = "frmMainScreen";
            this.Load += new System.EventHandler(this.FrmMainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.Button btnEft;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnAccountDetails;
        private System.Windows.Forms.Button btnMainMenu;
    }
}