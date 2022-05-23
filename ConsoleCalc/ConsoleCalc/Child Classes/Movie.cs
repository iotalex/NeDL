using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    internal class Movie : Media
    {
        public Movie (string NewName, string NewFormat, int NewYear)//default main string 
        {
            Name = NewName;
            Format = NewFormat;
            Year = NewYear;
        }

        public override string ToString()
        {
            return $"Movie: {Name} | Format: {Format} | Year: {Year}";
        }



    }


    


}//end name space
