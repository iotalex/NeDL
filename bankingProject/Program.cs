using System;
using System.Collections;
using System.Collections.Generic;   // needed for Lists
using System.Linq;
using System.Text;

namespace BankingApp{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accountList = new List<Account>();//list of accounts
            
        //main parent class == Account == test data                     
           //accountList.Add(new Account(1001, "CheckingBase", 55.98));
          // accountList.Add(new Account(1002, "SavingsBase", 69.56));
            accountList.Add(new CheckingAccount(2001, "Checking", 10.00, 10));
            accountList.Add(new CheckingAccount(2002, "Checking2", 169.65, 50));

            accountList.Add(new SavingsAccount(3001, "Savings", 6950.35, 5.26));
            accountList.Add(new SavingsAccount(3002, "Savings2", 2600.50, 6.88));

            accountList.Add(new CdAccount(4001, "CD", 32000, 13.56));
            accountList.Add(new CdAccount(4002, "CD2", 18000, 14.59));
   
         // Declare variables
        bool userChoice;
        string userChoiceString;

      // Repeat main loop
      do
      {

        // TODO: Get a valid input
            do
            {
                //  Initialize variables
                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("Please select an option below: ");
                Console.WriteLine("L: Print account List/Balance(s)");
                Console.WriteLine("F: Checking test");
                Console.WriteLine("D: Deposit Money to an Account");
                Console.WriteLine("W: Withdrawal Transaction Menu");
                Console.WriteLine("Q: Quit Banking Program");
                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();
    //==============================================MAIN MENU================================================
                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                            userChoiceString == "F" || userChoiceString == "f" ||
                             userChoiceString == "D" || userChoiceString == "d" ||
                             userChoiceString == "W" || userChoiceString == "w" ||
                             userChoiceString=="Q" || userChoiceString=="q");

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);
        //====================testing checking account template area ========================
         //  TODO: If the option is L or l prints the list above (test data)

        if (userChoiceString=="L" || userChoiceString=="l")
        {
            foreach(Account anAccount in accountList)  
                {
                    Console.WriteLine(anAccount);//prints the list above (test data)
                }//end foreach
         
         
                
        }//end if "L"     

        else if (userChoiceString=="F" || userChoiceString=="f")
            {
                double withDrawalAmount;
                int accountId;
                double currentBalance;
                //prompts user and accepts user input number 
                withDrawalAmount = InputUtilities.PromptForDoubleInput("How much would you like to withdrawal?");
                
                currentBalance = InputUtilities.PromptForDoubleInput("What is this?");
                
                if(withDrawalAmount >= currentBalance)
                    {
                        Console.WriteLine("You cannot make this transaction.");
                        break;
                    }
                Console.WriteLine("Please enter your account ID#"); //plumbing not working, come back to this later; 5-2-22
                accountId = Convert.ToInt32(Console.ReadLine());
                
                foreach(CheckingAccount anAccount in accountList)
                {
 
                    if(anAccount.accountId==accountId)
                        {
                            anAccount.MakeWithdrawal(withDrawalAmount);
                            Console.WriteLine("Withdrawal successfuly made");//prints the list above (test data)
                        }//end if
                    if(anAccount.accountId==accountId)
                        {
                            anAccount.MakeWithdrawal(currentBalance);
                            Console.WriteLine("Withdrawal successfuly made");//prints the list above (test data)
                        }//end if

                }//end foreach


        /*
                Console.WriteLine("Please enter your account ID#"); 
                accountId = Convert.ToInt32(Console.ReadLine());
                
                foreach(Account anAccount in accountList)
                {
                    while(accountId <= 2000)//requires valid ID#
                    break;
                    while(accountId >= 2999)
                    {
                    Console.WriteLine("-------------Warning-------------");
                    Console.WriteLine("PLEASE ENTER VALID ID#!");
                    if(accountId <= 0)//second chance to enter valid ID# number
                        {
                            accountId = Convert.ToChar(Console.ReadLine());
                        }
                    break; 
                    }
                    if(anAccount.accountId==accountId)
                        {
                            anAccount.MakeWithdrawal(withDrawalAmount);
                            Console.WriteLine("Withdrawal successfuly made");//prints the list above (test data)
                        }//end if

                }//end foreach
            */
                
            }//end if "F" 

       
        //  TODO: "D" make a Desposit

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                double depositAmount;
                int accountId;
                Console.WriteLine("===================DEPOSIT TRANSACTION MENU===================");
                Console.WriteLine("Please enter deposit amount: $ ");
                depositAmount = Convert.ToDouble(Console.ReadLine());
                    while(depositAmount <= 0)//user must enter positive number 
                    {
                    Console.WriteLine("-------------Warning-------------");//warns user to enter positive integer
                    Console.WriteLine("PLEASE ENTER A POSITIVE NUMBER!");//warns user to enter positive integer
                        if(depositAmount < 0)//second chance to enter positive number
                            {
                                depositAmount = Convert.ToDouble(Console.ReadLine());
                            }
                        break;   
                    }
                Console.WriteLine("Please enter account number"); 
                accountId = Convert.ToInt32(Console.ReadLine());
            
                foreach(Account anAccount in accountList)
                {
                    if(anAccount.accountId==accountId)
                        {
                            anAccount.MakeDeposit(depositAmount);
                            Console.WriteLine("Savings deposit made");
                        }
                }
                
            }//end foreach " " 

           //   TODO: Else if the option is a Q or q then quit the program                
                else if (userChoiceString=="Q" || userChoiceString=="q")
                {
                  Console.WriteLine("Goodbye, auf wiedersehen");
                }
      }// ends the big "do"
       while(!(userChoiceString=="Q"));
        }//end static main

    }//end class Program 
}//end namespace




