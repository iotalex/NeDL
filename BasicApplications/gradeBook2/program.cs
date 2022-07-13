using System;

namespace GradeProg
{
  class Program
  {
       //This number must be at least one. Get something to write
       //prompt user for number of students 

//TODO: create a prompt to ask for the grades (consolewrite, Console readline16) ToInt16; (DONE)
    static void Main(string[] args)
    {
        //get the number of students 

                Console.WriteLine("Please enter number of students:");    
                string numStudents = Console.ReadLine(); 
                int numStudentsInt = Convert.ToInt16(numStudents);
        
        //for each student, calculate thier grade 
                
                for (int student = 0; student < numStudentsInt; student++)
                {
                    Console.WriteLine("Working with student number " + (student + 1));

                int homeWorkTotal = 0;

                    //get and total 5 homework grades  
                  for (int homeWork = 0; homeWork < 5; homeWork++)
                  {
                    //work on getting 1 homework grade (zero through 100), integer between zero and hundred 
                    Console.WriteLine("Please enter student's homework grade " + (homeWork + 1));
                    string numHomework = Console.ReadLine(); 
                    int homeGrade = Convert.ToInt32(numHomework);
                    
                    while (homeGrade < 0 || homeGrade > 100)
                    {
                        Console.WriteLine("hey, please enter a number between zero or 100");
                        numHomework = Console.ReadLine(); 
                        homeGrade = Convert.ToInt16(numHomework);
                    }

                    homeWorkTotal = homeWorkTotal + homeGrade;
                  }

                  double homeWorkAverage = homeWorkTotal / 5.0;
                Console.WriteLine("The student's average homework grade is: " + homeWorkAverage);


//DON'T CHANGE ANYTHING ABOVE THIS 

//This is where I will "paste" the quiz stuff 
                int quizWorkTotal = 0;
                for (int quizWork = 0; quizWork < 3; quizWork++)
                  {
                    //work on getting 1 QUIZ grade (zero through 100), integer between zero and hundred 
                    Console.WriteLine("Please enter student's quiz grade " + (quizWork + 1));
                    string numQuizGrade = Console.ReadLine(); 
                    int quizGrade = Convert.ToInt32(numQuizGrade);
                    
                    while (quizGrade < 0 || quizGrade > 100)
                    {
                        Console.WriteLine("hey, please enter a number between zero or 100");
                        numQuizGrade = Console.ReadLine(); 
                        quizGrade = Convert.ToInt16(numQuizGrade);
                    }

                    quizWorkTotal = quizWorkTotal + quizGrade;
                  }

                  double quizWorkAverage = quizWorkTotal / 3.0;
                Console.WriteLine("The student's average quiz grade is: " + quizWorkAverage);
///DO NOT EDIT ANYTHING ABOVE THIS LINE 

                int examWorkTotal = 0;
                //two exam grades (0 to a 100)
                for (int examWork = 0; examWork < 2; examWork++)
                  {
                    //work on getting 1 EXAM grade (zero through 100), integer between zero and hundred 
                    Console.WriteLine("Please enter student's exam grade " + (examWork + 1));
                    string numExamGrade = Console.ReadLine(); 
                    int examGrade = Convert.ToInt32(numExamGrade);
                    
                    while (examGrade < 0 || examGrade > 100)
                    {
                        Console.WriteLine("hey, please enter a number between zero or 100");
                        numExamGrade = Console.ReadLine(); 
                        examGrade = Convert.ToInt16(numExamGrade);
                    }

                    examWorkTotal = examWorkTotal + examGrade;
                  }

                double examWorkAverage = examWorkTotal / 2.0;
                Console.WriteLine("The student's average exam grade is: " + examWorkAverage);
///DO NOT EDIT ANTYHING ABOVE THIS LINE
                //I can finally put something here to add up the totals 
                //homework 50% + quiz 30% + exam 20% 
        //todo: add student 1 homework, quiz, and exam grades, print on screen 
                double finAverage = (homeWorkAverage * .50) + (quizWorkAverage * .30) + (examWorkAverage * .20);
                Console.WriteLine("The final average is: " + finAverage);
        //this is where student's final grade is converted to a letter      
              
              int numberLetterGrade = 0;

              if (finAverage >= 90 && finAverage <= 100)
                {  
                      Console.WriteLine("A");
                }     
                  else if (finAverage >= 80 && finAverage <= 90)
                  {
                      Console.WriteLine("B");
                  }
                  else if (finAverage >= 70 && finAverage <= 80)
                  {
                      Console.WriteLine("C");
                  }
                  else if (finAverage >= 60 && finAverage <= 70)
                  {
                      Console.WriteLine("D");
                  }
                  else if  (finAverage <= 70)
                  {
                      Console.WriteLine("F");
                  }

               
              
    }

  } //main 
}//class program 
}//name space (this is the first line, how to track which is which start from "left to wright" from the top)


//convert final average toa letter grade (last piece) 4-8-22 *do this on your own*
//take the average and give me what would be my leter grade (hopefully knock off early Monday)

//homework = homework total * .50 + aggregiate total
//quiz = quiz total * .30 + aggregiate total 
//exam = exam total * .20 + aggregiate total 
        
//for loop for each student 
//THIS IS WHERE I CAN ADD THE NEXT SEQUENCE???? 4-8-22
//this is converting a number to a letter               
// replace with student code(Which I have done)
//finAverage                 
//A student's final grade average is calculated by adding together 50% of the homework average, 30% of the quiz average and 20% of the exam average.
//A student's final grade is calculated  based on the final grade average.  
//If it is 90% or greater, it is an A; 80% or better is a B; 70% or better is a C; 60% or better is a D; and anything less than 60% is an F.
//Once calculated, the program will display the student's name, homework average, quiz average, exam average, final average and final grade.




  

  



