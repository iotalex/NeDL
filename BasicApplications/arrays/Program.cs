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
      
      //do another loop, get 10 numbers form the user and put them in the array 
      
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("please enter a number: ");
        string numInput = Console.ReadLine();
        int userInput = Convert.ToInt16(numInput);
        myNumbers[i] = userInput; 
      }

      int minNum = myNumbers[1];//this is where you find your minimum 
      for (int i = 0; i < 10; i++)
      {
        if (myNumbers[i] < minNum)
        {
          minNum = myNumbers[i];
        }
        
      }//end of forloop
      Console.WriteLine("the minimum number or smallest entered number is: " + minNum);


      int maxNum = myNumbers[0]; //this is where you find your max
      for (int i = 0; i < 10; i++)
      {
        if (myNumbers[i] > maxNum)
        {
          maxNum = myNumbers[i];
        }
        
      }//end of forloop
      Console.WriteLine("the maximum or largest entered number is: " + maxNum);

      int totalArray = myNumbers[0];
      for (int i = 1; i < 10; i++)
      {
        totalArray = totalArray + myNumbers[i];
      }
      Console.WriteLine("The total numbers are: " + totalArray);

    }
  }
}