using System;

namespace Ahhh // Note: actual namespace depends on the project name.
{
    class SayAhh
    {
        public string openMouth
            {get; set;}
        public int numberOfConsonants
            {get; set;}
        
        public SayAhh()
        {
            openMouth = "";
            numberOfConsonants = 0;
        }

        public SayAhh(string newOpenMouth, int newNumberOfConsonants)
        {
            openMouth = newOpenMouth;
            numberOfConsonants = newNumberOfConsonants;
        }

        public override string ToString()
        {
            string outputString = $"#A's: {numberOfConsonants} | Doctor hear's: '{openMouth}'";
            return outputString; 
        }



    }
}