using System;

namespace BankingApp 
{   
    class Account
    {               
        //strings getters/setters
        public int accountId
            {get; set;}
        public string accountType
            {get; set;}
        public int currentBalance
            {get; set;}

        //default parent contructor
        public Account(){
            //types from above
            accountId = ' ';  
            accountType = " ";  
            currentBalance = 0;//double
        }
        //default constructor strings
        public Account(int newAccountId, string newAccountType, int newCurrentBalance){
            accountId = newAccountId;
            accountType = newAccountType;
            currentBalance = newCurrentBalance;
        }
      
     

            //usefull ToString()
        public override string ToString(){
            return $"Account#: {accountId} | Account Type: {accountType} | Current Balance: ${currentBalance} | ";
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