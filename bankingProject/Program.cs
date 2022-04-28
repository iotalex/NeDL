using System;

namespace BankingApp{
    internal class Program{
        static void Main(string[] args){
            
             
            List<Account> accountList = new List<Account>();//list of accounts
            
        //main parent class == Account == test data  
                    
            Account newAccount = new Account(1001, "Checking", 13.50);
            accountList.Add(newAccount);
            Account newAccount2 = new Account(1002, "Savings", 18.75);
            accountList.Add(newAccount2);
        //First child class == Checking == test data  
            CheckingAccount newCheckingAccount = new CheckingAccount(2001, "Checking", 57.50);
            accountList.Add(newCheckingAccount);
            CheckingAccount newCheckingAccount2 = new CheckingAccount(2002, "Checking", 138.75);
            accountList.Add(newCheckingAccount2);
        //Second child class == Savings == test data  
            SavingsAccount newSavingsAccount = new SavingsAccount(3001, "Savings", 69.50);
            accountList.Add(newSavingsAccount);
            SavingsAccount newSavingsAccoun2 = new SavingsAccount(3002, "Savings", 2000.75);
            accountList.Add(newSavingsAccoun2);

            //parent class: Account 
            //checkingAccount --interface method 
            //savingsAccount--interface method 
            //CdAccount--interface method 
            

            //deposit - is built into "D"; CRUD and use   if else or (pull the integer and then add to it)
            
            
            //withdrawal--abstract method; 

            
            foreach(Account aListItem in accountList){
                Console.WriteLine(aListItem);//prints the list above (test data)
            }


            



        }//end static main
        
/*
foreach(Employee anEmployee in employeeList)//prints the "list" above
                {
                    Console.WriteLine(employeeList);
                }//start CRUD here

*/


        
    }//end class Program 
}//end namespace