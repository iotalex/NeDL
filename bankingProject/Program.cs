using System;

namespace BankingApp{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Account> accountList = new List<Account>();//list of accounts
            
        //main parent class == Account == test data                     
           // accountList.Add(new Account(1001, "CheckingBase", 55.98));
           // accountList.Add(new Account(1002, "SavingsBase", 69.56));
            accountList.Add(new CheckingAccount(2001, "Checking", 129.25, 55));
            accountList.Add(new CheckingAccount(2002, "Checking2", 169.65, 25));

            accountList.Add(new SavingsAccount(3001, "Savings", 6950.35, 0));
            accountList.Add(new SavingsAccount(3001, "Savings2", 2600.50, 0));

            accountList.Add(new CdAccount(4001, "CD", 32000, 0));
            accountList.Add(new CdAccount(4002, "CD2", 18000, 0));
   
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
                Console.WriteLine("L: Load the accounts.");
                Console.WriteLine("D: Make a desposit");
                Console.WriteLine("W: Make a Withdrawal");
                Console.WriteLine("P: Pick an account: ");
                Console.WriteLine("Z: Make a checking transaction");
                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                             userChoiceString=="W" || userChoiceString=="w" ||
                             userChoiceString == "D" || userChoiceString == "d" ||
                             userChoiceString == "P" || userChoiceString == "p" ||
                             userChoiceString=="Z" || userChoiceString=="z");

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);

        //  TODO: If the option is L or l prints the list above (test data)

            if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("List of accounts: ");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                foreach(Account anAccountList in accountList)
                    {
                        Console.WriteLine(anAccountList);//prints the list above (test data)
                    }//end foreach       
            }//end if

        //  TODO: "D" make a Desposit

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                double depositAmount;
                int accountId;
 
                Console.WriteLine("Please enter deposit amount: ");
                depositAmount = Convert.ToDouble(Console.ReadLine());
                    while(depositAmount <= 0) //acount balance divided by %50
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
                            Console.WriteLine("Deposit made");
                        }
                }
            }//end foreach " " 

        //  TODO: "W" make a withdrawal 
            else if (userChoiceString=="W" || userChoiceString=="w")
            {
                double withDrawalAmount;
                int accountId; 

                Console.WriteLine("Please enter withdrawal amount: ");
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
            }//end foreach "W" 

            
            //************************************************************
            
            
            
            else if (userChoiceString=="P" || userChoiceString=="p")
            {
                   bool userChoice2;
                    string userChoiceString2;
                    
                //Repeat main loop 
                    do
                    {     
                    //  TODO: Get a valid input 
                    do
                    {

                        //Initialize variables
                        
                        userChoice2 = false;
                        
                        //   TODO: Provide the user a menu of options

                        Console.WriteLine("What's your pleasure?");
                        Console.WriteLine("C: Checking account.");
                        Console.WriteLine("S: Savings account");
                        Console.WriteLine("Cd account: .");
                        Console.WriteLine("Q: Quit the program.");
                        
                            
                        //   TODO: Get a valid user option (valid means its on the menu)
                        userChoiceString2 = Console.ReadLine();
                        
                        
                        userChoice2 = (userChoiceString2== "C" || userChoiceString2 == "c" ||  
                                        userChoiceString2 == "S" || userChoiceString2 == "s" ||  
                                        userChoiceString2 == "D" || userChoiceString2 == "d" ||      
                                        userChoiceString2 == "Q" || userChoiceString2 == "q");  
                                
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
                            
                            }//end using    

                    //   Select savings account
                            else if (userChoiceString2=="S" || userChoiceString2=="s")
                            {
                            //equivilent of saying "CTR + S" 
                            }
                    //   Select CD account  
                            else if (userChoiceString2 =="CD" || userChoiceString2 =="cd") 
                            {
                            //typicall if statements 
                            }
                    
                    //   TODO: Else if the option is a Q or q then quit the program                
                            else if (userChoiceString2=="Q" || userChoiceString2=="q")
                            {
                            Console.WriteLine("Goodbye, auf wiedersehen");
                            }
                }// ends the big "do"
                while(!(userChoiceString2=="Q"));

            }//end if

            //savings: withdrawal is allowed but only as long as the balance is great than the withdrawal amount 

            ///CD: withdrawal is allowed but with early penalty (applied) so the balance needs to be greater than the withdrawl aomun and penalty combined 

        //  TODO: "Z" make a CHECKING withdrawal  

            else if (userChoiceString=="Z" || userChoiceString=="z")
            {
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
                
            }//end foreach "W" 

        //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
            }
        //  TODO: Else if the option is a Q or q then quit the program

            else 
            {
                Console.WriteLine("Good-bye!");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
        }//end static main

    }//end class Program 
}//end namespace


 //parent class: Account 
            //checkingAccount --interface method 
            //savingsAccount--interface method 
            //CdAccount--interface method 
            

            //deposit - is built into "D"; CRUD and use   if else or (pull the integer and then add to it)
            
            
            //withdrawal--abstract method; 

            