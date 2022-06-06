using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStack
{
    internal class Music : Media//TODO: add a public abstract method here
    {
        public Music (string NewTitle, string NewFormat, int NewYear, string NewGenre)//default main string 
        {
            Title = NewTitle;
            Format = NewFormat;
            Year = NewYear;
            Genre = NewGenre; 
        }
        
        //TODO: add a public abract method to add "artist" and "almbum name" for the ToString(); 5-23-22



        public override string ToString()
        {
            return $"Song Name: {Title} | Format: {Format} | Year: {Year} | Genre: {Genre}";
        }



    }


    


}//end name space
