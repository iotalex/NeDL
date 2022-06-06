using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStack
{
    internal class Game : Media
    {
        public Game (string NewTitle, string NewFormat, int NewYear, string NewGenre)//default main string 
        {
            Title = NewTitle;
            Format = NewFormat;
            Year = NewYear;
            Genre = NewGenre;
        }

        public override string ToString()
        {
            return $"Song Name: {Title} | Format: {Format} | Year: {Year} | Genre: {Genre}";
        }



    }


    


}//end name space
