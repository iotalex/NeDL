using System;
using System.Globalization;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        bool userChoice;
        string userChoiceString;
        
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
              Console.WriteLine("L: Load the data file into an array.");
              Console.WriteLine("S: Save the array to the data file");
              Console.WriteLine("C: Add a name to the array.");
              Console.WriteLine("R: Read a name from the array.");
              Console.WriteLine("U: Update a name in the array.");
              Console.WriteLine("D: Delete a name from the array.");
              Console.WriteLine("Q: Quit the program.");
              
                //  reference guide:   https://www.w3resource.com/csharp-exercises/file-handling/index.php#editorr
              //   TODO: Get a valid user option (valid means its on the menu)
              userChoiceString = Console.ReadLine();
              
             
              userChoice = (userChoiceString== "L" || userChoiceString == "l" ||  
                            userChoiceString == "S" || userChoiceString == "s" ||  
                            userChoiceString == "C" || userChoiceString == "c" ||    
                            userChoiceString == "R" || userChoiceString == "r" ||   
                            userChoiceString == "U" || userChoiceString == "u" ||      
                            userChoiceString == "D" || userChoiceString == "d" ||   
                            userChoiceString == "Q" || userChoiceString == "q");  
                      
                if(!userChoice)
                {
                  Console.WriteLine("Please enter a valid option");
                }    
            }//ends the second "do" which is to get "valid input"
            while (!userChoice);

        //   TODO: If the option is is L or l then load (names.txt) into the array of strings (nameArray)  (not DONE 4-13-22)
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
        // "R" needs to read the name from the array 
                else if (userChoiceString=="R" || userChoiceString=="R") //make changes, so they give you a name 
                
                {
                
                }

        //   TODO: "adding quotes here" Else if the option is a U or u then update a name in the array 
                //Console.WriteLine("U: Update a name in the array.");
                else if (userChoiceString=="U" || userChoiceString=="u")
                //prompt user for which one 
                {

                }
                      
        //   TODO: Elese if the option is a D or d then delete the name in the array            
               else if (userChoiceString=="D" || userChoiceString=="d")
               {
                
               }
        //   TODO: Else if the option is a Q or q then quit the program                
                else if (userChoiceString=="Q" || userChoiceString=="q")
                {
                  Console.WriteLine("Goodbye, auf wiedersehen");
                }
      }// ends the big "do"
       while(!(userChoiceString=="Q"));
           
    } //ends main
      

  } //class program 
} //name space