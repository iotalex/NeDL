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
             // Now get lower-case version
             userChoiceString = userChoiceString.ToLower();

              userChoice = (userChoiceString== "L" ||  userChoiceString=="l" ||   //done 1.0    
                            userChoiceString == "S" || userChoiceString == "s" ||  //done 
                            userChoiceString == "C" || userChoiceString == "c" ||  //done (solo)//not working  
                            userChoiceString == "R" || userChoiceString == "r" ||   //done
                            userChoiceString == "U" || userChoiceString == "u" ||    //in progress  
                            userChoiceString == "D" || userChoiceString == "d" ||   
                            userChoiceString == "Q" || userChoiceString == "q");    //done [for sure done]
                      
                if(!userChoice)
                {
                  Console.WriteLine("Please enter a valid option");
                }    
            }//ends the second "do" which is to get "valid input"
            while (!userChoice);

        //   TODO: If the option is is L or l then load (names.txt) into the array of strings (nameArray)  (not DONE 4-13-22)
                if (userChoiceString=="L" || userChoiceString=="l")
                {
                  using (StreamReader sr = File.OpenText("names.txt"))//this is the name of the "new" file created 
                    {
                    int index = 0;
                    string s;  
                    //while liine of file I'm reading has content (aka isn't null)
                    //push line contents to element of array 
                    while ((s = sr.ReadLine()) != null)
                    {
                      nameArray[index] = s;
                      index++;
                    }           
                  }//end while 
                  for(int index = 0; index < nameArray.Length; index++)
                  {
                    if(nameArray[index] != null)
                    Console.WriteLine(nameArray[index]); 
                    //load the names, display names of the array ; !null 
                  }
                }//end using    

        //   TODO: Else if the option is an S or s then store the array of strings into the text file  (DONE 4-14-22)##6 on website
                else if (userChoiceString=="S" || userChoiceString=="s")
                {
                    //create a file 
                    System.IO.File.WriteAllLines("names.txt", nameArray); //equivilent of saying "CTR + S" 
                }
        //   TODO: Else if the option is a C or c then add a name to the array (if there's room; eg. array of 10) 
        // need to do an array check "null" in screen shots //(note: user has to save manually)
                else if (userChoiceString =="C" || userChoiceString =="c") 
                {
                  Console.WriteLine("Enter a new name");
                  TextInfo tiVar1 = new CultureInfo("en-US", false).TextInfo;
                  string nameToAdd = tiVar1.ToTitleCase(Console.ReadLine());                                
                for (int i = 0; i < nameArray.Length; i++)
                  {
                  if (nameArray[i] == null || nameArray[i] == "")
                    {
                      nameArray[i] = nameToAdd;
                      break;
                    }
                  }//end if
                }
        // "R" needs to read the name from the array 
                else if (userChoiceString=="R" || userChoiceString=="R") //make changes, so they give you a name 
                //tell user name found or name not found 
                {
                Console.WriteLine("Please enter a name: "); //please enter a name 
                //read that number from user
                string userInput = Console.ReadLine();
                bool found = false;
                 for(int index = 0; index < nameArray.Length; index++)
                  {
                    if(nameArray[index] == userInput)
                    {
                      Console.WriteLine("User found");
                      found = true;
                    }
                    //load all the names, display names of the array ; !null
                  }
                  if(found == false)//basically is "found" is still false, I didn't find anything 
                  {
                    Console.WriteLine("User not found");
                  }
                }

        //   TODO: "adding quotes here" Else if the option is a U or u then update a name in the array (if it's there) 
                //Console.WriteLine("U: Update a name in the array.");
                else if (userChoiceString=="U" || userChoiceString=="u")
                //prompt user for which one 
                {
                  // Prompt the user for which index to update
                  Console.WriteLine("Which name, 1-10, would you like to edit? ");
                  string userInputReplace = Console.ReadLine();
                  // Convert the string value to an integer index value
                  int userInputReplaceInt = Convert.ToInt16(userInputReplace);
                  // Get the value from the array to replace
                  string replaceName = nameArray[userInputReplaceInt - 1];
                  //prompt "what would you like to update the name to? 
                  Console.WriteLine("Please enter the new name: ");
                  //delete name from the array (1-10?)
                  string newUserName = Console.ReadLine();
                  nameArray[userInputReplaceInt - 1] = newUserName;
                  //get the number from the user
                  //Write name in the array (1-10?)
                }
                //display that input array (which is name 1-10)
                      
        //   TODO: Elese if the option is a D or d then delete the name in the array (if it's there)                <done>
               else if (userChoiceString=="D" || userChoiceString=="d")
               {
                using (StreamReader sr = File.OpenText("names.txt"))
                {
                  string deleteFile = @"names2.txt";
			            Console.Write("\n\n Remove a file from the disk (at first create the file ) :\n");	
			            Console.Write("--------------------------------------------------------------\n");				
                  // Delete the file if it exists.
                  if (File.Exists(deleteFile))
                  {
                      File.Delete(deleteFile);
                  Console.WriteLine(" The file {0} deleted successfully.\n\n",deleteFile);
                  }
                  else
                  {
                  Console.WriteLine(" File does not exist");
                  Console.ReadKey();
                  }          
                }
               }
        //   TODO: Else if the option is a Q or q then quit the program                   <done> 
                else if (userChoiceString=="Q" || userChoiceString=="q")
                {
                  Console.WriteLine("Goodbye, auf wiedersehen");
                }
      }// ends the big "do"
       while(!(userChoiceString=="Q"));
           
    } //ends main

    private static string GetUserMenuChoice()
    {
      bool userChoice = false;
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
             // Now get lower-case version
             userChoiceString = userChoiceString.ToLower();

              userChoice = (userChoiceString== "L" ||  userChoiceString=="l" ||   //done 1.0    
                            userChoiceString == "S" || userChoiceString == "s" ||  //done 
                            userChoiceString == "C" || userChoiceString == "c" ||  //done (solo)//not working  
                            userChoiceString == "R" || userChoiceString == "r" ||   //done
                            userChoiceString == "U" || userChoiceString == "u" ||    //in progress  
                            userChoiceString == "D" || userChoiceString == "d" ||   
                            userChoiceString == "Q" || userChoiceString == "q");    //done [for sure done]
                      
                if(!userChoice)
                {
                  Console.WriteLine("Please enter a valid option");
                }    
            }//ends the second "do" which is to get "valid input"
            while (!userChoice);
    }
  } //class program 
} //name space