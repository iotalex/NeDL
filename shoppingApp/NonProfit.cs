﻿using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class NonProfit : Member //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
      
            //constructors  
        public NonProfit(int newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases): base(newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases) //another constructor
        {
            //do nothing here
        }

     
        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {GetCashBack(currentMonthPurchases)}";
        }
        
public override double GetCashBack(double monthlyPurchaseAmount)
{
            double percentage = monthlyPurchaseAmount * .04d;///// .04d, converts to decimal
            return currentMonthPurchases * percentage;
}
    }//end class

}//end main 
