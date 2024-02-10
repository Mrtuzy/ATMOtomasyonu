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
    public partial class FrmChangePassword : Form
    {
        UserDal userDal = new UserDal();
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtbOldPassword.Text == Form1.currentUser.Password)
            {
                if (txtbNewPassword.Text != null)
                {
                    if (txtbOldPassword == txtbNewPassword)
                    {
                        MessageBox.Show("your new password cannot be the same as the old one!");
                    }
                    else
                    {
                        userDal.UpdatePassword(Form1.currentUser, txtbNewPassword.Text);
                        MessageBox.Show("Your password is changed!");
                        this.Close();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Please set new password");
                }
            }
            else
            {
                MessageBox.Show("Your procces decline. Your wrote wrong old password!");
            }
        }
    }
}
