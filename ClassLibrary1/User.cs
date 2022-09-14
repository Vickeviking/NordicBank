using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        //fields
        List<Transaction> transactions = new List<Transaction>();
        List<BankAccount> bankAccounts = new List<BankAccount>(); 
        public string socialNumber { get; }
        public string Password { get; set;}
        public string phoneNumber { get; set; }

        public User(string socialnumber, string password, string phonenumber)
        { 
            this.socialNumber = socialnumber;
            this.Password = password;
            this.phoneNumber = phonenumber;
        }

        //transactions
        public void makeTransaction(Transaction transaktion)
        { 
            transactions.Add(transaktion);
        }

        public void removeTransaktion(Transaction transaction)
        {
            transactions.Remove(transaction);
        }

        //bankaccount

        public void AddBankAccount(BankAccount Account)
        { 
            bankAccounts.Add(Account);
        }

        public void removeBankAccount(BankAccount account)
        { 
            bankAccounts.Remove(account);
        }

        //change password

        public void changePassword(string password)
        {
            if (ErrorChecks.checkStringConditions(password, true, 16, 6, false))
            {
                this.Password = password;
            }
        }

        public void changePhoneNumber(string phonenumber_)
        {
            if (ErrorChecks.checkNumber(phonenumber_))
            {
                this.phoneNumber = phonenumber_;
            }
        }


    }
}
