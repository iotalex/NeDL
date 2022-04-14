//get number of quizes   
Console.WriteLine("Enter number of quizes:"); //do not use arrays
int quizNum = Convert.ToInt16(Console.ReadLine());

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
  Console.WriteLine("Enter quiz numer" + " " + (i+1)); //do not use arrays
  int quizScore = Convert.ToInt16(Console.ReadLine());

  //see if quiz score is minimum 
  if (quizScore <= minQuizScore)
  {
    minQuizScore = quizScore;
  }

 //see if quiz score is maximum 
  if (quizScore >= maxQuizScore)
  {
    maxQuizScore = quizScore;
  }

  total = total + quizScore;

}
Console.WriteLine("The minimum is" + " " + minQuizScore);
Console.WriteLine("The maximum is" + " " + maxQuizScore);
Console.WriteLine("The average is" + " " + total / quizNum);


  
