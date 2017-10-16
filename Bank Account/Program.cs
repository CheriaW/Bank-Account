using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Suzy = new Client("Suzy Carmichael ", 191914, 250000000.00d);

            Checking checking = new Checking(50000000, "Checkings", 191915);

            Saving saving = new Saving(1000000, "Savings", 191916);


            Console.WriteLine("Welcome to White National Bank! How can we assist you?");
            string entryCommand;
            //string uCaseEntryCommand;

            do
            {
                Console.WriteLine("1. View Client Information\n2. View Account Balance\n3. Deposit Funds\n4. Withdraw Funds\n5. Exit\n");
                entryCommand = Console.ReadLine();
                //1. View Client Info
                if (entryCommand == "1")
                {
                    Console.WriteLine(Suzy.LogIn());
                }
                //2. View account balance... choose a or b....
                //careful of which "ba;ance" you're using...
                else if (entryCommand == "2")
                {
                    Console.WriteLine("A. View Balance in Checking...\nB. View Balance in Saving.\nEnter A or B.");
                    string checkBalance = Console.ReadLine().ToUpper();

                    if (checkBalance == "A")
                    {
                        Console.WriteLine("Your balance is " + checking.TotalBalance + ".");
                    }
                    else if (checkBalance == "B")
                    {
                        Console.WriteLine("Your balance is " + saving.TotalBalance + ".");
                    }

                }

                //3. Deposit funds
                else if (entryCommand == "3")
                {
                    Console.WriteLine("A. Depost funds into checking account....\n B. Deposit funds into savings account.... Enter A or B.");
                    string depositAccount = Console.ReadLine().ToLower();

                    if (depositAccount == "A")
                    {
                        checking.DepositFunds();
                        Console.WriteLine("Current balance for your savings account is " + checking.CheckingBalance + "dollars.");
                    }
                    else if (depositAccount == "B")
                    {
                        saving.DepositFunds();
                        Console.WriteLine("Current balance for your checking account is " + saving.SavingBalance + "dollars.");
                    }
                }

                //4. Withdraw funds
                else if (entryCommand == "4")
                {
                    Console.WriteLine("A. Withdraw funds from checking account....\n B. Withdraw funds from savings account.");
                    string withdrawAccount = Console.ReadLine().ToLower();

                    if (withdrawAccount == "A")
                    {
                        checking.WithdrawFunds();
                        Console.WriteLine("Available balance for your checking account is " + checking.CheckingBalance);
                    }
                    else if (withdrawAccount == "B")
                    {
                        saving.WithdrawFunds();
                        Console.WriteLine("Available balance for your savings account is " + saving.SavingBalance);
                    }
                }

                //Exiting... this part is hard :/
                //wait no... remember this is still in a huge if-else statement!
                else
                {
                    if (entryCommand == "Exit")
                    {
                        saving.Exit();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Back out of program and try again.");
                    }
                }
               
            }
            while (entryCommand != "Exit");

        }
    }
}
