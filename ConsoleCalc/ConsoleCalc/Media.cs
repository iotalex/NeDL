using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    internal class Media
    {
        public string Name { get; set; } 
        public string Format { get; set; }
        public int Year { get; set; }

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
        public Media (string NewName, string NewFormat, int NewYear)//default main string 
        {
            Name = NewName;
            Format = NewFormat;
            Year = NewYear;
        }

        public override string ToString()
        {
            return $"Title: {Name} | Format: {Format} | Year: {Year}";
        }



    }


    


}//end name space
