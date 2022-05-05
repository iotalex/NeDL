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
            userChoice = false;

            Console.WriteLine("What's your pleasure?");
            Console.WriteLine("R: Read list.");
            Console.WriteLine("C: Add new member.");
            Console.WriteLine("U: Update current member.");
            Console.WriteLine("D: Delete a current member.");

            
            Console.WriteLine("Q: Quit the program.");

            userChoiceString = Console.ReadLine() ?? "";//?? if userstring is null, asign to next userstring 

            userChoice = (userChoiceString.ToUpper()== "C" || 
                        userChoiceString.ToUpper()== "R" ||
                        userChoiceString.ToUpper()== "U" ||
                        userChoiceString.ToUpper()== "D" ||     
                        
                        userChoiceString.ToUpper()== "Q");  
                    
                if(!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }    
            }//ends the second "do" which is to get "valid input"
            while (!userChoice);
    //   TODO: U - UPDATE new member
            if (userChoiceString=="U" || userChoiceString=="u")
            {
                bool found = false;
                Console.WriteLine("Please enter member ID# to update: ");
                string findMemberId = Console.ReadLine();//gets user input, asks for ID#
                found = false;//true or false 
                for (int index = 0; index < memberList.Count; index++)//searches the list 
                {
                    if ((memberList[index].memberId == Convert.ToInt32(findMemberId)))
                    {
                        Console.WriteLine("Member found. Please enter new email");
                        string newEmail = Console.ReadLine();
                        found = true;
                        memberList[index].emailAddress= newEmail; 
                    }
                }  // end foreach   
                
                if (!found)
                    Console.WriteLine("Member not found");
               
            }//end using "C" 
    //   TODO: D - delete new member
            if (userChoiceString=="D" || userChoiceString=="d")
            {
                bool found = false;
                Console.WriteLine("Please enter member ID# to delete: ");
                string findMemberId = Console.ReadLine();//gets user input, asks for ID#
                found = false;//true or false 
                for (int index = 0; index < memberList.Count; index++)//searches the list 
                {
                    if ((memberList[index].memberId == Convert.ToInt32(findMemberId)))
                    {         
                        memberList.RemoveAt(index);
                        found = true;
                    }
                }  // end foreach
                if(found)
                    Console.WriteLine("Member found & removed from system");
                
                if (!found)
                    Console.WriteLine("Member not found");
           
            }//end using "D" 
    
    //   TODO: C - create new member
            if (userChoiceString=="C" || userChoiceString=="c")
            {
                //once valid, set the newMemberID to the new object memberID
                string newMembershipType = InputUtilities.PromptForStringInput("Please enter membership type: ");
                int newMemberId = InputUtilities.PromptForIntInput("Please enter ID#: ");//TODO: verify ID
                //TODO: loop through member list and verify no member has newMemberID
                bool found = false;
                found = false;

                for(int index = 0; index < memberList.Count; index++)
                {
                if ((memberList[index].memberId == newMemberId))
                    {
                    found = true;
                    }
                }                       
                if (found)
                Console.WriteLine("Already used or duplicate ID#!");
                else
                {
                Console.WriteLine("Vaid please continue, ID#!");//want user to continue
                string newEmailAddress = InputUtilities.PromptForStringInput("Please enter email address: ");
                int newAnnualCost = InputUtilities.PromptForIntInput("Please enter annual cost: ");//left off here 
                double newCurrentMonthPurchases = InputUtilities.PromptForDoubleInput("Please enter amount purchases: ");

                //if new membership type = regular
                switch(newMembershipType)
                    {
                    case "Regular":
                    case "regular":
                    memberList.Add(new Regular (newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases, 0));
                    Console.WriteLine("Regular member added! Printing out new list.");
                    break;
                    case "Executive":
                    case "executive":
                    memberList.Add(new Executive (newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases));
                    Console.WriteLine("Executive member added! Printing out new list.");
                    break;
                    case "Non-profit":
                    case "non-profit":
                    memberList.Add(new NonProfit (newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases));
                    Console.WriteLine("Non-Profit member added! Printing out new list.");
                    break;
                    case "Corporate":
                    case "corporate":
                    memberList.Add(new Corporate (newMemberId, newEmailAddress, newMembershipType, newAnnualCost, newCurrentMonthPurchases));
                    Console.WriteLine("Corporate member added! Printing out new list.");
                    break;
                    }//end switch case ID lookup/add new account

                foreach (Member anMember in memberList)
                Console.WriteLine(anMember);
                }//end else statement 
           
            }//end using "C" 


        //   TODO: Else if the option is an S or s then store the array of strings into the text file  (DONE 4-14-22)##6 on website
                else if (userChoiceString=="R" || userChoiceString=="r")
                {
                  foreach (Member anMember in memberList)
                            Console.WriteLine(anMember);
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

