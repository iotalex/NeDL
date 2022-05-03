using System;

namespace ShopKo // Note: actual namespace depends on the project name.
{
    class Executive : Member, IGetSpecialOffer, IGetCashBack //abstract class, objects can't be instantiated (objects of this type can't be created)    
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
        //TODO: add implement cash back method
        public double GetCashBackExecutive()//interface method
        {
            if(currentMonthPurchases < 1000);
            {
              return ((1000 * .02) + currentMonthPurchases);  
            }
            
        }
        

        //abstract method
        public override double ICalculate() // abstract <2% for <1000; % cash back for montlhy purchases >1000
        { 
            return currentMonthPurchases * .02;
        }

            /*

if(currentMonthPurchases < 1000);
            {
              return 169;  
            }

 return (1000 * .02) + currentMonthPurchases;
                
                if (currentMonthPurchases <= 1000)
                    return((currentMonthPurchases * .05) - 1000);
                
            */


            //return output

            //return currentMonthPurchases * .02;//standard cashback          




        

        public override string ToString()
        {
            return base.ToString() + $" || Cashback: {GetCashBackExecutive()} Special Offer: ${GetSpecialOffer()}";
        }
        

    }//end class

}//end main 
