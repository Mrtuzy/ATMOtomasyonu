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
    public partial class FrmMainScreen : Form
    {
        public event EventHandler OnAccesDetail;
        public event EventHandler OnEft;
        public event EventHandler OnDeposit;
        public event EventHandler OnDraft;
        public event EventHandler OnMainMenu;

        public FrmMainScreen()
        {
            InitializeComponent();
        }

        private void FrmMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnAccountDetails_Click(object sender, EventArgs e)
        {
            OnAccesDetail(this,EventArgs.Empty);
        }

        private void btnEft_Click(object sender, EventArgs e)
        {
            OnEft?.Invoke(this,EventArgs.Empty);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            OnMainMenu?.Invoke(this,EventArgs.Empty);
        }

        private void btnDraft_Click(object sender, EventArgs e)
        {
            OnDraft?.Invoke(this,EventArgs.Empty);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            OnDeposit?.Invoke(this,EventArgs.Empty);
        }
    }
}
