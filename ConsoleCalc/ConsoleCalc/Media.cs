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


        public string Media (string NewName, string NewFormat, int NewYear)//main string 
        {
            Name = NewName;
            Format = NewFormat;
            Year = NewYear;
        }


        


    }


    


}//end name space
