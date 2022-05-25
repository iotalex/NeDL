using System;

namespace InversionControl
{
    public class ProductService
    {
        private readonly ILogger _logger;
        public ProductService(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            _logger.Log(message);
        }
    }

    /*public void LogToDatabase(string message)
    {
        _fileLogger.Log(message);
    }*/
    //add credit



}//end name space
