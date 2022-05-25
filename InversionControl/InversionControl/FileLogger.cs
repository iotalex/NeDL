using System;

namespace InversionControl
{
    public class FileLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of FileLogger.");
            LogToFile(message);
        }
        private void LogToFile(string message)
        {
            Console.WriteLine("Method: LogToFile, Text: {0}", message);
        }
    }
    /* The implementation shown in the preceding code snippet is correct but there is a limitation.

    You are constrained to logging data to a text file only. 

    You can’t in any way log data to other data sources or different log targets.
    
     */


}//end name space
