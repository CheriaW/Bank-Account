using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking : Account 
    {
        //fields(?)

        //properties
        public Checking()
        {

        }
        public Checking(double totalBalance, double withdrawFunds, double depositFunds, int accountNumber)
        {
            this.totalBalance = totalBalance;
            this.withdrawFunds = withdrawFunds;
            this.depositFunds = depositFunds;
            //this.accountNumber = accountNumber;
        }

        //methods will override
        public override double CheckCurrentBalance()
        {

            totalBalance += depositFunds;
            base.CheckCurrentBalance();
           // Console.WriteLine("Your current balance in account number " + accountNumber + " is " + TotalBalance + ".");
        }
    }
}
