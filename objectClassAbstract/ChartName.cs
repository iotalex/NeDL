using System;

namespace konomiAPP
{
  class ChartTitle : Scroll
    {        
       
        private string songName;  // Input for song name 

        // Get Rating 
        public int songRating  // Input for song rating 
            { get; set; }
        
        // This is the default constructor when no values are being passed.
        public ChartTitle ()
        {
            songName = null;
            songRating = 5;// should I put an array here? 
        }
        
        // This is the constructor when two values are passed.
        public ChartTitle (string newSong, int newRating)
        {
            songName = newSong;
            songRating = newRating;
        }
        
        //  Since SongRating is not defined as a property, we need to create the get and set mehtods
        //  for it.
        public string getName()
        {
            return songName; 
        }  
        
        public void setSongName (string newName)
        {
            songName = newName;
        }
      // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return "The song name is " + songName + " " + " and it's footer level is " + songRating;
        }

    }// class DDR

  
}// namespace KonomiApp  