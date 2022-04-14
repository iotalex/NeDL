using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    //strings below are there to prompt user to ask for amount for each currency. 
    Console.WriteLine("Enter number of penny's, then press enter");
    string pennys = Console.ReadLine();
    
    Console.WriteLine("Enter number nickels, then press enter");
    string nickels = Console.ReadLine(); 

    Console.WriteLine("Enter number of dimes, then press enter");
    string dimes = Console.ReadLine(); 
  
    Console.WriteLine("Enter number of quarters, then press enter");
    string quarters = Console.ReadLine(); 

    //logic that converts whole feet to whole inches   
    int pennysDouble = Convert.ToInt32(pennys) * 1; // * * * ;
    int nickelsDouble = Convert.ToInt32(nickels) * 5;
    int dimesDouble = Convert.ToInt32(dimes) * 10;
    int quartersDouble = Convert.ToInt32(quarters) * 25;
    //this is where we add all the amounts together 
    double totalMoney = (pennysDouble + nickelsDouble + dimesDouble + quartersDouble)/100.0;
    
    Console.WriteLine("This is how much you have in your piggy bank:" + " " + "$" + totalMoney);
    }
  }
} 