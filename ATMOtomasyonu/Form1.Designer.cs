namespace ATMOtomasyonu
{
    partial class Form1
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.chbxPersonelMode = new System.Windows.Forms.CheckBox();
            this.cmbxNames = new System.Windows.Forms.ComboBox();
            this.lblCreditCardSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(132, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 29);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbPassword.Location = new System.Drawing.Point(297, 168);
            this.txtbPassword.MaxLength = 4;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(188, 36);
            this.txtbPassword.TabIndex = 1;
            this.txtbPassword.UseSystemPasswordChar = true;
            this.txtbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPassword_KeyPress);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(384, 261);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 53);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // chbxPersonelMode
            // 
            this.chbxPersonelMode.AutoSize = true;
            this.chbxPersonelMode.Location = new System.Drawing.Point(297, 142);
            this.chbxPersonelMode.Name = "chbxPersonelMode";
            this.chbxPersonelMode.Size = new System.Drawing.Size(118, 20);
            this.chbxPersonelMode.TabIndex = 3;
            this.chbxPersonelMode.Text = "PersonelMode";
            this.chbxPersonelMode.UseVisualStyleBackColor = true;
            // 
            // cmbxNames
            // 
            this.cmbxNames.FormattingEnabled = true;
            this.cmbxNames.Location = new System.Drawing.Point(615, 32);
            this.cmbxNames.Name = "cmbxNames";
            this.cmbxNames.Size = new System.Drawing.Size(121, 24);
            this.cmbxNames.TabIndex = 4;
            this.cmbxNames.SelectedIndexChanged += new System.EventHandler(this.cmbxNames_SelectedIndexChanged);
            // 
            // lblCreditCardSelect
            // 
            this.lblCreditCardSelect.AutoSize = true;
            this.lblCreditCardSelect.Location = new System.Drawing.Point(612, 9);
            this.lblCreditCardSelect.Name = "lblCreditCardSelect";
            this.lblCreditCardSelect.Size = new System.Drawing.Size(127, 16);
            this.lblCreditCardSelect.TabIndex = 5;
            this.lblCreditCardSelect.Text = "Select A Credit Card";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.lblCreditCardSelect);
            this.Controls.Add(this.cmbxNames);
            this.Controls.Add(this.chbxPersonelMode);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.CheckBox chbxPersonelMode;
        private System.Windows.Forms.ComboBox cmbxNames;
        private System.Windows.Forms.Label lblCreditCardSelect;
    }
}

