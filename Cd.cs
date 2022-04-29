using System;

namespace BankingApp 
{   
    class CdAccount : Account
    {
        //strings getters/setters
        public double cdAccountBalance //property 
            {get; set;}
        public CdAccount()      // default constructor
        {
            cdAccountBalance =  0;
        }

        //Cd child contructor
        public CdAccount(int newAccountId, string newAccountType, double newcdAccountBalance) : base (newAccountId, newAccountType, newcdAccountBalance) //another constructor 
        { 
            cdAccountBalance = newcdAccountBalance;            
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