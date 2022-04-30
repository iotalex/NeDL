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
                Console.WriteLine("Z: Make a checking transaction");
               

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                             userChoiceString=="W" || userChoiceString=="w" ||
                             userChoiceString=="Z" || userChoiceString=="z" ||
                            userChoiceString == "D" || userChoiceString == "d" );

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);

        //  TODO: If the option is L or l prints the list above (test data)

            if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("In the L/l area");
            foreach(Account anAccountList in accountList)
            {
                Console.WriteLine(anAccountList);//prints the list above (test data)
            }//end foreach 
            
            }

        //  TODO: Else if the option is an D or d -- perform a desposit 

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                double depositAmount;
                int accountId;
 
                Console.WriteLine("Please enter deposit amount: ");
                depositAmount = Convert.ToDouble(Console.ReadLine());
                    while(depositAmount <= 0) //acount balance divided by %50
                    {
                    Console.WriteLine("Hey, please enter a positive number.");//warns user to enter positive integer
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
                        }//end if 
               
                
                }//end foreach


            }

        //  TODO: Else if the option is a C or c then add a name to the array (if there's room)

            else if (userChoiceString=="W" || userChoiceString=="w")
            {
                double withDrawalAmount;
                int accountId; 

                Console.WriteLine("Please enter withdrawal amount: ");
                withDrawalAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter account number"); 
                accountId = Convert.ToInt32(Console.ReadLine());
                
                foreach(Account anAccount in accountList)
                {
                      if (withDrawalAmount <= 0)
                {
                            Console.WriteLine("Hey, please enter a positive number.");
                            break;
                }
                    if(anAccount.accountId==accountId)
                        {
                            anAccount.MakeWithdrawal(withDrawalAmount);
                            Console.WriteLine("Withdrawal made");//prints the list above (test data)
                        }//end if 
                }//end foreach     
            }


            //savings: withdrawal is allowed but only as long as the balance is great than the withdrawal amount 

            ///CD: withdrawal is allowed but with early penalty (applied) so the balance needs to be greater than the withdrawl aomun and penalty combined 

        //  TODO: Else if the option is a Z or z then make  

            else if (userChoiceString=="Z" || userChoiceString=="z")
            {
             
            //TODO: 4-29-22, left off here last Friday; 
                        // Checking account withdrawal is allowed but only up to 50% of the account balance.

                
                
            



                
            }

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

            