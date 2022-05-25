using System;

namespace InversionControl
{
    public class ProductService
    {
        private readonly FileLogger _fileLogger = new FileLogger();
        public void Log(string message)
        {
            _fileLogger.Log(message);
        }


    }//end ProductServices class




}//end name space
