using System;

namespace BankingApp 
{   
    class Account{
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
            accountId = 0;  
            accountType = " ";  
            currentBalance = 0.00;//double 
        }
        //default constructor strings
        public Account(int newAccountId, string newAccountType, double newCurrentBalance){
            accountId = newAccountId;
            accountType = newAccountType;
            currentBalance = newCurrentBalance;
        }
            //Deposit Method, two parameters (e.g. int x, int y) then return (int x, int y)
        static double DepositMethod(int x, int y){
            return x + y;
        }
        

        //usefull ToString()??? 
        public override string ToString(){
            string outPutString = $"Account#: {accountId} | Account Type: {accountType} | Current Balance $: {currentBalance} | ";
            return outPutString;
        }


            //abstract withdrawal method


            //useful misc method useful to toString 



        
    }//end class Account 
}//end namespace