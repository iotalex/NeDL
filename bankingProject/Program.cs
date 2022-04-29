using System;

namespace BankingApp{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Account> accountList = new List<Account>();//list of accounts
            
        //main parent class == Account == test data                     
            accountList.Add(new Account(1001, "CheckingBase", 55));
            accountList.Add(new Account(1002, "SavingsBase", 69));
            accountList.Add(new CheckingAccount(2001, "Checking", 55.56));
            accountList.Add(new CheckingAccount(2002, "Checking2", 169.50));
           /* 
            Account newAccount2 = new Account(1002, "Savings", 18.75);
            accountList.Add(newAccount2);
        //First child class == Checking == test data  
            CheckingAccount newCheckingAccount = new CheckingAccount();
            accountList.Add(newCheckingAccount);
            CheckingAccount newCheckingAccount2 = new CheckingAccount();
            accountList.Add(newCheckingAccount2);
        //Second child class == Savings == test data  
            SavingsAccount newSavingsAccount = new SavingsAccount(3001, "Savings", 69.50);
            accountList.Add(newSavingsAccount);
            SavingsAccount newSavingsAccoun2 = new SavingsAccount(3002, "Savings", 2000.75);
            accountList.Add(newSavingsAccoun2);
        //Second child class == Savings == test data  
            CdAccount newCdAccount = new CdAccount(4001, "CD", 2400.51);
            accountList.Add(newCdAccount);
            CdAccount newCdAccoun2 = new CdAccount(4002, "CD", 18500.60);
            accountList.Add(newCdAccoun2);
*/
            
         // Declare variables
        bool userChoice;
        string userChoiceString;
        string[] nameArray = new string[10];

      // Repeat main loop
      do
      {

        // TODO: Get a valid input
            do
            {
                //  Initialize variables

                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("Please select an option beloew: ");
                Console.WriteLine("L: Load the accounts.");
                Console.WriteLine("S: Save the array to the data file.");
               

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                            userChoiceString == "S" || userChoiceString == "s" );

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);

        //  TODO: If the option is L or l then load the text file (names.txt) into the array of strings (nameArray)

            if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("In the L/l area");
            foreach(Account anAccountList in accountList)
            {
                Console.WriteLine(anAccountList);//prints the list above (test data)
            }//end foreach 
            
            }

        //  TODO: Else if the option is an S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                Console.WriteLine("In the S/s area");
            }

        //  TODO: Else if the option is a C or c then add a name to the array (if there's room)

            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area");
            }

        //  TODO: Else if the option is an R or r then print the array

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("In the R/r area");
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine(nameArray[index]);
                }

            }
        //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
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
        
/*
foreach(Employee anEmployee in employeeList)//prints the "list" above
                {
                    Console.WriteLine(employeeList);
                }//start CRUD here

*/


        
    }//end class Program 
}//end namespace


 //parent class: Account 
            //checkingAccount --interface method 
            //savingsAccount--interface method 
            //CdAccount--interface method 
            

            //deposit - is built into "D"; CRUD and use   if else or (pull the integer and then add to it)
            
            
            //withdrawal--abstract method; 

            