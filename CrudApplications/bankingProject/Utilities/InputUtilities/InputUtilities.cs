namespace BankingApp

{
    public static class InputUtilities
    {
        // TODO: Add parameter for looping for input (Making sure they input the correct value)
            public static double PromptForDoubleInput(string inputMessage = "")
            {
                if (!string.IsNullOrWhiteSpace(inputMessage))
                    Console.Write($"{inputMessage}: " );    

                string inputString = Console.ReadLine();

// TODO: Perform data validation here

                return Convert.ToDouble(inputString);
            }

            
    }
}


/*       **this is my positive number logic 

 while(withDrawalAmount <= 0)
                    {
                   
                    if(withDrawalAmount < 0)//second chance to enter positive number
                        {
                            withDrawalAmount = InputUtilities.PromptForDoubleInput("Please enter a positive number!");
//                            withDrawalAmount = Convert.ToDouble(Console.ReadLine()); replace this, cool 
                        }
                    break; 
                    }//end if

*/