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
        List<DDRSong> newDDRSongList =new List<DDRSong>();//changed to a list
              

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


        newDDRSongList[1] = newDDRSong; //main object ///********instead of adding to array, add to list*** 
        newDDRSongList[2] = newDDRSong2;
        newDDRSongList[3] = newExtremeDDRSong;// main object, with child class 
        newDDRSongList[4] = newExtremeDDRSong2;
        newDDRSongList[5] = newAceDDRSong;// DDRAce object
        newDDRSongList[6] = newAceDDRSong2;

        Console.WriteLine("Print the array: ");
        for(int index = 0; index < newDDRSongList.Length; index++)
            {
                if(!(newDDRSongList[index]==null))
                {
                    Console.WriteLine(newDDRSongList[index]);
                }
            }//start CRUD here (for later)
      


        }
    }//end class 
}//end name space 