﻿using System;

namespace BankingApp{
    internal class Program{
        static void Main(string[] args){
            
             
            List<Account> accountList = new List<Account>();//list of accounts
            
        //main parent class == Account == test data  
            Account newAccount = new Account(0001, "Checking", 13.50);
            accountList.Add(newAccount);
            Account newAccount2 = new Account(0002, "Savings", 18.75);
            accountList.Add(newAccount2);
        //First child class == Checking == test data  
            Account newCheckingAccount = new Account(2001, "Checking", 57.50);
            accountList.Add(newAccount);
            Account newCheckingAccount2 = new Account(2002, "Checking", 138.75);
            accountList.Add(newAccount2);

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