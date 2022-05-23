using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc//going to contain all the logic for mainintaing, CRUD 
{
    internal class MediaManager : Media
    {
        /// <summary>
        /// put test data here
        /// </summary>
        public MediaManager ()
	{
            mediaList = new List<Media>();
            
            Media newMedia = new Media("Terminator II\n", "4K BluRay\n", 1991);
            mediaList.Add(newMedia);

            Movie newMovie = new Movie("Baby Driver\n", "4K BluRay\n", 2017);
            mediaList.Add(newMovie);

            Game newGame = new Game("Halo", "DVD/Xbox\n", 2001);
            mediaList.Add(newGame);
            
            Music newMusic = new Music("An Insult to the Dead\n", "Compact Disc\n", 2017);
            mediaList.Add(newMusic);



        }
        private List<Media> mediaList;

        
        public List<Media> GetMedia() { 
        

            return mediaList;
            
        }
            
       

        


      /*  public List<Media> GetMedia() { }
        public Media AddMedia() { }*/


    }
}//end name space
