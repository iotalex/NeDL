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

            // Print the list
            foreach (Member anMember in memberList)
            {
                Console.WriteLine(anMember);
            }  // end foreach  
        
        


       



        }//end static 



        
    }//end class
}//end name space