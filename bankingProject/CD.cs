﻿using System;

namespace BankingApp 
{   
    class CdAccount : Account
    {               

        public double feeCD
            {get; set;}

        //default parent contructor
        public CdAccount(){
            //types from above
            accountId = ' ';  
            accountType = " "; 
            feeCD = 0.0;
        }
        //default constructor strings
        public CdAccount(int newAccountId, string newAccountType, double newCurrentBalance, double newfeeCD) : base (newAccountId, newAccountType, newCurrentBalance)
        {
                
            feeCD = newfeeCD; 
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
   
        public override string ToString(){
            return $"AccountID#:{accountId} | Type: {accountType} | Current Balance: ${currentBalance} | Annual Earned Interest: ${feeCD} ";
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