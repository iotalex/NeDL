using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class Member //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
        public string memberId
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
            memberId = " "; 
            emailAddress = " ";
            membershipType = " ";
            annualCost = 0.0;
            currentMonthPurchases = 0.0; 
        }
            //constructors  
        public Member(string newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases)//defualt constructor
        {
            memberId = newMemberId;
            emailAddress = newEmailAddress;
            membershipType = newMembershipType;
            annualCost = newAnnualCost;
            currentMonthPurchases = newCurrentMonthPurchases;


        }
        




    }//end class

}//end main 
