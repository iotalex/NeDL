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
        memberList.Add(new Member ("Enge", "Alec", "H", 6, 5));

            // Print the list
            foreach (Member anMember in memberList)
            {
                Console.WriteLine(anMember);
            }  // end foreach  
        }



        
    }//end class
}//end name space