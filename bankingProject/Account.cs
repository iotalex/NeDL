﻿using System;

namespace BankingApp 
{   
    class Account{
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
            accountId = 0;  
            accountType = " ";  
            currentBalance = 0;
        }
        //default constructor strings
        public Account(int newAccountId, string newAccountType, int newCurrentBalance){
            accountId = newAccountId;
            accountType = newAccountType;
            currentBalance = newCurrentBalance;
        }

        public virtual double DepositMethod(){
            return 0.0;
        }
        public override string ToString(){
            string outPutString = $"Account#: {accountId} | Account Type: {accountType} | Current Balance $: {currentBalance} | ";
            return outPutString;
        }
        
/*
string outputString = $"{base.ToString()} | Series: {aceSeries}";
            return outputString;
*/
            //depositmethod

            //abstract withdrawal method


            //useful misc method useful to toString 



        
    }//end class Account 
}//end namespace