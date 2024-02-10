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
    public partial class FrmDeposit : Form,IMainScreenObject
    {
        public event EventHandler OnBack;
        UserDal userDal = new UserDal();
        public FrmDeposit()
        {
            InitializeComponent();
        }

        

        private void FrmDeposit_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke(this, EventArgs.Empty);
        }

        private void btnEnterDeposit_Click(object sender, EventArgs e)
        {
            BankUser user = Form1.currentUser;
            decimal balanceDiffrence = Convert.ToDecimal(nmudDeposit.Value);
            
            userDal.UpdateBalance(user,balanceDiffrence);
            //userın bilgisi güncellendi ama current userımız eski bilgili halini tutyor bu yüzden databaseden yenilenmiş halini çekiyoruz.
            List<BankUser> users = userDal.GetAll();
            foreach (BankUser bankUser in users)
            {
                if (Form1.currentUser.UserName == bankUser.UserName)
                {
                    // user şuan bizim current userımızla aynı
                    Form1.currentUser = bankUser;

                }

            }
            nmudDeposit.Value = 0;
            MessageBox.Show($"Your procces succed.You deposit {balanceDiffrence} lira into your bank account.");
        }
    }
}
