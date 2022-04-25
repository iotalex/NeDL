using System;

namespace konomiAPP
{
    abstract class Scroll
    {
        public string songName //property 
        {get; set;}
        public string songChart//property 
        {get; set;}
        public string songRating//property
        {get; set;}

    public Scroll()
    {
        songName = " ";
        songChart = " ";
        songRating = " ";
    }

    public Scroll (string newSongName, string newSongChart, string newSongRating) //another contructor 
    {
        songName = newSongName;
        songChart = newSongChart;
        songRating = newSongRating;
    }

    public abstract double GetChart();

        public override string ToString()
        {
            return "Song: " + songName + "Chart: " + 
        }

    }//end class Scroll

}//end name space