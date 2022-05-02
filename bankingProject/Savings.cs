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
            feeSavings = 0.00;
        }
        //default constructor strings
        public SavingsAccount(int newAccountId, string newAccountType, double newCurrentBalance, double newFeeChecking) : base (newAccountId, newAccountType, newCurrentBalance)
        {
                
            feeSavings = newFeeChecking;
        }
              
        //interface method Get()
        public double GetBalance()
        {
            return currentBalance;
        }
        public override void MakeWithdrawal(double withDrawalAmount)//withdrawal method
        {
            currentBalance = currentBalance - withDrawalAmount; 
        }

         public override bool WithDrawalCheckingRule(double withDrawalAmount)//withdrawal method
        {
            // TODO: Check if WITHDRAWL amount > 50% of current balance 
            // TODO: If so, then return false
            
            if (withDrawalAmount > (currentBalance / 2.0d))//2.0d - tells/declares a "double" 'd' after the number 
                return false;

            // TODO: Do normal stuff here
            currentBalance = currentBalance - withDrawalAmount;  //if logic parenters of 50%, in program.cs
            // TODO: return true
            return true;
        }

          //usefull ToString()
        public override string ToString(){
            return $"AccountID#:{accountId} | Type: {accountType} | Current Balance: ${currentBalance} | Annual Earned Interest: ${feeSavings} ";
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