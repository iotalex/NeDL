using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter fahrenheit in two digits");//user prompted to enter Fahrenheight 
        string celsiusName = Console.ReadLine();
        Console.WriteLine(celsiusName);
        int fahrenheit = Convert.ToInt16(celsiusName);
        
        int sum1 = fahrenheit;
        int sum2 = sum1 + 32;
        int sum3 = sum2 + 8; 
        double sum4 = sum3 * 1.8; //"double sum...", this lets me use a decimal  

        Console.WriteLine("Fahrenheight to Celsius is:" + " " + sum4);

    }//Plan: 
//Consoles promps user to input number
      //Number entered is then converted to farhenhieght using simple math
//Console outputs the number 
      //Requirements: two whole numbers, positive number
// input * 1.8 + 32 = desired output from Fahrenheight to Celsius 

    

  }
}