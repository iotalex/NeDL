using System;

namespace BankingApp 
{   
    class CheckingAccount : Account
    {
        //strings getters/setters
        public int accountId
            {get; set;}
      
        public CheckingAccount() : base()      // Checking constructor
        {
            //types from above
            accountId =  0;
        }

        
        public override void SetBalance(int newAccountId)  // interface method
        {
            accountId = newAccountId;
        }
        
         public override string ToString()
        {
            return base.ToString() + " | AccountID" + accountId + " | Balance?: $";
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