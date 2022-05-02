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
           // accountList.Add(new Account(1001, "CheckingBase", 55.98));
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
                
        if (userChoiceString=="F" || userChoiceString=="f")
            {
                double withDrawalAmount;
                int accountId;
                double currentBalance;
                Console.WriteLine("=========================CHECKING ACCOUNT=============================");
                Console.WriteLine("How much would you like to withdrawal?");
                
                withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                //TODO: Get line to read balance
                currentBalance = Convert.ToDouble(Console.ReadLine());
                //TODO: Get line to write balance
                while(withDrawalAmount >= currentBalance)
                    {
                        Console.WriteLine("You cannot make this transaction.");
                        break;
                    }
                while(withDrawalAmount <= 0)
                    {
                    Console.WriteLine("-------------Warning-------------");//warns user to enter positive integer
                    Console.WriteLine("PLEASE ENTER A POSITIVE NUMBER!");//warns user to enter positive integer
                    if(withDrawalAmount < 0)//second chance to enter positive number
                        {
                            withDrawalAmount = InputUtilities.PromptForDoubleInput("type initial message ot user");
//                            withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                        }
                    break; 
                    }//end if
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
                
            }//end if "F" 
        
        
        
        
        //  TODO: If the option is L or l prints the list above (test data)

            if (userChoiceString=="L" || userChoiceString=="l")
            {
                foreach(CheckingAccount checkingAccount in accountList)  
                    {
                        Console.WriteLine(checkingAccount);//prints the list above (test data)
                    }//end foreach
                 
   
            }//end if "L" 
            

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

            else if (userChoiceString=="W" || userChoiceString=="w")
            {
                    bool userChoice2;
                    string userChoiceString2;  
                //Repeat main Withdrawal Account select loop 
                    do
                    {     
                    //  TODO: Get a valid input 
                    do
                    {
                        userChoice2 = false;
        //==============================================WITHDRAWAL TRANSACTIONS MENU================================================
                        Console.WriteLine("===================WITHDRAWAL TRANSACTION MENU===================");
                        Console.WriteLine("Which account would you like to make an withdrawal?");
                        Console.WriteLine("C: Checking account.");
                        Console.WriteLine("S: Savings account");
                        Console.WriteLine("B: CD Bonds account");
                        Console.WriteLine("R: Return to Main Menu");
                        userChoiceString2 = Console.ReadLine();
                        userChoice2 = (userChoiceString2== "C" || userChoiceString2 == "c" ||  
                                        userChoiceString2 == "S" || userChoiceString2 == "s" ||  
                                        userChoiceString2 == "B" || userChoiceString2 == "b" ||      
                                        userChoiceString2 == "R" || userChoiceString2 == "r");  
                                
                            if(!userChoice2)
                            {
                            Console.WriteLine("Please enter a valid option");
                            }    
                        }//ends the second "do" which is to get "valid input"
                        while (!userChoice2);

                    //   Select checking account
                            if (userChoiceString2=="C" || userChoiceString2=="c")
                            {
                double withDrawalAmount;
                int accountId;
                double currentBalance;
                Console.WriteLine("=========================CHECKING ACCOUNT=============================");
                Console.WriteLine("How much would you like to withdrawal?");
                
                withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                //TODO: Get line to read balance
                currentBalance = Convert.ToDouble(Console.ReadLine());
                //TODO: Get line to write balance
                while(withDrawalAmount >= currentBalance)
                    {
                        Console.WriteLine("You cannot make this transaction.");
                        break;
                    }
                while(withDrawalAmount <= 0)
                    {
                    Console.WriteLine("-------------Warning-------------");//warns user to enter positive integer
                    Console.WriteLine("PLEASE ENTER A POSITIVE NUMBER!");//warns user to enter positive integer
                    if(withDrawalAmount < 0)//second chance to enter positive number
                        {
                            withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                        }
                    break; 
                    }//end if
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
       
            }//end using "C" for checking withdrawal    

                    //   Select savings account
                            else if (userChoiceString2=="S" || userChoiceString2=="s")
                            {
                double withDrawalAmount;
                int accountId; 
                Console.WriteLine("=========================Savings ACCOUNT=============================");
                Console.WriteLine("How much would you like to withdrawal?");
                
                withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                while(withDrawalAmount <= 0)
                    {
                    Console.WriteLine("-------------Warning-------------");//warns user to enter positive integer
                    Console.WriteLine("PLEASE ENTER A POSITIVE NUMBER!");//warns user to enter positive integer
                    if(withDrawalAmount < 0)//second chance to enter positive number
                        {
                            withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                        }
                    break; 
                    }//end if
                
                Console.WriteLine("Please enter your account ID#"); 
                accountId = Convert.ToInt32(Console.ReadLine());
                
                foreach(Account anAccount in accountList)
                {
                    while(accountId <= 3000)//requires valid ID#
                    break;
                    while(accountId >= 3999)
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
                }//foreach
            }//end "S" savings withdrawal 
                    
                    
                    
    //TODO:  ///CD: withdrawal is allowed but with early penalty (applied) so the balance needs to be greater than the withdrawl aomun and penalty combined 

                    //   Select CD account  
                            else if (userChoiceString2 =="B" || userChoiceString2 =="b") 
                            {
                            double withDrawalAmount;
                int accountId; 
                Console.WriteLine("=========================CD ACCOUNT=============================");
                Console.WriteLine("How much would you like to withdrawal?");
                
                withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                while(withDrawalAmount <= 0)
                    {
                    Console.WriteLine("-------------Warning-------------");//warns user to enter positive integer
                    Console.WriteLine("PLEASE ENTER A POSITIVE NUMBER!");//warns user to enter positive integer
                    if(withDrawalAmount < 0)//second chance to enter positive number
                        {
                            withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                        }
                    break; 
                    }//end if
                
                Console.WriteLine("Please enter your account ID#"); 
                accountId = Convert.ToInt32(Console.ReadLine());
                
                foreach(Account anAccount in accountList)
                {
                    while(accountId <= 4000)//requires valid ID#
                    break;
                    while(accountId >= 4999)
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
                }//foreach
                            }
                 
                            
                }// ends the big "do"
                while(!(userChoiceString2=="R") && !!(userChoiceString=="r"));//goes right back to main menu

            }//end if

            else 
            {
                Console.WriteLine("===============THANKS FOR BANKING WITH US TODAY===============");
                Console.WriteLine("                 ****PLEASE COME AGAIN SOON!****                 ");
            }
        } while (!(userChoiceString=="Q") & !(userChoiceString=="q"));
        }//end static main

    }//end class Program 
}//end namespace




///////////////////////////BACKUP TEMPLATE FOR ACCOUNTS 
          /*
 double withDrawalAmount;
                int accountId; 
                Console.WriteLine("=========================CHECKING ACCOUNT=============================");
                Console.WriteLine("How much would you like to withdrawal?");
                
                withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                while(withDrawalAmount <= 0)
                    {
                    Console.WriteLine("-------------Warning-------------");//warns user to enter positive integer
                    Console.WriteLine("PLEASE ENTER A POSITIVE NUMBER!");//warns user to enter positive integer
                    if(withDrawalAmount < 0)//second chance to enter positive number
                        {
                            withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                        }
                    break; 
                    }//end if
                Console.WriteLine("Please enter account number"); 
                accountId = Convert.ToInt32(Console.ReadLine());
                
                foreach(Account anAccount in accountList)
                {
                    if(anAccount.accountId==accountId)
                        {
                            anAccount.MakeWithdrawal(withDrawalAmount);
                            Console.WriteLine("Withdrawal made");//prints the list above (test data)
                        }//end if 
                } 
          */