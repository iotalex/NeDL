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

        // Add a couple of employees to the list to test
        //memberList.Add(new Member ("Alex", "al@bates.com", "Standard Member", 60, 5));
       //memberList.Add(new Member ("Katie", "woot@aol.org", "Regular Member" , 45, 99));

        memberList.Add(new Regular (1001, "al@bates.com", "Regular Member", 50, 500.00, 50.23));

        memberList.Add(new Regular (1002, "woot@aol.com", "Regular Member" , 75, 250.00, 50.23));

        //memberList.Add(new Executive (2001, "bread@beads.org", "Executive Member" , 150, 1250.00, 100));
        //memberList.Add(new Executive (2001, "lumber@truss.biz", "Executive Member" , 150, 2250.00, 10.5));


            // Print the list
            foreach (Regular anMember in memberList)
            {
                Console.WriteLine(anMember);
            }  // end foreach  
        }



        
    }//end class
}//end name space