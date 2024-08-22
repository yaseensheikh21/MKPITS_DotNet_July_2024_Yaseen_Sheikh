using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oops_1_bank_account
{
    class BankAccount
    {
        string Name;
        string AccountNumber;
        string TypeofAccount;
        decimal Balance;
        public void AssignValues(string Name, string AccountNumber, string TypeofAccount, decimal Balance)
        {
            this.Name = Name;   
            this.AccountNumber = AccountNumber;
            this.TypeofAccount = TypeofAccount;
            this.Balance = Balance;
        }
        public void deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("balance amount is:" + Balance);
            }
            else
            {
                Console.WriteLine("insucfficent bank Balacne");
            }
        }
        public void withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("available amount is:" + Balance);
            }
            else
            {
                Console.WriteLine("insucfficent bank Balance");
            }
        }
        public void Display()
        {
            Console.WriteLine("Account holder Name :" +  Name);
            Console.WriteLine("Account holder Balance :" + Balance);
        }
        internal class program
        {
            static void Main(string[] args)
            {
                BankAccount accountdetails = new BankAccount();
                accountdetails.AssignValues("yaseen", "471857241", "Saving", 2000);
                accountdetails.Display();
                accountdetails.deposit(800);
                accountdetails.withdraw(1000);
                accountdetails.Display();
                Console.Read();
            }
        }
    }
}
