using System;


namespace Stepmania // Note: actual namespace depends on the project name.
{
     class DDRSong //abstract class 
    {
        public string songName
            {get; set;}
        int footer
            {get; set;}
        public string color
            {get; set;}
        
        public DDRSong()
        {
            songName = " ";
            footer = 0;
            color = " "; 
        }

        public DDRSong(string newSongName, int newFooter, string newColor)//default constructor 
        {
            songName = newSongName;
            footer = newFooter;
            color = newColor;
        }
        
        public override string ToString()
        {
            string outputString = $"Song Name: {songName} | Footer: {footer} | Series: {color}";
            return outputString;
        }

    }//end class song

}//end name space