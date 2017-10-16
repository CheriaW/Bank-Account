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
        public string clientName;
        protected int accountNumber;
        protected double currentAmount;


        
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
        public double CurrentAmount
        {
            get { return this.currentAmount; }
            set { this.currentAmount = value; }
        }

        //constructors
        public Client()
        {

        }
        public Client(string clientName, int accountNumber, double currentAmount)
        {
            this.clientName = clientName;
            this.accountNumber = accountNumber;
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
