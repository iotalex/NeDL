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
                  
        bool userChoice;
        string userChoiceString;
        string[] nameArray = new string[10];//reserves 10 spaces to hold a string (memory)

    //Repeat main loop 
        do
        {     
          //  TODO: Get a valid input 
          do
          {
              //Initialize variables
              userChoice = false;      
              //   TODO: Provide the user a menu of options
              Console.WriteLine("What's your pleasure?");
              Console.WriteLine("L: Load the data file into an array.");// 4th) TODO: Load the single text file into the program, store 4 lines 
              Console.WriteLine("S: Save the array to the data file");// 5th) Store the current employee information in the text file 
              Console.WriteLine("C: Add a name to the array."); //2nd) TODO: add an employee 
/*you here*/ Console.WriteLine("R: Read a name from the array.");// 1st) TODO: Print a list of all Employees inlcuding calculated bonus
              Console.WriteLine("Q: Quit the program."); //3rd) done? 
              
                //  reference guide:   https://www.w3resource.com/csharp-exercises/file-handling/index.php#editorr
              //   TODO: Get a valid user option (valid means its on the menu)
              userChoiceString = Console.ReadLine();
             
              userChoice = (userChoiceString== "L" ||  userChoiceString=="l" ||      
                            userChoiceString == "S" || userChoiceString == "s" ||  
                            userChoiceString == "C" || userChoiceString == "c" ||    
                            userChoiceString == "R" || userChoiceString == "r" ||   
                            userChoiceString == "Q" || userChoiceString == "q");  
                      
                if(!userChoice)
                {
                  Console.WriteLine("Please enter a valid option");
                }    
            }//ends the second "do" which is to get "valid input"
            while (!userChoice);

            Console.WriteLine("Start of the application.");  //start of array or start of reading file 

                    EmployeeSalaried alex = new EmployeeSalaried(/* TODO: Input information for alex */);
                    EmployeeHourly stephen = new EmployeeHourly(/* TODO: Input information for stephen */);

                    // TODO: Add objects to the array

                    // TODO: Iterate through the array

                    // TODO: Output information to console (name, pay, bonus)

        //   TODO: Option "L" The text file stores four lines for each employee including last name, first name, employee type  
                 // AND hourly rate or salary (depending on employee type - Hourly or Salary)
                if (userChoiceString=="L" || userChoiceString=="l")
                {
                  
                }//end using    

        //   TODO: Else if the option is an S or s then store the array of strings into the text file  (DONE 4-14-22)##6 on website
                else if (userChoiceString=="S" || userChoiceString=="s")
                {
                  //equivilent of saying "CTR + S" 
                }
        //   TODO: Else if the option is a C or c then add a name to the array (if there's room; eg. array of 10) 
                else if (userChoiceString =="C" || userChoiceString =="c") 
                {
                  //typicall if statements 
                }
        // TODO: Prints a list of all Employees including calculated bonus
              //TODO: need to list array within text.file???
                else if (userChoiceString=="R" || userChoiceString=="R") //make changes, so they give you a name 
                
                {
                for(int i = 0; i < nameArray.Length; i++)//start with index of 0 
                  {
                    if(!(nameArray[i] == null))//check to see if it's null, !-say's that it's "not"; as long as I have something here, print it; null=I don't want to print it
                      {
                      Console.WriteLine(nameArray [i]);
                      //Console.WriteLine(ratingArray[i]);
                      }
                  }
                }








        //   TODO: Else if the option is a Q or q then quit the program                
                else if (userChoiceString=="Q" || userChoiceString=="q")
                {
                  Console.WriteLine("Goodbye, auf wiedersehen");
                }
      }// ends the big "do"
            while(!(userChoiceString=="Q"));
                    
                    
                  
                }
 
    }//end class
}//end main 




    