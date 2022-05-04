using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class NonProfit : Member, IGetSpecialOffer //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
      
            //constructors  
        public NonProfit(int newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases): base(newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases) //another constructor
        {
            //do nothing here
        }
        //TODO: add implement method
        public double GetSpecialOffer()//interface method
        {
            return annualCost * .50;
        }
     
     
        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {GetCashBack(currentMonthPurchases)} Special Offer: ${GetSpecialOffer()}";
        }
        
public override double GetCashBack(double monthlyPurchaseAmount)
{
            double percentage = (monthlyPurchaseAmount > 1000.0d) ? 0.05d : 0.02d;///// ternary  <2% for <1000; % cash back for montlhy purchases >1000 
            return currentMonthPurchases * percentage;
}
    }//end class

}//end main 
