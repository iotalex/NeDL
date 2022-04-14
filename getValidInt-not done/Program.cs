using System;

namespace GetValidInPrac
{
class Program
{
static int GetValidInt(int lowRange, int highRange)
        {
            int numericInput = 0;
            bool validInput = false;
            // TOOD: Create a loop (I recylced this method on 4-7-2022)
            while (validInput == false)
            {
                // TODO: Prompt user for input
                Console.WriteLine("Please enter a value between " + lowRange + " and " + highRange);

                //ToDO: get the input from the user 
                numericInput = Convert.ToInt16(Console.ReadLine()); 
            
                // TODO: Validate the inpu
                
                    // TODO: Check to see if lower than low range
                    if (numericInput < lowRange)
                    {
                        // Invalid input; output error message to user
                            Console.WriteLine("error, please enter a value on or above " + lowRange);
                    } //end if 
                    else
                    {
                        if (numericInput > highRange)
                        {
                            // Invalid input; output error message to user
                            Console.WriteLine("error, please enter a value on or below " + highRange);
                        } //end if 
                        else
                        {
                            // Input is a valid number; return value to calling function
                            validInput = true;
                        } //end else 
                    } //end else 
                } //ends while 
            
            return numericInput;
            
        }

//Create a program that will obtain obtain a base from user and an (2) exponenet from the user
    static void Main(string[] args)
        {
                //1) obtain a base number from user and an 
                Console.WriteLine("What is the base number?");
                int numBase = GetValidInt(1,100); 
                Console.WriteLine(numBase);
        
                //(2) exponenet from the user
                Console.WriteLine("What is the exponent?");
        }
//    numericInput = Convert.ToInt16(Console.ReadLine()); 

// 3) and will print out the value of the base taken to the exponenet power 
    
    
//4) use a method, Power, to calculat the value
        
    
//6) repeat the process until the use wants to quit 
  
  
  
  
}
}


    

 











//using System;

//namespace MyApplication
//{
  //  class Program
    

    //{
    //Console.ReadLine("nothing"); 
    //}
    //(((problem 1 of 2))) 
    
    
        
 //           do
 //           {
 //               Console.WriteLine("nothing");
 //           }
        
               




//}



