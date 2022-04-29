using System;

namespace BankingApp 
{   
    abstract class Account
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
            currentBalance = ' ';//double
        }
        //default constructor strings
        public Account(int newAccountId, string newAccountType, double newCurrentBalance){
            accountId = newAccountId;
            accountType = newAccountType;
            currentBalance = newCurrentBalance;
        }

        public void MakeDeposit(double depositAmount)
        {
            currentBalance = currentBalance + depositAmount;
        }

        public abstract void MakeWithdrawal(double withDrawalAmount); 

      

            //usefull ToString()
        public override string ToString(){
            return $"Account#: {accountId} | Account Type: {accountType} | Current Balance: ${currentBalance} | ";
        }

        
    }//end class Account 
}//end namespace




