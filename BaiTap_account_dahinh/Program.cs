using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_account_dahinh
{
    class account
    {
        protected double balance;

        public account() : base()
        { }
        public account(double balance)
        {
            this.balance = balance;
        }
        public virtual bool Withdraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        public virtual void PrintBalace()
        { }  
    }
    class SavingAcount : account
    {
        private double interesRate = 0.8;

        public SavingAcount()
        {

        }
        public SavingAcount(double interesRate, double balance):base(balance)
        {
            this.interesRate = interesRate;
        }
        public override bool Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance += balance - (amount + amount * interesRate);
                return true;
            }
            return false;
        }
        public override bool Deposit(double amount)
        {
            if (amount < balance)
            {
                balance = balance + (amount + amount * interesRate);
                return true;
            }
            return false;
        }
        public override void PrintBalace()
        {
            Console.WriteLine("Xuat so du{0}", balance);
        }
        
    }
    class CheckingAccount:account
    {
        private double interesRate;
        public CheckingAccount()
        { }
        public CheckingAccount(double interesRate,double balance):base(balance)
        {
            this.interesRate = interesRate;
        }
        public override bool Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= balance - (amount + amount * interesRate);
                return true;
            }
            return false;
        }
        public override bool Deposit(double amount)
        {
            if (amount < balance)
            {
                balance = balance + (amount + amount * interesRate);
                return true;
            }
            return false;
        }
        public override void PrintBalace()
        {
            Console.WriteLine("Xuat so du {0}", balance);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            account tk1 = new account();
            tk1.Withdraw(100);
            tk1.PrintBalace();
            tk1.Deposit(1000);
            account tk2 = new account();
            tk2.Withdraw(200);
            tk2.PrintBalace();
            tk2.Deposit(1888);
            Console.ReadLine();
        }
    }
    }
