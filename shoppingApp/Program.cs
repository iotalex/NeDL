using System;
using System.Collections;
using System.Collections.Generic;   // needed for Lists


namespace ShopKo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Create a list of Employees
        List<Member> memberList = new List<Member>();

        memberList.Add(new Regular (1001, "al@bates.com", "Regular", 50, 14000, 50.23));

        memberList.Add(new Regular (1002, "woot@aol.com", "Regular" , 75, 250.00, 50.23));

        memberList.Add(new Executive (2001, "bread@beads.org", "Executive" , 150, 500.00));
        memberList.Add(new Executive (2002, "lumber@truss.biz", "Executive" , 300, 1000.01));

        memberList.Add(new NonProfit (3001, "susan@daycare.edu", "Non-Profit" , 200, 1300.01));
        memberList.Add(new NonProfit (3002, "robert@church.edu", "Non-Profit" , 1800, 1300.01));

        memberList.Add(new NonProfit (4001, "justin@shopko.com", "Corporate" , 750, 10300.01));
        memberList.Add(new NonProfit (4002, "justice@shopko.com", "Corporate" , 750, 15000.01));

        bool userChoice;
        string userChoiceString;
        
    //Repeat main loop 
        do
        {     
          //  TODO: Get a valid input 
          do
          {

              //Initialize variables
              
              userChoice = false;
              
              //   TODO: Provide the user a menu of options

              Console.WriteLine("What's your pleasure?");
              Console.WriteLine("C: Create a new member and add to the membership list.");
             
              Console.WriteLine("Q: Quit the program.");
              
                //  reference guide:   https://www.w3resource.com/csharp-exercises/file-handling/index.php#editorr
              //   TODO: Get a valid user option (valid means its on the menu)
              userChoiceString = Console.ReadLine();
              
             
              userChoice = (userChoiceString== "C" || userChoiceString == "c" ||  
                         
                            userChoiceString == "Q" || userChoiceString == "q");  
                      
                if(!userChoice)
                {
                  Console.WriteLine("Please enter a valid option");
                }    
            }//ends the second "do" which is to get "valid input"
            while (!userChoice);

        //   TODO: C - create new member, make a list to check membership ID 
                if (userChoiceString=="C" || userChoiceString=="c")
                {
                // Print the list
            foreach (Member anMember in memberList)
            {
                Console.WriteLine(anMember);
            }  // end foreach  
                }//end using "C" 








        //   TODO: Else if the option is an S or s then store the array of strings into the text file  (DONE 4-14-22)##6 on website
                else if (userChoiceString=="S" || userChoiceString=="s")
                {
                  //equivilent of saying "CTR + S" 
                }
        
        //   TODO: Else if the option is a Q or q then quit the program                
                else if (userChoiceString=="Q" || userChoiceString=="q")
                {
                  Console.WriteLine("Goodbye, auf wiedersehen");
                }
      }// ends the big "do"
       while(!(userChoiceString=="Q"));


       



        }//end static 



        
    }//end class
}//end name space