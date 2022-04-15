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
            Console.WriteLine("O - Open the user's list of restaurants, ");// user array (Alec's notes)
            Console.WriteLine("S - Save the user's list of restaurants");// save the array to the data file 
            Console.WriteLine("C - Add a restaurant and rating, ");//add a name to the array 
            Console.WriteLine("R - Print a list of all the restaurants and their rating, ");//Read a name from the array. {end here for the comp. check}
            Console.WriteLine("U - Update the rating for a restaurant, ");//Update a name in the array
            Console.WriteLine("D - Delete a restaurant");//Delete a name from the array.
            Console.WriteLine("Q: Quit the program.");// (last item for comp check)


            userChoiceString = Console.ReadLine();

            userChoice =(userChoiceString == "O" || userChoiceString== "o" ||//
                         userChoiceString == "S" || userChoiceString== "s" ||//
                         userChoiceString == "C" || userChoiceString == "c" ||//
                         userChoiceString == "R" || userChoiceString == "r" ||//
                         userChoiceString == "U" || userChoiceString== "u" ||
                         userChoiceString == "D" || userChoiceString == "d" || 
                         userChoiceString == "Q" || userChoiceString == "q");//   
        

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }//ends 2nd "do" which is to get valid input 
            while(!userChoice);
            //  TODO: If the option is is O or o then Open list of restaurants (names.txt) into the array of strings (nameArray)
                if (userChoiceString=="O" || userChoiceString=="o")
                {
                    Console.WriteLine("O/o");
                }
                
                //  TODO: If the option is is O or o then Open list of restaurants (names.txt) into the array of strings (nameArray)
                if (userChoiceString=="S" || userChoiceString=="s")
                {
                    Console.WriteLine("S/s");
                }
                //  TODO: If the option is is O or o then Open list of restaurants (names.txt) into the array of strings (nameArray)
                if (userChoiceString=="C" || userChoiceString=="c")
                {
                    Console.WriteLine("C/c");
                }

            //   TODO: If the option is is L or l then load (names.txt) into the array of strings (nameArray)
            //   TODO: Else if the option is a Q or q then quit the program                   <done> 
                else if (userChoiceString=="Q" || userChoiceString=="q")
                {
                  Console.WriteLine("Goodbye, thanks for your review");
                }
        
            


        }//ends the big "do" 
        while(!(userChoiceString=="Q"));    
    
    
    }//ends main   

  }//class program  

}//name space 