using System;

namespace BankingApp{
    internal class Program{
        static void Main(string[] args){

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
            foreach(Account anAccountList in accountList)
            {
                Console.WriteLine(anAccountList);//prints the list above (test data)
            }//end foreach 
        
        // Experiment with Reading (finding) an employee(s) in the list
        //======================================================================
            Console.Write("Please enter an account number#: ");
            string findAccount = Console.ReadLine();
            bool found = false;
            foreach (Account anAccount in accountList)
            {
                
            }  // end foreach  
            if (!(found))
                Console.WriteLine("Name was not found.");

            



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

            