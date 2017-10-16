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
        // one extra field for the minimum acccount balance and the corresponding property
        protected int minBalance;

        public int MinBalance 
            //why cant i do a get set here?
            //I was trying to use parenthesis smh... check the details!
        {
            get { return this.minBalance; }
            set { this.minBalance = value; }
        }


        //methods will override  
        public Saving()
        {

        }   
        public Saving(double totalBalance, string accountType, int accountNumber)
        {
            this.totalBalance = totalBalance;
            this.accountType = accountType;
            this.accountNumber = accountNumber;
        }
        //dont forget the withdraw and deposit
        public override double WithdrawFunds()
        {
            if (totalBalance < 5)
            {
                Console.WriteLine("You've tried to withdraw too much money. There is a minium \nbalance of $5 that must be kept in your savings account.");
                return 0.00d;
            }
            else
            {
                double withdrawFunds = double.Parse(Console.ReadLine());
                totalBalance -= withdrawFunds;
                return withdrawFunds;
            }
        }
        //public override double DepositFunds() //why redlines, why?!

    public override void Exit()
        {
            throw new NotImplementedException(); //what is this? it auto filled and it works. im not touching it....
        }
    }
}
