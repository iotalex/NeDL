using System;

namespace AboveAverage // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {    
            //Get the number of cases (make sure it's between 1 and 50)
            int numCases = Convert.ToInt32(Console.ReadLine());
            int[] scoreArray = new int[1000];

            //get in a loop to get number of cases
            for(int aCase = 0; aCase < numCases; aCase++)
            {
                double numScores = Convert.ToDouble(Console.ReadLine());
                //do another loop to get number of variables need to calculate 
                double scoreTotal = 0.0;
                for(int aScore = 0; aScore < numScores; aScore++)//gets scores from one case and calc average 
                {
                    // Get the numbers
                    scoreArray[aScore] = Convert.ToInt32(Console.ReadLine());
                    scoreTotal += scoreArray[aScore]; //
                }
                double averageScore = scoreTotal / numScores; 
                                
                double scoresAboveAverage = 0.0;
                for(int aScore = 0; aScore < numScores; aScore++)//calc how many scores are above average 
                {
                    // counting how many scores  
                    if(scoreArray[aScore] > averageScore)
                        {
                            scoresAboveAverage = scoresAboveAverage + 1;
                        }
                    
                }

                Console.WriteLine(scoresAboveAverage); //test scoresabove is broken 
                Console.WriteLine(numScores);

                double percentScoresAboveAverage = scoresAboveAverage / numScores;
                Console.WriteLine(percentScoresAboveAverage);

            }




            //once we get this number, this is the number of time it goes through the loop 




        // //store array
        // int[] myNumArray = new int[5];

        // for (int index = 0; index < 5; index++)//copy the loop; create the array values (get's it from user)
        // {
            
        //     myNumArray[index] = Convert.ToInt16(Console.ReadLine());

        // }//end of forloop
        
        // for (int index = 0; index < 5; index++)
        // {
            
        //     Console.WriteLine(myNumArray[index]);
            
        // }//end of forloop
        
        
        // calculat array; 
        
        
        //add socre; find the mean, and then divide the total by the mean (number of scores greater than the mean)
        
        
        
        
        }//end static void 

    }//end class program 
}


