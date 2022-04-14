using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i + " : " + myNumbers[i]);
      }
      
      for (int i = 0; i < 10; i++)
      {  
        Console.WriteLine("Please enter in a number: ");
        string numInput = Console.ReadLine(); 
        int userInput = Convert.ToInt16(numInput);
        myNumbers[i] = userInput; 
      }
      
      int minNum = myNumbers[1];//this is where we find the minimum 
      for (int i = 0; i < 10; i++)
      {
        if (myNumbers[i] < minNum)
        {
          minNum = myNumbers [i];
        }
        
      }//end of loop
      Console.WriteLine("This is your minimum number: " + minNum);
      





    }
  }
}