namespace ATMOtomasyonu
{
    partial class FrmEft
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEnterDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmudDeposit = new System.Windows.Forms.NumericUpDown();
            this.txtbIban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmudDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "EFT";
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
            // btnEnterDeposit
            // 
            this.btnEnterDeposit.Location = new System.Drawing.Point(311, 262);
            this.btnEnterDeposit.Name = "btnEnterDeposit";
            this.btnEnterDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnEnterDeposit.TabIndex = 18;
            this.btnEnterDeposit.Text = "Enter";
            this.btnEnterDeposit.UseVisualStyleBackColor = true;
            this.btnEnterDeposit.Click += new System.EventHandler(this.btnEnterDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(514, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 58);
            this.label2.TabIndex = 17;
            this.label2.Text = "tl";
            // 
            // nmudDeposit
            // 
            this.nmudDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmudDeposit.Location = new System.Drawing.Point(236, 165);
            this.nmudDeposit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmudDeposit.Name = "nmudDeposit";
            this.nmudDeposit.Size = new System.Drawing.Size(272, 64);
            this.nmudDeposit.TabIndex = 16;
            // 
            // txtbIban
            // 
            this.txtbIban.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbIban.Location = new System.Drawing.Point(236, 117);
            this.txtbIban.Name = "txtbIban";
            this.txtbIban.Size = new System.Drawing.Size(272, 36);
            this.txtbIban.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Iban";
            // 
            // FrmEft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbIban);
            this.Controls.Add(this.btnEnterDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmudDeposit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "FrmEft";
            this.Text = "FrmEft";
            this.Load += new System.EventHandler(this.FrmEft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmudDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEnterDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmudDeposit;
        private System.Windows.Forms.TextBox txtbIban;
        private System.Windows.Forms.Label label3;
    }
}