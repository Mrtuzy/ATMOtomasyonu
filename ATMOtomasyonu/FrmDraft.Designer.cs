namespace ATMOtomasyonu
{
    partial class FrmDraft
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
            this.btnEnterDraft = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmudDraft = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmudDraft)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "draft";
            // 
            // btnEnterDraft
            // 
            this.btnEnterDraft.Location = new System.Drawing.Point(311, 262);
            this.btnEnterDraft.Name = "btnEnterDraft";
            this.btnEnterDraft.Size = new System.Drawing.Size(75, 23);
            this.btnEnterDraft.TabIndex = 15;
            this.btnEnterDraft.Text = "Enter";
            this.btnEnterDraft.UseVisualStyleBackColor = true;
            this.btnEnterDraft.Click += new System.EventHandler(this.btnEnterDraft_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(514, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 58);
            this.label2.TabIndex = 14;
            this.label2.Text = "tl";
            // 
            // nmudDraft
            // 
            this.nmudDraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmudDraft.Location = new System.Drawing.Point(236, 165);
            this.nmudDraft.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmudDraft.Name = "nmudDraft";
            this.nmudDraft.Size = new System.Drawing.Size(272, 64);
            this.nmudDraft.TabIndex = 13;
            // 
            // FrmDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnterDraft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmudDraft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmDraft";
            this.Text = "FrmDraft";
            this.Load += new System.EventHandler(this.FrmDraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmudDraft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnterDraft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmudDraft;
    }
}