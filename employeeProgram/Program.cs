using System;                    //PRESENTATION TIER, CRUD APP. 
/*
	(Start here) 1. R - Print a list of all the employees including their calculated bonus, (r will print employee and show calculate bonus; 
create a bonus calculate function—use polymorphism [two string]); will call depending on type of employee they are. 
*/
namespace MyWorkApplication
{
    class Program  
    {
      // TODO: Where is the data going to be stored within the application?
      // TODO: Create an array of Employee[]
      static void Main(string[] args)      //inside: reference other clases (4-22-22) *keep very very small* 
                {
                    Console.WriteLine("Start of the application.");

                    EmployeeSalaried alex = new EmployeeSalaried(/* TODO: Input information for alex */);
                    EmployeeHourly stephen = new EmployeeHourly(/* TODO: Input information for stephen */);

                    // TODO: Add objects to the array

                    // TODO: Iterate through the array

                    // TODO: Output information to console (name, pay, bonus)
                }
 
    }//end class
}//end main 




    