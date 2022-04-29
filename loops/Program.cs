using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter how many feet");
        string numFeet = Console.ReadLine(); 
        int feetLoops = Convert.ToInt32(numFeet);
    
      while (feetLoops <= 0)
      {
        Console.WriteLine("hey, please enter a positive number");
        numFeet = Console.ReadLine(); 
        feetLoops = Convert.ToInt32(numFeet);
      }
        int inches = feetLoops*12; 
        Console.WriteLine("number of inches is:" + " " + inches);
    }
  }
}