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
    public partial class FrmDraft : Form,IMainScreenObject
    {
        public event EventHandler OnBack;
        UserDal userDal = new UserDal();
        public FrmDraft()
        {
            InitializeComponent();
        }

        private void FrmDraft_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke(this, EventArgs.Empty);
        }

        private void btnEnterDraft_Click(object sender, EventArgs e)
        {
            BankUser user = Form1.currentUser;
            decimal balanceDiffrence = -Convert.ToDecimal(nmudDraft.Value);
            
            userDal.UpdateBalance(user, balanceDiffrence);
            List<BankUser> users = userDal.GetAll();
            foreach (BankUser bankUser in users)
            {
                if (Form1.currentUser.UserName == bankUser.UserName)
                {
                    // user şuan bizim current userımızla aynı
                    Form1.currentUser = bankUser;

                }

            }
            nmudDraft.Value = 0;
            MessageBox.Show($"Your procces succed.You draft {-balanceDiffrence} lira.");
        }
    }
}
