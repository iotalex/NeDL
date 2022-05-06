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
//TODO: 
//define a new method with different parameters
        //need to say" applyCashBack = newApplyCashBack;??????????????????????????? NO
        


        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {GetCashBack()} Test: {diplayTrueCashBack} Special Offer: ${GetSpecialOffer()} "; //GetSpecialOffer can be removed
        }

        public override double GetCashBack()
        {
            return 0.02d * currentMonthPurchases;
        }
            //TODO: method to "add" balance to cashBack
       public double MakeCashBack(double applyCashBack)
       {
        //TODO: marry convertCashBack with "Cashback" method() double convertCashBack = Convert.ToDouble(GetCashBack(monthlyPurchaseAmount));
        double sum = applyCashBack + GetCashBack();
        return sum;
        }  
    public double DisplaceCashBack(double diplayTrueCashBack)
    {
        //TODO: grab GetCashBack Method into here
    diplayTrueCashBack = currentMonthPurchases + diplayTrueCashBack;
    return diplayTrueCashBack;
    }
        
    }//end class

}//end main 
