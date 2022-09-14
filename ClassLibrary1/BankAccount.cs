using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BankAccount
    {
        public int referenceID { get; set; }
        public float balance { get; set; }

        public BankAccount(float balance)
        { 
            this.balance = balance;
            this.referenceID = Math.getRand(100000000, 900000000);
        }

    }
}
