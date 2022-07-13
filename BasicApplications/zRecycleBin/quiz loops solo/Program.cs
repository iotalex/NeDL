
Console.WriteLine("Enter number of quizes");
int quizNum = Convert.ToInt16(Console.ReadLine());
   // int quizScoreMin = (-1);
   //defin how high or low you integers can go 
int  minQuizScore= 101;
int maxQuizScore = -1;

double total = 0; 
//  https://www.w3schools.com/cs/cs_for_loop.php
//so you need this because the "int i = 0" part basically signals for it to ask the question for the score of each prompt.
for (int i = 0; i < quizNum; i++)
{
   Console.WriteLine("Enter quiz score:" + " " + (i+1));
   int quizScore = Convert.ToInt16(Console.ReadLine());
  //so like if your score is below this, then it has to display it "remind me of <----o------>" 

   if (quizScore >= maxQuizScore) 
{
   maxQuizScore = quizScore;
}
  //so like if your score is below this, then it has to display it "remind me of <----o------>" 
   if(quizScore <= minQuizScore)
 {
    minQuizScore = quizScore;
 } 
   total = total + quizScore; 

}

Console.WriteLine("The minimum is" + " " + minQuizScore); //broken
Console.WriteLine("The max score is" + " " + maxQuizScore); //broken
Console.WriteLine("The average score is" + " " + total / quizNum); //this is good 