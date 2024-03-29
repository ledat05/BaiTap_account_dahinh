﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_account_dahinh
{
    class Account
    {
        private double balance;

        public Account()
        {
        }
        public Account(double balance)
        {
            this.balance = balance;
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return balance; }
        }
        public virtual bool RutTien(double amount)
        {
            return false;
        }
        public virtual bool NapTien(double amount)
        {
            return false;
        }
        public virtual void InHoaDon()
        {
        }
    }
    class SavingsAccount : Account
    {
        private double laisuat = 0.8;

        public SavingsAccount()
        {
        }
        public SavingsAccount(double balance, double laisuat) : base(balance)
        {
            this.laisuat = laisuat;
        }
        public double Laisuat
        {
            set { laisuat = value; }
            get { return laisuat; }
        }
        public override bool RutTien(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance = Balance - (amount + amount * laisuat);
                return true;
            }
            return false;
        }
        public override bool NapTien(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + (amount + amount * laisuat);
                return true;
            }
            return false;
        }
        public override void InHoaDon()
        {
            Console.WriteLine("So su cua ban {0}", Balance);
        }
    }
    class CheckingAccount : Account
    {
        public CheckingAccount()
        {
        }
        public CheckingAccount(double balance) : base(balance)
        {

        }
        public override bool RutTien(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public override bool NapTien(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }
        public override void InHoaDon()
        {
            Console.WriteLine("So du cua ban {0}", Balance);
        }

static void Main(string[] args)
        {
            Account ac1 = new SavingsAccount();
            ac1.NapTien(1000);
            ac1.RutTien(100);
            ac1.InHoaDon();
            // Creating checking account object
            Account ac2 = new CheckingAccount(5000);
            ac2.NapTien(1000);
            ac2.RutTien(3000);
            ac2.InHoaDon();

            Console.ReadLine();
        }
    }
    }
