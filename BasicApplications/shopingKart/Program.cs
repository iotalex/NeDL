using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    { //number of items // needs to say item 1, item 2, // can fix this later, but range is only below **5*** **fix**
      Console.WriteLine("Please enter the number of items");
      string numItems = Console.ReadLine();
      int numItemsInt = Convert.ToInt16(numItems);  
   //prompts user to ask for cost of item 
      for (int item = 0; item < 5; item++)
      {
        Console.WriteLine("Enter cost of item: " + (item + 1));
        
        
        //int kartTotal = 0; 
        
        string numShoppingKart = Console.ReadLine();
        int itemCost = Convert.ToInt32(numShoppingKart); //and if I wanted to ensure below a 100; can use a "while loop" after this line
      //todo: capture the input and add it all up  
            //todo: add up the integers entered from user

        Console.WriteLine("Enter the cost of time ");
            //ensures user enters integer within ranges 0-100

        while (itemCost < 0 || itemCost > 100)
        {
          Console.WriteLine("hey, please enter a number between zero or 100");
          numShoppingKart = Console.ReadLine();
          itemCost = Convert.ToInt32(numItems);
        }//end of while loop, for ranges 0-100

      

      //sumKart = numShoppingKart; //maybe this is how? Ask Alec, is this how the reaed the console? 

      }

      
        
  //compute == numItems + 1
      
      //end for lopp for item total


   

        


    }//end of static void 



    
  }


}


//this is like where we computer, because it only read the line below if it doesn't compute :D
      //this is like my second light bulb, basically this is how you compute to ask for the number of items,
      //and this gives you an orfice to enter "said" items