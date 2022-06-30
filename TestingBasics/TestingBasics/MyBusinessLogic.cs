using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenTestsSample
{
    internal class MyBusinessLogic
    {
        public int CalculateAdditionResult(int x, int y)
        {
            // This method will add 2 numbers and return the result
            // If the result if >10 then it will return 10 instead
            // If the result is <0 then it will return 0 instead
            int result = x + y;

            if (result > 10)
            {
                result = 10;
            }
            else if (result < 0)
            {
                result = 0;
            }

            return result;
        }
    }
}
