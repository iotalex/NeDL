using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class Corporate : Member //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
      
            //constructors  
        public Corporate(int newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases): base(newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases) //another constructor
        {
            //do nothing here
        }

     
        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {GetCashBack()}";
        }
        
public override double GetCashBack()
        {
            return 0.03d * currentMonthPurchases;
        }
    }//end class

}//end main 
