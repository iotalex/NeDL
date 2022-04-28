using System;

namespace BankingApp{
    internal class Program{
        static void Main(string[] args){
            
             
            List<Account> accountList = new List<Account>();//list of accounts

            Account newAccount = new Account(1001, "Checking", 13.50);
            accountList.Add(newAccount);
            Account newAccount2 = new Account(1001, "Savings", 18.75);
            accountList.Add(newAccount2);

            
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