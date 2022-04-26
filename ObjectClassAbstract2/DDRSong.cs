using System;


namespace Stepmania // Note: actual namespace depends on the project name.
{
     class DDRSong
    {
        public string songName
            {get; set;}
        int footer
            {get; set;}
        public string seriesType
            {get; set;}
        
        
        public DDRSong()
        {
            songName = " ";
            footer = 0;
            seriesType = " "; 

        }

        public DDRSong(string newSongName, int newFooter, string newSeriesType)//default constructor 
        {
            songName = newSongName;
            footer = newFooter;
            seriesType = newSeriesType;
        }

    }//end class song 

}//end name space