using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    abstract class Member //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
        public int memberId
            {get; set;}
        public string emailAddress
            {get; set;}
        public string membershipType
            {get; set;}
        public double annualCost
            {get; set;}
        public double currentMonthPurchases
            {get; set;}
        
        //create getters and setters (properties)
        public Member()
        {
            memberId = 0; 
            emailAddress = " ";
            membershipType = " ";
            annualCost = 0.0;
            currentMonthPurchases = 0.0; 
        }
            //constructors  
        public Member(int newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases)//defualt constructor
        {
            memberId = newMemberId;
            emailAddress = newEmailAddress;
            membershipType = newMembershipType;
            annualCost = newAnnualCost;
            currentMonthPurchases = newCurrentMonthPurchases;
        }
        public abstract double ICalculate();  // (cashback) this is the abstract method that all children must implement

        public override string ToString()
        {
            return$"Member ID#: {memberId} | Email Address: {emailAddress} | Type: {membershipType} | Annual fee: {annualCost} | Monthly Purchases: $ {currentMonthPurchases} "; 
        }
        

    }//end class

}//end main 
