using System;

namespace AboveAverage // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        //store array
        int[] myNumArray = new int[5];

        
        for (int index = 0; index < 5; index++)//copy the loop; create the array values (get's it from user)
        {
            
            myNumArray[index] = Convert.ToInt16(Console.Read());//changed to "read," stays on one thing

            
        }//end of forloop
        
        for (int index = 0; index < 5; index++)
        {
            
            Console.WriteLine(myNumArray[index]);
            
        }//end of forloop
        
        
        // calculat array; 
        
        
        //add socre; find the mean, and then divide the total by the mean (number of scores greater than the mean)
        
        
        
        
        }//end static void 

    }//end class program 
}






