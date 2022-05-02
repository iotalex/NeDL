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

            // public static int PromptForIntegerInput(string inputMessage = "", int minValue = Int32.MinValue, int maxValue = Int32.MaxValue)
            // {

            // }
    }
}