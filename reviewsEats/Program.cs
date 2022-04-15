using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        bool userChoice;
        string userChoiceString;
        string[] eateryArray = new string[10]; //reservce 10 spaces to hold string (memory)
   //Repeat main loop  
    do
    {
        do
        {
        //Initialize variables
        userChoice = false;
        //   TODO: Provide the user a menu of options
        Console.WriteLine("Please enter your Good Eat's review (0-5): ");

        userChoiceString = Console.ReadLine();

        userChoice =(userChoiceString == "A" ||  userChoiceString=="a" ||
                    userChoiceString == "B" ||  userChoiceString=="b" );
    

        if (!userChoice)
        {
            Console.WriteLine("Please enter a valid option");
        }

        }//ends 2nd "do" 
        
        while(!userChoice);
    
    }//ends the big "do" 
    
    while(!(userChoiceString=="Q"));    
    
    
    }//ends static main  


  }//main program 
}