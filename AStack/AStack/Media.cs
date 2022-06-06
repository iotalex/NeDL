using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStack
{
    internal class Media
    {
        public string Name { get; set; }
        public string Format { get; set; }
        public int Year { get; set; }
        public string Genre {get; set; }

        public Media()
        {
            Name = "";
            Format = "";
            Year = 0;
            Genre = "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NewName">describe what this paremeter is</param>
        /// <param name="NewFormat">can comment here</param>
        /// <param name="NewYear">this comment will show up later</param>
        /// <param name="NewGenre">this comment will show up later</param>

        public Media (string NewName, string NewFormat, int NewYear, string NewGenre)//default main string 
        {
            Name = NewName;
            Format = NewFormat;
            Year = NewYear;
            Genre = NewGenre;
        }

        public override string ToString()
        {
            return $"Title: {Name} | Format: {Format} | Year: {Year} | Genre: {Genre}";
        }



    }


    


}//end name space
