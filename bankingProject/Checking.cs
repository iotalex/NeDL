using System;

namespace BankingApp 
{   
    class CheckingAccount : Account
    {
        //strings getters/setters
        public double checkingAccountBalance //property 
            {get; set;}
        public CheckingAccount() : base()      // default constructor
        {
            checkingAccountBalance =  0;
        }

        //Checking child contructor
        public CheckingAccount(int newAccountId, string newAccountType, double newCheckingAccountBalance) : base (newAccountId, newAccountType, newCheckingAccountBalance) //another constructor 
        { 
            checkingAccountBalance = newCheckingAccountBalance;            
        }
          
            //base ToString()
        public override string ToString(){
            return base.ToString(); 
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