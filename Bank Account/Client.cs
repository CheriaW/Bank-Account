using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Client
    {
        //fields
        protected string clientName;
        protected int accountNumber;
        protected string accountType;
        protected double currentAmount;
       // protected string accountType;


        
        //properties(3)
        public string ClientName
        {
            get { return this.clientName; }
            //set { this.clientName = value; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            //set { this.accountNumber = value; }
        }
        public string AccountSelection
        {
            get { return this.accountType; }
            //set { this.accountSelection = value; }
        }
        public double CurrentAmount
        {
            get { return this.currentAmount; }
            set { this.currentAmount = value; }
        }

        //constructors
        public Client()
        {

        }
        public Client(string clientName, int accountNumber, string accountType, double currentAmount)
        {
            this.clientName = clientName;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.currentAmount = currentAmount;
        }

        //methods
        public virtual string LogIn()
        {
            return "Name: " + clientName + "Account Number: " + accountNumber;
            //Console.WriteLine("Now accessing account information from " + accountSelection + ".") ;
        }
    }
}
