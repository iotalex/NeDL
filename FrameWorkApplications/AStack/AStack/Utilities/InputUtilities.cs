using System;

namespace AStack //handles all the user's inputs (user interaction) 
{
    public static class InputUtilities  
    {
        // TODO: Add parameter for looping for input (Making sure they input the correct value)
        public static string PromptForStringInput(string inputMessage = "")
        {
            if (!string.IsNullOrWhiteSpace(inputMessage))
                Console.Write($"{inputMessage}");

            string inputString = Console.ReadLine();

            // TODO: Perform data validation here

            return Convert.ToString(inputString);
        }
        public static double PromptForDoubleInput(string inputMessage = "")
        {
            if (!string.IsNullOrWhiteSpace(inputMessage))
                Console.Write($"{inputMessage}");

            string inputString = Console.ReadLine();

            // TODO: Perform data validation here

            return Convert.ToDouble(inputString);
        }
        public static int PromptForIntInput(string inputMessage = "")
        {
            if (!string.IsNullOrWhiteSpace(inputMessage))
                Console.Write($"{inputMessage}");

            string inputString = Console.ReadLine();

            // TODO: Perform data validation here

            return Convert.ToInt32(inputString);
        }


    }
    //TODO Read



    //TODO Write 


}
