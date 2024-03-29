﻿using System;

namespace HelloWorld
{
  class Program
  {
        static void Main(string[] args)
        {
            bool userChoice;
            string userChoiceString;
            //string[] eateryArray = new string[25]; //reserves 25 spaces to hold string (memory)
            string[] nameArray = new string[25];//hold the name of a restaurant "O"  
            string[] ratingArray = new string[25];//hold the rating of a restuarant "O" 
    
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
            Console.WriteLine("S - Save the user's list of restaurants");// prints names from sys-memory into text.txt file 
            Console.WriteLine("C - Add a restaurant and rating, ");//adds a name/rating to the array 
            Console.WriteLine("R - Print a list of all the restaurants and their rating, ");//Read a name from the array. {end here for the comp. check}
            Console.WriteLine("U - Update the rating for a restaurant, ");//Update a name in the array
            Console.WriteLine("D - Delete a restaurant");//Delete a name from the array.
            Console.WriteLine("Q: Quit the program.");// (last item for comp check)


            userChoiceString = Console.ReadLine();

            userChoice =(userChoiceString == "O" || userChoiceString== "o" ||//done, 1.0
                         userChoiceString == "S" || userChoiceString== "s" ||//done, glitchy, put zeros 
                         userChoiceString == "C" || userChoiceString == "c" ||//done 1.0 
                         userChoiceString == "R" || userChoiceString == "r" ||//done 1.0
                         userChoiceString == "U" || userChoiceString==  "u" ||//with mentor if time 
                         userChoiceString == "D" || userChoiceString == "d" ||
                         userChoiceString == "Q" || userChoiceString == "q");//done/tested working   
        

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }//ends 2nd "do" which is to get valid input 
            while(!userChoice);
            //  TODO: If the option is "O" or "o" then Open list of restaurants (names.txt) into the array of strings (nameArray)
                if (userChoiceString=="O" || userChoiceString=="o")
                //below is the code that's going to read the file
                using (StreamReader sr = File.OpenText("names.txt"))//this is the name of the "new" file created 
                    {
                      int index = 0;
                      string name = " ";
                      string rating = " "; 
                      
                      // Reading a line from the file
                      while ((name = sr.ReadLine()) != null)//reads the first line, then loops into the next line (!= null-as long as something is here, it will read it )
                      {
                        nameArray[index] = name;//puts the line read in the index (puts it in my nameArray)
                        Console.WriteLine(name);///taking the names (values) from file & adding them to arrays 
                        rating = sr.ReadLine();//still in my loop, this reads the next line in my data file 
                        ratingArray[index] = rating;// puts the line read in the (puts ratingArray)
                        Console.WriteLine(rating);///taking the names (values) from file & adding them to arrays 
                        index++; // Increment the index, so you move to the next item in the array
                      }           
                    }//end while 
                //  TODO: If the option is is S or s save the user's list of restaurants/ store the array into a text file
                if (userChoiceString=="S" || userChoiceString=="s")
                //create a file 
                {
                      // Delete the file if it exists.
                    if (File.Exists("names.txt"))
                    {
                        File.Delete("names.txt");//if the file exists, this tell it to essentially "overwrite file" 
                    }
                                  
                    // Create the writer for the file.
                    using (StreamWriter sw = File.CreateText("names.txt")) 
                    {
                        Console.WriteLine();
                        // TODO: Loop through the arrays
                    for (int i = 0; i < 25; i++)
                    {
                      if(!(nameArray[i] == null))//if it's blank (don't write it); 
                      {
                          // Write the values from the arrays to the file
                          // TODO: Get the restaurant name
                          string name = nameArray[i];
                          int rating = Convert.ToInt16(ratingArray[i]);//have to convert, that's why you always add "Convert.ToIn16 for integers, even in strings.
                          // TODO: Get the restaurant rating
                          // TODO: Write the two items to the file
                          sw.WriteLine(name);
                          sw.WriteLine(rating);
                      }  
                      
            
                    }
                        
                    }//ends file writer function 
                
                }//ends "S" function (loop)


                //  TODO: If the option is is C or c add a restuarent name and rating --i.e. add a name & rating to the array 
                if (userChoiceString=="C" || userChoiceString=="c")
                {
                    string newRestaurantName; 
                    //prompt user to enter restaurant name: 
                    Console.WriteLine("Enter restaurant name"); //prompts user to enter restaurant name
                    newRestaurantName = Console.ReadLine();//gets the new restaurant name 
                
                    string newRatingReview;

                    Console.WriteLine("Enter a rating 0-5: ");
                    newRatingReview = Console.ReadLine();

                    int index = 0; 
                    bool found = false;
                    do{
                        if(nameArray[index] ==null)// if something is NOT there
                        {
                          found = true;//we found an open array element to place the new information  
                        }
                        else
                        {
                          index++;//we didn't find an open element, so add 1 to index (while means in the loop it will look for that one)
                        }
                      } 
                    while (found == false);// line 90-102 is finds an open array index
                    
                    ratingArray[index] = newRatingReview;//put it into the array 
                    nameArray[index] = newRestaurantName; //after we found a place to put it into, this put it in there. 
                    
                }//end of "if" for item "C" 

                //  TODO: If the option is is R or r PRINT a LIST of all the restaurants and their rating; i.e. Read a name from the array  
                //"R{end here for the comp. check} Friday 
                else if (userChoiceString=="R" || userChoiceString=="R") //make changes, so they give you a name 
                //read the results 

                //read from an array 
                {
                for(int i = 0; i < nameArray.Length; i++)//start with index of 0 
                  {
                    if(!(nameArray[i] == null))//check to see if it's null, !-say's that it's "not"; as long as I have something here, print it; null=I don't want to print it
                      {
                      Console.WriteLine(nameArray [i]);
                      Console.WriteLine(ratingArray[i]);
                      }
                  }
                  
                  
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