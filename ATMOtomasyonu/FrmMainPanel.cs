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
    public partial class FrmMainPanel : Form
    {

       
        public FrmMainPanel()
        {
            InitializeComponent();
        }
        
        private void frmMainPanel_Load(object sender, EventArgs e)
        {
            //Panel ilk Yüklendiğinde
            LoadForm1();
            
        }

      
        //Form1 İşlemleri
        private void Form1_OnPersonelModeEnable(object sender, EventArgs e)
        {
            //Personel modu tiki basılıyken şifreyle giriş yapınca
            AccsesScreen screen = new AccsesScreen();
            screen.OnBack += Form1_OnMainMenu;
            LoadForm(screen);
        }

       

        private void Form1_OnPasswordCorrect(object sender, EventArgs e)
        {
            //personel modu tiki kapalıyken şifreyle giriş yapınca
                LoadFrmMainScreen();
            
        }
        private void Form1_OnMainMenu(object sender, EventArgs e)
        {
            // MainScreendeki Main Menuye basılınca ve Accses ekranında geriye basılınca
            LoadForm1();
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //MainScreen İşlemleri

        private void MainScreen_OnEft(object sender, EventArgs e)
        {
            // MainScreendeki Eftye basınca
            FrmEft frmEft = new FrmEft();
            frmEft.OnBack += MainScreen_OnBack;
            LoadForm(frmEft);
        }

        private void MainScreen_OnAccesDetail(object sender, EventArgs e)
        {
            //Mainscreendeki AccsesDetaile basınca
           FrmAccountDetails accountDetails = new FrmAccountDetails();
            accountDetails.OnBack += MainScreen_OnBack;
            LoadForm(accountDetails);
        }
        private void MainScreen_OnDraft(object sender, EventArgs e)
        {
            FrmDraft frmDraft = new FrmDraft();
            frmDraft.OnBack += MainScreen_OnBack;
            LoadForm(frmDraft);
        }

        private void MainScreen_OnDeposit(object sender, EventArgs e)
        {
            FrmDeposit frmDeposit = new FrmDeposit();
            frmDeposit.OnBack += MainScreen_OnBack;
            LoadForm(frmDeposit);
        }
        private void MainScreen_OnBack(object sender, EventArgs e)
        {
            // MainScreendeki pencerelerden herhangi birinin içindeki Back tuşuna basınca
            LoadFrmMainScreen();
        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        private void FrmMainPanel_KeyDown(object sender, KeyEventArgs e)
        {
            
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Form Load İşlemleri
        private void LoadForm(Form form)
        {

            pnlMain.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(form);
            form.Show();
        }
        private void LoadForm1()
        {
            Form1 form1 = new Form1();

            form1.OnPasswordCorrect += Form1_OnPasswordCorrect;
            form1.OnPersonelModeEnable += Form1_OnPersonelModeEnable;

            LoadForm(form1);
        }
        private void LoadFrmMainScreen()
        {
            FrmMainScreen mainScreen = new FrmMainScreen();
            mainScreen.OnAccesDetail += MainScreen_OnAccesDetail;
            mainScreen.OnEft += MainScreen_OnEft;
            mainScreen.OnMainMenu += Form1_OnMainMenu;
            mainScreen.OnDeposit += MainScreen_OnDeposit;
            mainScreen.OnDraft += MainScreen_OnDraft;
            LoadForm(mainScreen);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
