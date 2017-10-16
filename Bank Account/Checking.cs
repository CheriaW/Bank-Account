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
        //nope-- using fields from the base class Account!

        //properties
        //no

        //default constructor
        public Checking()
        {

        }
        public Checking(double totalBalance, string accountType, int accountNumber)
        {
            this.totalBalance = totalBalance;
            this.accountType = accountType;
            this.accountNumber = accountNumber;
        }

        //methods will override
        //do I need the code below?
        //no. run program first then come back and delete
        public override double DepositFunds()
        {
            double depositFunds = double.Parse(Console.ReadLine());
            totalBalance += depositFunds;
            return depositFunds;
            // Console.WriteLine("Your current balance in account number " + accountNumber + " is " + TotalBalance + ".");
        }
        public override void Exit()
        {
           // Console.WriteLine("User: " + clientName + "has chosen to exit the program... HAVE A GREAT DAY!");
        }
    }
}
