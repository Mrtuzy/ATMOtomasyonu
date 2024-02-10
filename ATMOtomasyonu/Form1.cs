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
    public partial class Form1 : Form
    {
        public event EventHandler OnPasswordCorrect;
        public event EventHandler OnPersonelModeEnable;

        UserDal userDal = new UserDal();
        public static BankUser currentUser;
        List<BankUser> users;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
           
            //default password şifrenin kırılması imkansız çünkü max 4 sayı girilebilor ama default şifre 10 sayılı.
            string password = "0000000000";
            foreach (BankUser user in users)
            {
                if (user.UserName == cmbxNames.Text)
                {
                    // comboboxtan seçtiğimiz userı kaydediyoruz ve onun şifresini alıyoruz
                    currentUser = user;
                    password = user.Password;
                    
                }
                
            }
            //şifre kontrol
            if (txtbPassword.Text == password)
            {
                if (chbxPersonelMode.Checked == true)
                {
                    OnPersonelModeEnable?.Invoke(this, new EventArgs());
                }
                else
                {
                    OnPasswordCorrect?.Invoke(this, new EventArgs());
                }
                
            }
            else 
            {
                MessageBox.Show("Wrong Password!");
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            chbxPersonelMode.Enabled = false;
            //comboboxa userları ekleme
             users =  userDal.GetAll();
            foreach (BankUser user in users)
            {
                cmbxNames.Items.Add(user.UserName);
             
            }
            
            
        }

        private void txtbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxa sadece sayı girilmesi için
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (BankUser user in users)
            {
               if (cmbxNames.Text == user.UserName )
                {
                    //şuan user comboboxta seçilen user 
                    if(user.IsPersonel)
                    {
                        chbxPersonelMode.Enabled = true;
                    }
                    else
                    {
                        chbxPersonelMode.Enabled = false;
                    }
                }
             

            }
        }
    }
}
