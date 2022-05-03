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
        public override double ICalculate() // abstract <2% for <1000; % cash back for montlhy purchases >1000
        {
            int x;
            int y;
            //TODO: if statements for <2% and stop at 1000;
            x = 5;
            //TODO: if statements for <5% and start at 1000 to infinity; 
            y = 5;
            
            

            //return output
            return (x + y);
            //return currentMonthPurchases * .02;//standard cashback
        }

        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {ICalculate()} Special Offer: ${GetSpecialOffer()}";
        }
        

    }//end class

}//end main 
