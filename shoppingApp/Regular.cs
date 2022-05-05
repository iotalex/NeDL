using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class Regular : Member, IGetSpecialOffer //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
        public double cashBack
            {get; set;}
        
        
            //constructors  
        public Regular(int newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases, double newCashBack): base(newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases) //another constructor
        {
            cashBack = newCashBack;    
        }
        //TODO: add implement method
        public double GetSpecialOffer()//interface method
        {
            return annualCost * .25;
        }

        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {GetCashBack(currentMonthPurchases)} Special Offer: ${GetSpecialOffer()}"; //GetSpecialOffer can be removed
        }

        public override double GetCashBack(double monthlyPurchaseAmount)
        {
            return 0.02d * monthlyPurchaseAmount;
        }

    
        
    }//end class

}//end main 
