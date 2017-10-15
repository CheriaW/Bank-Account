using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Saving : Account
    {
        //private
        //methods will override
       
        public Saving(double totalBalance, double withdrawFunds, double depositFunds, int accountNumber)
        {
            this.totalBalance = totalBalance;
            this.withdrawFunds = withdrawFunds;
            this.depositFunds = depositFunds;
            this.accountNumber = accountNumber;
        }
        public override double CheckCurrentBalance()
        {

            totalBalance += depositFunds;
            //base.CurrentBalance();
            Console.WriteLine("Your current balance in account number " + accountNumber + " is " + TotalBalance + ".");
        }
    }
}
