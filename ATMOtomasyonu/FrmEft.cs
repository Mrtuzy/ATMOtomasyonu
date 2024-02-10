using ATMOtomasyonu;
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
    public partial class FrmEft : Form,IMainScreenObject
    {
        public event EventHandler OnBack;
        UserDal userDal = new UserDal();
        public FrmEft()
        {
            InitializeComponent();
        }

        private void FrmEft_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke(this, EventArgs.Empty);
        }

        private void btnEnterDeposit_Click(object sender, EventArgs e)
        {
            List<BankUser> users = userDal.GetAll();

            foreach (BankUser targetUser in users) 
            {
                if (targetUser.Iban == txtbIban.Text)
                {
                    // ıbanı bizim yazdığımız iban olan user
                    decimal balanceDiffrence = Convert.ToDecimal(nmudDeposit.Value);
                    userDal.UpdateBalance(targetUser,balanceDiffrence);
                    userDal.UpdateBalance(Form1.currentUser,-balanceDiffrence);
                    users = userDal.GetAll();
                    nmudDeposit.Value = 0;
                    MessageBox.Show($"Your procces succed.You EFt {balanceDiffrence} lira to {targetUser.UserName}.");
                }

            }
            foreach (BankUser bankUser in users)
            {
                if (Form1.currentUser.UserName == bankUser.UserName)
                {
                    // user şuan bizim current userımızla aynı
                    Form1.currentUser = bankUser;

                }

            }
        }
    }
}
