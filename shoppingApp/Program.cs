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

        memberList.Add(new Executive (2001, "bread@beads.org", "Executive Member" , 150, 500.00));
        memberList.Add(new Executive (2002, "lumber@truss.biz", "Executive Member" , 300, 1000.01));

        memberList.Add(new NonProfit (3001, "susan@daycare.edu", "Non-Profit Member" , 200, 1300.01, 10.5));
        memberList.Add(new NonProfit (3002, "robert@church.edu", "Non-Profit Member" , 250, 1300.01, 10.5));

            // Print the list
            foreach (Member anMember in memberList)
            {
                Console.WriteLine(anMember);
            }  // end foreach  
        }



        
    }//end class
}//end name space