namespace ATMOtomasyonu
{
    partial class FrmDeposit
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmudDeposit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnterDeposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmudDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "Deposit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nmudDeposit
            // 
            this.nmudDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmudDeposit.Location = new System.Drawing.Point(223, 162);
            this.nmudDeposit.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmudDeposit.Name = "nmudDeposit";
            this.nmudDeposit.Size = new System.Drawing.Size(272, 64);
            this.nmudDeposit.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(501, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 58);
            this.label2.TabIndex = 11;
            this.label2.Text = "tl";
            // 
            // btnEnterDeposit
            // 
            this.btnEnterDeposit.Location = new System.Drawing.Point(298, 259);
            this.btnEnterDeposit.Name = "btnEnterDeposit";
            this.btnEnterDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnEnterDeposit.TabIndex = 12;
            this.btnEnterDeposit.Text = "Enter";
            this.btnEnterDeposit.UseVisualStyleBackColor = true;
            this.btnEnterDeposit.Click += new System.EventHandler(this.btnEnterDeposit_Click);
            // 
            // FrmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnterDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmudDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmDeposit";
            this.Text = "FrmDeposit";
            this.Load += new System.EventHandler(this.FrmDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmudDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmudDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnterDeposit;
    }
}