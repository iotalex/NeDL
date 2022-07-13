using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    internal class Movie : Media
    {
        public Movie (string NewName, string NewFormat, int NewYear, string NewGenre)//default main string 
        {
            Name = NewName;
            Format = NewFormat;
            Year = NewYear;
            Genre = NewGenre;
        }

        public override string ToString()
        {
            return $"Song Name: {Name} | Format: {Format} | Year: {Year} | Genre: {Genre}";
        }



    }


    


}//end name space
