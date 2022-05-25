using System;

namespace InversionControl
{
    public class ProductService
    {
        public void Log(string message)
        {
            ILogger logger = new FileLogger();
            logger.Log(message);
        }
    }//end ProductServices class


    /*public void LogToDatabase(string message)
    {
        _fileLogger.Log(message);
    }*/



}//end name space
