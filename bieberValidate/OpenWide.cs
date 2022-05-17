using System;

namespace Ahhh // Note: actual namespace depends on the project name.
{
    class OpenWide
    {
        public string openWide
            {get; set;}
        public int numberOfConsonants
            {get; set;}
        
        public Ahhh()
        {
            openWide = "";
            numberOfConsonants = 0;
        }

        public OpenWide(string newOpenWide, int newNumberOfConsonants)
        {
            openWide = newOpenWide;
            numberOfConsonants = newNumberOfConsonants;
        }
        



    }
}