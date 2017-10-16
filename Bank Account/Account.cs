using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Account
    {
        //abstract? whats that do?

        //fields       
        protected double totalBalance;
        protected double checkingBalance;
        protected double savingBalance;
        protected string accountType;
        protected int accountNumber;
        protected string clientName;


        //properties
        
        public double TotalBalance
        {
            get { return this.totalBalance; }
            set { this.totalBalance = value; }
        }
        public double CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }
        public double SavingBalance
        {
            get { return this.savingBalance; }
            set { this.savingBalance = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            // set { this.accountType = value; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            //set?
            set { this.accountNumber = value; }
        }
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }
        //constructors(?)methods(?)
        public Account()
        {

        }
        //methods....?
        public Account(string accountType, double totalBalance)
        {
            this.totalBalance = totalBalance;
            this.accountType = accountType;
        }

        public virtual double WithdrawFunds()
        {
            double withdrawFunds = double.Parse(Console.ReadLine());
            totalBalance -= withdrawFunds;
            return withdrawFunds;
        }
        public virtual double DepositFunds()
        {
            double depositFunds = double.Parse(Console.ReadLine());
            totalBalance += depositFunds;
            return depositFunds;
        }
        public virtual string CurrentBalance()
        {
            return "Account Balance: " + totalBalance;
        }

        public virtual void Exit()
        {

        }
        //figure out how to let the user "exit
        //WHY CANT I EXIT?! IM TRAPPED!

    }
}
