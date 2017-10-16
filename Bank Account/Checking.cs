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
        public double CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }

        //default constructor
        public Checking()
        {

        }
        public Checking(double checkingBalance, string AccountType, int AccountNumber)
        {
            this.checkingBalance = checkingBalance;
            this.accountType = AccountType;
            this.accountNumber = AccountNumber;
        }

        //methods will override
        public override void DepositFunds()
        {
            double depositFunds = double.Parse(Console.ReadLine());
            checkingBalance += depositFunds;
           // return checkingBalance;
        }
        public override double WithdrawFunds()
        {
            double withdrawFunds = double.Parse(Console.ReadLine());
            checkingBalance -= withdrawFunds;
            return checkingBalance;
        }
        public override void Exit()
        {
           // Console.WriteLine("User: " + clientName + "has chosen to exit the program... HAVE A GREAT DAY!");
        }
    }
}
