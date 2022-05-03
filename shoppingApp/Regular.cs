using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class Regular : Member //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
        //create getters and setters (properties)
        public Regular()
        {
            
        }
            //constructors  
        public Regular(string newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases) : base(newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases) //another constructor
        {
            
        }

        public override string ToString()
        {
            return$"Member ID#: {memberId} | Email Address: {emailAddress} | Type: {membershipType} | Annual fee: {annualCost} | Monthly Purchases: $ {currentMonthPurchases} "; 
        }
        

    }//end class

}//end main 
