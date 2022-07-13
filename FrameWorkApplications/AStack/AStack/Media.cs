using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStack
{
    internal class Media
    {
        public string Title { get; set; }
        public string Format { get; set; }
        public int Year { get; set; }
        public string Genre {get; set; }

        public Media()
        {
            Title = "";
            Format = "";
            Year = 0;
            Genre = "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewTitle">describe what this paremeter is</param>
        /// <param name="NewFormat">can comment here</param>
        /// <param name="NewYear">this comment will show up later</param>
        /// <param name="NewGenre">this comment will show up later</param>

        public Media (string NewTitle, string NewFormat, int NewYear, string NewGenre)//default main string 
        {
            Title = NewTitle;
            Format = NewFormat;
            Year = NewYear;
            Genre = NewGenre;
        }

        public override string ToString()
        {
            return $"Title: {Title} | Format: {Format} | Year: {Year} | Genre: {Genre}";
        }



    }


    


}//end name space
