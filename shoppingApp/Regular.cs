using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class Regular : Member //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
        public double cashBack
            {get; set;}
        
        public Regular() : base() //defualt constructor
        {
            cashBack = 0.0;
        }
            //constructors  
        public Regular(int newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases, double newCashBack): base(newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases) //another constructor
        {
            cashBack = newCashBack;
        }
        //TODO: add implement method
        public override double ICalculate() // this is the abstract method that all children must implement
        {
            return currentMonthPurchases * .02;
        }

        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {ICalculate()}";
        }
        

    }//end class

}//end main 
