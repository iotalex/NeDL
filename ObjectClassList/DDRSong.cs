using System;


namespace Stepmania // Note: actual namespace depends on the project name.
{
     class DDRSong //abstract class 
    {
        public string songName
            {get; set;}
        int footer
            {get; set;}
        public int difficulty
            {get; set;}
        
        public DDRSong()
        {
            songName = " ";
            footer = 0;
            difficulty = 0; 
        }
      
        public DDRSong(string newSongName, int newFooter, int newDifficulty)//default constructor 
        {
            songName = newSongName;
            footer = newFooter;
            difficulty = newDifficulty;
        }
        
        public override string ToString()
        {
            string outputString = $"Song Name: {songName} | Footer: {footer} | Difficulty: {difficulty}";
            return outputString;
        }

    }//end class song

}//end name space