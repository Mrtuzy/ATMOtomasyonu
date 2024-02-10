using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMOtomasyonu
{
    public partial class FrmAccountDetails : Form,IMainScreenObject
    {
        public event EventHandler OnBack;
        UserDal userDal = new UserDal();
        bool secretPassword = true;
        public FrmAccountDetails()
        {
            InitializeComponent();
        }

        private void FrmAccountDetails_Load(object sender, EventArgs e)
        {
            lblTitleUserName.Text = Form1.currentUser.UserName;
            lblBalanceInfo.Text = Form1.currentUser.Balance.ToString();
            lblPasswordInfo.Text = "****";
            lblIbanInfo.Text = Form1.currentUser.Iban;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke(this, EventArgs.Empty);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            List<BankUser> users = userDal.GetAll();
            foreach (BankUser user in users)
            {
                if (Form1.currentUser.UserName == user.UserName)
                {
                    // user şuan bizim current userımızla aynı
                    Form1.currentUser = user;
                    lblTitleUserName.Text = Form1.currentUser.UserName;
                    lblBalanceInfo.Text = Form1.currentUser.Balance.ToString();
                    lblPasswordInfo.Text = Form1.currentUser.Password;
                    lblIbanInfo.Text = Form1.currentUser.Iban;

                }

            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword changePassword = new FrmChangePassword();
            changePassword.ShowDialog();
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblIbanInfo.Text);
            MessageBox.Show("Your Iban copied!");
        }

        private void lblPasswordInfo_Click(object sender, EventArgs e)
        {
            
            if (secretPassword)
            {
                lblPasswordInfo.Text = Form1.currentUser.Password;
                secretPassword = false;
            }
            else
            {
                lblPasswordInfo.Text ="****";
                secretPassword = true;
            }
        }
    }
}
