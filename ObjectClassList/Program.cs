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
        List<DDRSong> DDRSongList =new List<DDRSong>();//changed to a list
              

        //now load in some test data
        DDRSong newDDRSong = new DDRSong("Captin Jack", 7, 1);//This is creating a new DDR object 
        DDRSong newDDRSong2 = new DDRSong("I'm an Albatraoz", 12, 2);// DDR object
        //now print DDR object
        Console.WriteLine(newDDRSong);
        Console.WriteLine(newDDRSong2);
        
        //now create DDR Extreme object
        ExtremeDDRSong newExtremeDDRSong = new ExtremeDDRSong("Oh When the Saints", 9, 3, "Extreme");// DDR object
        ExtremeDDRSong newExtremeDDRSong2 = new ExtremeDDRSong("Ska a go go", 7, 2, "Extreme");// DDR object
        
        //now print DDR Extreme object
        Console.WriteLine(newExtremeDDRSong);
        Console.WriteLine(newExtremeDDRSong2);
        
        //now create DDR Ace object
        AceDDRSong newAceDDRSong = new AceDDRSong("Party Rock Anthem", 11, 4, "Ace");// DDR object 
        AceDDRSong newAceDDRSong2 = new AceDDRSong("Wake Me Up", 13, 3, "Ace");// DDR object 
        //now print DDR Ace object
        Console.WriteLine(newAceDDRSong);
        Console.WriteLine(newAceDDRSong2);

        foreach (DDRSong anDDRSong in DDRSongList) //added list to print here
            {
                Console.WriteLine(anDDRSong);
            }//start CRUD here (for later)

        }
    }//end class 
}//end name space 