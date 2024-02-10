using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMOtomasyonu
{
    public partial class AccsesScreen : Form
    {
        public event EventHandler OnBack;
        public AccsesScreen()
        {
            InitializeComponent();
        }
        UserDal userDal = new UserDal();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadUsers()
        {
            dgvBankUsers.DataSource = userDal.GetAll();
        }
        private void AccsesScreen_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BankUser user = new BankUser();

            user.UserName = txtbName.Text.ToLower();
            user.Balance = Convert.ToDecimal(txtbBalance.Text);
            user.Password = txtbPassword.Text;
            user.IsPersonel = chbIsPersonel.Checked;
            user.Iban = txtbIban.Text;
            if (user.UserName != null && user.Password != null)
            {
                userDal.Add(user);
            }
            LoadUsers();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BankUser user = new BankUser();
            
            user.UserName = txtbName.Text.ToLower();
            user.Balance = Convert.ToDecimal(txtbBalance.Text);
            user.Password = txtbPassword.Text;
            user.IsPersonel = chbIsPersonel.Checked;
            user.Iban = txtbIban.Text;
            user.Id = Convert.ToInt32(dgvBankUsers.CurrentRow.Cells[0].Value);
            userDal.Update(user);
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BankUser user = new BankUser();
            user.Id = Convert.ToInt32(dgvBankUsers.CurrentRow.Cells[0].Value);
            userDal.Delete(user);
            LoadUsers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke(this, EventArgs.Empty);
        }

        private void dgvBankUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbName.Text = dgvBankUsers.CurrentRow.Cells[1].Value.ToString();
            txtbBalance.Text = dgvBankUsers.CurrentRow.Cells[2].Value.ToString();
            txtbPassword.Text = dgvBankUsers.CurrentRow.Cells[3].Value.ToString();
            txtbIban.Text = dgvBankUsers.CurrentRow.Cells[5].Value.ToString();
            chbIsPersonel.Checked = Convert.ToBoolean(dgvBankUsers.CurrentRow.Cells[4].Value);
        }
    }
}
