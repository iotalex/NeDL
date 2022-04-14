using System;

namespace HelloWorld
{//Create a grade book 
  class Program
 //This number must be at least one.




//TODO: create a prompt to ask for the grades (consolewrite, Console readline16)
//3 quiz grades (0 to a 100)
 //   {

 //   }
//TODO: create a prompt to ask for the grades (consolewrite, Console readline16)
//two exam grades (0 to a 100)


 //   {

 //   }
 {
        static int MyMin(int newValue, int currentMin)
        {
            if (newValue <= currentMin)
            {
                return newValue;
            }
            else return currentMin;
        }
        static int GetValidInt(int lowRange, int highRange)
        {
            int numericInput = 0;
            bool validInput = false;
            // TOOD: Create a loop
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
            
        }//end of "get valid integer", this is my 0 through 100 mehtod 

//TODO: create a prompt to ask for the grades (consolewrite, Console readline16)

// 5 homework grades

        static int MyMax(int newValue, int currentMax)
        {
            if (currentMax >= newValue)
            {
                return currentMax;
            }
            else return newValue;

        }
        static void Main(string[] args)
        {
//over here 

//TODO: create a prompt to ask for the grades (consolewrite, Console readline16)
//5 homework grades (0 to a 100)
 //   {

 //   }
            Console.WriteLine("Enter number of homework grades"); //do not use arrays
            int quizNum = GetValidInt(1, 100);

            //initialize minQuizScore
            int minQuizScore = 101;

            //initial maxQuizScore
            int maxQuizScore = -1;

            //this is where to initial total 
            double total = 0;

            // loop through quiz scores 
            for (int i = 0; i < quizNum; i++)
            {
                //get a valid quiz score 
                Console.WriteLine("Enter homework grade number" + " " + (i + 1)); //do not use arrays
                int quizScore = GetValidInt (0, 100);

                //see if quiz score is minimum 
                minQuizScore = MyMin(quizScore, minQuizScore);
                maxQuizScore = MyMax(quizScore, maxQuizScore);

                //see if quiz score is maximum 

                total = total + quizScore;

            }

            Console.WriteLine("Homework grade 1:" + " " + minQuizScore);
            Console.WriteLine("Homework grade 2:" + " " + maxQuizScore);
            Console.WriteLine("Homework grade 3:" + " " + total / quizNum);

         
        }

//The instructor will provide the number of students for which grades need to be calculated.  



//For each student, the instructor will provide five homework grades, three quiz grades, and two exam grades.
// 5 homework grades = 50%
//TODO: 

// 3 quiz grades = 30%
//TODO:

// 2 exam grades = 20%
//TODO: 

/////////total grades add up to equal = 100%

//All grades must be between 0 and 100 inclusively.        
        



//A student's final grade average is calculated by adding together 50% of the homework average, 30% of the quiz average and 20% of the exam average.
//A student's final grade is calculated  based on the final grade average.  
//If it is 90% or greater, it is an A; 80% or better is a B; 70% or better is a C; 60% or better is a D; and anything less than 60% is an F.
//Once calculated, the program will display the student's name, homework average, quiz average, exam average, final average and final grade.

  }      
        
  
}