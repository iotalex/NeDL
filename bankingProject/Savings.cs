using System;

namespace BankingApp 
{   
    class SavingsAccount : Account
    {
        //strings getters/setters
        public double savingsAccountBalance //property 
            {get; set;}
        public SavingsAccount()      // default constructor
        {
            savingsAccountBalance =  0;
        }

        //Checking child contructor
        public SavingsAccount(int newAccountId, string newAccountType, double newSavingsAccountBalance) : base (newAccountId, newAccountType, newSavingsAccountBalance) //another constructor 
        { 
            savingsAccountBalance = newSavingsAccountBalance;            
        }
          
         



            


            


        
    }//end class Account 
}//end namespace






  //parent class: Account 
            //checkingAccount --interface method 
            //savingsAccount--interface method 
            //CdAccount--interface method 
            //withdrawal--abstract method  


//I reserached this, but it's too soon to implement; deposit should be standard method?

/*
            //Deposit Method, two parameters return (int x, int y)
        static double Deposit(double x, double y){
            return x + y;
        }

            */