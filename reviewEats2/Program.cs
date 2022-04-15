﻿using System;
using System.Globalization;

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
            Console.WriteLine("Please select the following options: ");
            Console.WriteLine("O - Open the user's list of restaurants, ");// user array (Alec's notes)
            Console.WriteLine("S - Save the user's list of restaurants");// save the array to the data file 
            Console.WriteLine("C - Add a restaurant and rating, ");//add a name to the array 
            Console.WriteLine("R - Print a list of all the restaurants and their rating, ");//Read a name from the array. {end here for the comp. check}
            Console.WriteLine("U - Update the rating for a restaurant, ");//Update a name in the array
            Console.WriteLine("D - Delete a restaurant");//Delete a name from the array.
            Console.WriteLine("Q: Quit the program.");// (last item for comp check)


            userChoiceString = Console.ReadLine();

            userChoice =(userChoiceString == "O" || userChoiceString== "o" ||//done 
                         userChoiceString == "S" || userChoiceString== "s" ||//
                         userChoiceString == "C" || userChoiceString == "c" ||// in progress 
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
            //  TODO: If the option is "O" or "o" then Open list of restaurants (names.txt) into the array of strings (nameArray)
                if (userChoiceString=="O" || userChoiceString=="o")
                {
                using (StreamReader sr = File.OpenText("names.txt"))//this is the name of the "new" file created 
                    {
                    int index = 0;
                    string s;  
                    //while liine of file I'm reading has content (aka isn't null)
                    //push line contents to element of array 
                    while ((s = sr.ReadLine()) != null)
                    {
                      eateryArray[index] = s;
                      index++;
                    }           
                  }//end while 
                  for(int index = 0; index < eateryArray.Length; index++)
                  {
                    if(eateryArray[index] != null)
                    Console.WriteLine(eateryArray[index]); 
                    //load the names, display names of the array ; !null 
                  }
                }
                //  TODO: If the option is is S or s save the user's list of restaurants/ store the array into a text file
                if (userChoiceString=="S" || userChoiceString=="s")
                //create a file 
                {
                //create a file 
                    System.IO.File.WriteAllLines("names.txt", eateryArray); //equivilent of saying "CTR + S" 
                }







                //  TODO: If the option is is C or c add a restuarent name and rating --i.e. add a name & rating to the array 
                if (userChoiceString=="C" || userChoiceString=="c")
                {
         
                //prompt user to enter restaurant name: 
                Console.WriteLine("Enter restaurant name");
                  TextInfo tiVar1 = new CultureInfo("en-US", false).TextInfo;
                  string nameToAdd = tiVar1.ToTitleCase(Console.ReadLine());
                   for (int index = 1; index < eateryArray.Length; index++)
                  {
                    if (eateryArray[index] == null || eateryArray[index] == "")
                        {
                        eateryArray[index] = nameToAdd;
                        break;
                        }
                    
                  }//end if                             
             

                //read last n number of lines of a file.
                string fileName = @"mytest.txt"; 
                string[] ArrLines ;
                int ratingUserInputInt, i=0;
                //prompt user to enter rating number 0-5
                Console.Write(" Please enter restaurant rating (0-5): ");
                ratingUserInputInt = Convert.ToInt16(Console.ReadLine());
                ArrLines=new string[ratingUserInputInt];

                {
                Console.Write("-----------------------------------------------\n"); 
                }
                //array to collect review ratings information 
           //        int[] myNumbers = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; 
            //        for (i = 1; i < 11; i++)
            //        {
            //            Console.WriteLine("Please enter rating for each restaurant " + "{name of eatery goes here" + " " + i);//this is where input restaurant 1, reastaurant 2, restaurant 3...
            //            string numInput = Console.ReadLine();
            //            int userInput1 = Convert.ToInt16(numInput);
            //            myNumbers[i] = userInput1; 
             //       }
                   
                
                
                
                }




                
                //  TODO: If the option is is R or r PRINT a LIST of all the restaurants and their rating; i.e. Read a name from the array  
                //"R{end here for the comp. check} Friday 
                else if (userChoiceString=="R" || userChoiceString=="R") //make changes, so they give you a name 
                //tell user name found or name not found 
                {
                Console.WriteLine("R/r");              
                }


                //  TODO: If the option is is U or u UPDATE the RATING for the restaurant; i.e. update the name in the array 
                //Monday 
                if (userChoiceString=="U" || userChoiceString=="u")
                {
                    Console.WriteLine("U/u");
                }
                //  TODO: If the option is is D or d DELETE a restaurant; i.e.//Delete the name from the array 
                //Monday ***********I'm borrowing this, so it works 
                //"D
                if (userChoiceString=="D" || userChoiceString=="d")
                {
                 Console.WriteLine("D/d");
                }
            
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