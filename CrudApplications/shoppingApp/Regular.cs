using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class Regular : Member, IGetSpecialOffer //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
        public double cashBack//special cashBack program
            {get; set;}
        public double diplayTrueCashBack
            {get; set;}
        

            //constructors  
        public Regular(int newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases, double newCashBack): base(newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases) //another constructor
        {
            cashBack = newCashBack; 
        }

        //added implement method
        public double GetSpecialOffer()//interface method
        {
            return annualCost * .25;
        }

        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {GetCashBack()} Special Offer: ${GetSpecialOffer()} "; //GetSpecialOffer can be removed
        }

        public override double GetCashBack()
        {
            return 0.02d * currentMonthPurchases;
        }
            //TODO: method to "add" balance to cashBack
      
    public double DisplaceCashBack(double applyCashBack)//this method does not work (yet); 5-6-22

    //Basically I can't get a GetCashBack() or methed to work like a property; unless I can get cashback into a property value, I don't see 
    //how I can get this to work using logic to salve "A" apply cash back; 5-6-22
    {
        //TODO: grab GetCashBack Method into here
    currentMonthPurchases = currentMonthPurchases;
    return currentMonthPurchases;
    }
        
    }//end class

}//end main 
