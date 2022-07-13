using System;

namespace MyApplication
{
    class Program
    //Use the MyMin method in your Main method to find the minimum
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
            
        }

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

            Console.WriteLine("Enter number of quizes:"); //do not use arrays
            int quizNum = GetValidInt(1, 500);

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
                Console.WriteLine("Enter quiz number" + " " + (i + 1)); //do not use arrays
                int quizScore = GetValidInt (0, 100);

                //see if quiz score is minimum 
                minQuizScore = MyMin(quizScore, minQuizScore);
                maxQuizScore = MyMax(quizScore, maxQuizScore);

                //see if quiz score is maximum 

                total = total + quizScore;

            }

            Console.WriteLine("The minimum is" + " " + minQuizScore);
            Console.WriteLine("The maximum is" + " " + maxQuizScore);
            Console.WriteLine("The average is" + " " + total / quizNum);

         
        }
    }
}



