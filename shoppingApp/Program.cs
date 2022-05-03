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
        List<Member> regularMemberList = new List<Member>();

        // Add a couple of employees to the list to test
        //memberList.Add(new Member ("Alex", "al@bates.com", "Standard Member", 60, 5));
       //memberList.Add(new Member ("Katie", "woot@aol.org", "Regular Member" , 45, 99));

        regularMemberList.Add(new Regular ("Alex", "al@bates.com", "Regular Member", 60, 5.55));

        regularMemberList.Add(new Regular ("Katie", "woot@aol.org", "Regular Member" , 45, 99));


            // Print the list
            foreach (Member anMember in regularMemberList)
            {
                Console.WriteLine(anMember);
            }  // end foreach  
        }



        
    }//end class
}//end name space