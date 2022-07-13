using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStack//going to contain all the logic for mainintaing, CRUD 
{
    internal class MediaManager : Media
    {
        /// <summary>
        /// put test data here
        /// </summary>
        public MediaManager ()
	{
            mediaList = new List<Media>();
            
            Media newMedia = new Media("Terminator II\n", "4K BluRay\n", 1991, "Sci-Fi");
            mediaList.Add(newMedia);

            Movie newMovie = new Movie("Baby Driver\n", "4K BluRay\n", 2017, "Heist");
            mediaList.Add(newMovie);

            Game newGame = new Game("Halo", "DVD/Xbox\n", 2001, "FPS");
            mediaList.Add(newGame);
            
            Music newMusic = new Music("An Insult to the Dead\n", "Compact Disc\n", 2017, "Indy");
            mediaList.Add(newMusic);



        }
        //declare method value
        private List<Media> mediaList;
        //method to print the list 
        public List<Media> GetMedia() { 
        
            return mediaList;
            
        }
            
       

        


      /*  public List<Media> GetMedia() { }
        public Media AddMedia() { }*/


    }
}//end name space
