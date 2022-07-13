using System;

namespace konomiAPP
{
  class DDR 
    {        
       
        private string SongName;  // Input for song name 

        // Get Rating 
        public int SongRating  // Input for song rating 
            { get; set; }
        
        // This is the default constructor when no values are being passed.
        public DDR ()
        {
            SongName = null;
            SongRating = 5;// should I put an array here? 
        }
        
        // This is the constructor when two values are passed.
        public DDR (string newSong, int newRating)
        {
            SongName = newSong;
            SongRating = newRating;
        }
        
        //  Since SongRating is not defined as a property, we need to create the get and set mehtods
        //  for it.
        public string getName()
        {
            return SongName; 
        }  
        
        public void setSongName (string newName)
        {
            SongName = newName;
        }
      // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return "The song name is " + SongName + " " + " and it's footer level is " + SongRating;
        }

    }// class DDR

  class Song : DDR
  {
      
  }  
}// namespace KonomiApp  