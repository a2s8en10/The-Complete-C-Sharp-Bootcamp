using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Injection
{
    public interface IAccount
    {
        void Showdetail();
    }

    class SavingAccount : IAccount
    {
        public void Showdetail()
        {
            Console.WriteLine("Saving Account .......");
        }
    }
    class CurrentAccount : IAccount
    {
        public void Showdetail()
        {
            Console.WriteLine("Current Account .......");
        }
    }
    class Account
    {
        private IAccount account;

        public Account(IAccount Account)
        {
            this.account = Account;
        }

        public void Showaccount()
        {
            account.Showdetail();
        }
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount sa = new SavingAccount();
            Account a1 = new Account(sa);
            a1.Showaccount();

            IAccount ca = new CurrentAccount();
            Account a2 = new Account(ca);
            a2.Showaccount();

            Console.ReadLine();

        }
    }
}
