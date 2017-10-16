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

            Checking checking = new Checking(500000, "Checkings", 191915);

            Saving saving = new Saving(10000, "Savings", 191916);


            Console.WriteLine("Welcome to White National Bank! How can we assist you?");
            string entryCommand;
           

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
                //careful of which "balance" you're using...
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

                //3. Deposit funds... user input??
                else if (entryCommand == "3")
                {
                    Console.WriteLine("A. Depost funds into checking account....\nB. Deposit funds into savings account.... Enter A or B.");
                    string depositAccount = Console.ReadLine().ToUpper();
                  //  double depositAmount = double.Parse(Console.ReadLine());
                   // double checkingBalance;

                    if (depositAccount == "A")
                    {
                        Console.WriteLine("Enter the amount you would like to deposit.");
                        double depositAmount = double.Parse(Console.ReadLine());
                        checking.DepositFunds();
                        checking.CurrentBalance();
                        Console.WriteLine("Current balance for your checking account is " + checking.CheckingBalance + " dollars.");                      
                    }
                    else if (depositAccount == "B")
                    {
                        Console.WriteLine("Enter the amount you would like to deposit.");
                        double depositAmount = double.Parse(Console.ReadLine());
                        saving.SDepositFunds();
                        saving.CurrentBalance();
                        Console.WriteLine("Current balance for your saving account is " + saving.SavingBalance + " dollars.");                      
                    }
                }

                //4. Withdraw funds
                else if (entryCommand == "4")
                {
                    Console.WriteLine("A. Withdraw funds from checking account....\nB. Withdraw funds from savings account.");
                    string withdrawAccount = Console.ReadLine().ToUpper();
                    double withdrawAmount = double.Parse(Console.ReadLine());

                    if (withdrawAccount == "A")
                    {
                        Console.WriteLine("Enter the amount you would like to withdraw.");
                        checking.WithdrawFunds();
                        checking.CurrentBalance();
                        Console.WriteLine("Available balance for your checking account is " + checking.CheckingBalance);
                    }
                    else if (withdrawAccount == "B")
                    {
                        Console.WriteLine("Enter the amount you would like to withdraw.");
                        saving.WithdrawFunds();
                        saving.CurrentBalance();
                        Console.WriteLine("Available balance for your savings account is " + saving.SavingBalance);
                    }
                }

                
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
