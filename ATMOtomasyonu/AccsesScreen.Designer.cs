namespace ATMOtomasyonu
{
    partial class AccsesScreen
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
            this.dgvBankUsers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbBalance = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblbPassword = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.chbIsPersonel = new System.Windows.Forms.CheckBox();
            this.lblIban = new System.Windows.Forms.Label();
            this.txtbIban = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBankUsers
            // 
            this.dgvBankUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBankUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvBankUsers.Name = "dgvBankUsers";
            this.dgvBankUsers.RowHeadersWidth = 51;
            this.dgvBankUsers.RowTemplate.Height = 24;
            this.dgvBankUsers.Size = new System.Drawing.Size(800, 264);
            this.dgvBankUsers.TabIndex = 0;
            this.dgvBankUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBankUsers_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(404, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(57, 292);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(116, 292);
            this.txtbName.MaxLength = 50;
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(161, 22);
            this.txtbName.TabIndex = 3;
            // 
            // txtbBalance
            // 
            this.txtbBalance.Location = new System.Drawing.Point(116, 341);
            this.txtbBalance.Name = "txtbBalance";
            this.txtbBalance.Size = new System.Drawing.Size(161, 22);
            this.txtbBalance.TabIndex = 4;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(116, 390);
            this.txtbPassword.MaxLength = 4;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(161, 22);
            this.txtbPassword.TabIndex = 5;
            this.txtbPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBalance.Location = new System.Drawing.Point(40, 341);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(70, 20);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Balance";
            // 
            // lblbPassword
            // 
            this.lblbPassword.AutoSize = true;
            this.lblbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbPassword.Location = new System.Drawing.Point(28, 392);
            this.lblbPassword.Name = "lblbPassword";
            this.lblbPassword.Size = new System.Drawing.Size(83, 20);
            this.lblbPassword.TabIndex = 7;
            this.lblbPassword.Text = "Password";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 55);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(404, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(215, 55);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chbIsPersonel
            // 
            this.chbIsPersonel.AutoSize = true;
            this.chbIsPersonel.Location = new System.Drawing.Point(293, 294);
            this.chbIsPersonel.Name = "chbIsPersonel";
            this.chbIsPersonel.Size = new System.Drawing.Size(93, 20);
            this.chbIsPersonel.TabIndex = 11;
            this.chbIsPersonel.Text = "IsPersonel";
            this.chbIsPersonel.UseVisualStyleBackColor = true;
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIban.Location = new System.Drawing.Point(70, 420);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(40, 20);
            this.lblIban.TabIndex = 13;
            this.lblIban.Text = "Iban";
            // 
            // txtbIban
            // 
            this.txtbIban.Location = new System.Drawing.Point(116, 418);
            this.txtbIban.MaxLength = 26;
            this.txtbIban.Name = "txtbIban";
            this.txtbIban.Size = new System.Drawing.Size(161, 22);
            this.txtbIban.TabIndex = 12;
            // 
            // AccsesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIban);
            this.Controls.Add(this.txtbIban);
            this.Controls.Add(this.chbIsPersonel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblbPassword);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbBalance);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBankUsers);
            this.Name = "AccsesScreen";
            this.Text = "AccsesScreen";
            this.Load += new System.EventHandler(this.AccsesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBankUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbBalance;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblbPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chbIsPersonel;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.TextBox txtbIban;
    }
}