using System;
//TODO: add something here for the list 

namespace Stepmania // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine ("Lets dance!");
        //array of DDRSong's  
        DDRSong[] ddrSongArray =new DDRSong[25];
        
        //now load in some test data 
        DDRSong newSong = new DDRSong("Butterfly", 9, "Extreme");// DDR object 

        //now print object
        Console.WriteLine(newSong);

        ddrSongArray[1] = newSong; //main object 

        Console.WriteLine("Print the array: ");
        
        //TODO: get item to print 
        



        }
    }//end class 
}//end name space 