using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMOtomasyonu
{
    public class BankUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }    
        public decimal Balance { get; set; }
        public string Password { get; set; }
        public bool IsPersonel { get; set; }
        public string Iban { get; set; }
    }
}
