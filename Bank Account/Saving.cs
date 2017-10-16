using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Saving : Account
    {
     
        //methods will override  
        public Saving()
        {

        }   
        public Saving(double SavingBalance, string AccountType, int AccountNumber)
        {
            this.checkingBalance = SavingBalance;
            this.accountType = AccountType;
            this.accountNumber = AccountNumber;
        }
        //dont forget the withdraw and deposit
        public virtual void SDepositFunds()
        {

        }
        public virtual double SWithdrawFunds()
        {
            if (TotalBalance < 5)
            {
                Console.WriteLine("You've tried to withdraw too much money. There is a minium \nbalance of $5 that must be kept in your savings account.");
                return 0.00d;
            }
            else
            {
                double withdrawFunds = double.Parse(Console.ReadLine());
                SavingBalance -= withdrawFunds;
                return SavingBalance;
            }
        }
        public double SavingBalance
        {
            get { return this.savingBalance; }
            set { this.savingBalance = value; }
        }
        //public override double DepositFunds() //why redlines, why?!

        public override void Exit()
        {
            throw new NotImplementedException(); //what is this? it auto filled and it works. im not touching it....
        }
    }
}
