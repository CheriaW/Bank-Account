using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Account
    {
        //abstract?
        //fields

        protected double totalBalance;
        protected string accountType;

        //properties
        public string AccountType
        {
            get { return this.accountType; }
            // set { this.accountType = value; }
        }
        public double TotalBalance
        {
            get { return this.totalBalance; }
            set { this.totalBalance = value; }
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


    }
}
