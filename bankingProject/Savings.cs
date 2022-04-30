using System;

namespace BankingApp 
{   
    class SavingsAccount : Account
    {               

        public double feeSavings
            {get; set;}

        //default parent contructor
        public SavingsAccount(){
            //types from above
            accountId = ' ';  
            accountType = " "; 
            feeSavings = ' ';
        }
        //default constructor strings
        public SavingsAccount(int newAccountId, string newAccountType, double newCurrentBalance, int newFeeChecking) : base (newAccountId, newAccountType, newCurrentBalance)
        {
                
            feeSavings = newFeeChecking; 
        }
        
        //interface method Get()
        public double GetBalance()
        {
            return currentBalance;
        }
        public override void MakeWithdrawal(double withDrawalAmount)
        {
            currentBalance = currentBalance - withDrawalAmount; 
        }
          //usefull ToString()
        public override string ToString(){
            return $"AccountID#:{accountId} | Type: {accountType} | Current Balance: ${currentBalance} | Annual Fee: ${feeSavings} ";
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