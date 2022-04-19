using System;

namespace konomiAPP
{
  class Program
  {
    static void Main(string[] args)
    { 
        // Declare and instantiate the array of song objects
        DDR[] songArray=new DDR[25];

        // Now, loop through each array element and instantiate a Song object for each.
        // Note that the constructor with no parameters will be used.

        for (int index = 0; index < songArray.Length; index++)
        {
            songArray[index] = new DDR();
        }
        // create two data values 
        //data value 1:
        songArray[1].setSongName("Butterfly");
        //data value 2: difficulty level
        // print each restaurant to test the property gets and the toString
        for (int index = 0; index < songArray.Length; index++)
        {
            if (!(((songArray[index]).getName())==null))
                Console.WriteLine(songArray[index]);
        }

    } // end Main
  } // end class
} // namespace