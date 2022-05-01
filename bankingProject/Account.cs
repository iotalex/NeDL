using System;

namespace BankingApp 
{   
    abstract class Account //cool, so abstract class allows us to override boolean issues stuff??
    {               
        //strings getters/setters
        public int accountId
            {get; set;}
        public string accountType
            {get; set;}
        public double currentBalance
            {get; set;}

        //default parent contructor
        public Account(){
            //types from above
            accountId = ' ';  
            accountType = " ";  
            currentBalance = 0.00;//double
        }
        //default constructor strings
        public Account(int newAccountId, string newAccountType, double newCurrentBalance){
            accountId = newAccountId;
            accountType = newAccountType;
            currentBalance = newCurrentBalance;
        }

        public void MakeDeposit(double depositAmount)//deposit method 
        {
            currentBalance = currentBalance + depositAmount;
        }
        
        
        public abstract void MakeWithdrawal(double withDrawalAmount);//withdrawal method
            

            //usefull ToString()
        public override string ToString(){
            return $"AccountID#: {accountId} | Type: {accountType} | Current Balance: ${currentBalance} | ";
        }

        
    }//end class Account 
}//end namespace




