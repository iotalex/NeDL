using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class Executive : Member, IGetSpecialOffer //abstract class, objects can't be instantiated (objects of this type can't be created)    
    {
        public double cashBack
            {get; set;}
        
        public Executive() : base() //defualt constructor
        {
            cashBack = 0.0;
        }
            //constructors  
        public Executive(int newMemberId, string newEmailAddress, string newMembershipType, int newAnnualCost, double newCurrentMonthPurchases, double newCashBack): base(newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases) //another constructor
        {
            cashBack = newCashBack;
        }
        //TODO: add implement method
        public double GetSpecialOffer()//interface method
        {
            return annualCost * .50;
        }

        //abstract method
        public override double ICalculate() // this is the abstract method that all children must implement
        {
            return currentMonthPurchases * .05;
        }

        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {ICalculate()} Special Offer: ${GetSpecialOffer()}";
        }
        

    }//end class

}//end main 
