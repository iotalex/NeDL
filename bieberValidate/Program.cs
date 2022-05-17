using System;

namespace Ahhh // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayAhh[] newThroatArray =new SayAhh[25];
            //array of test data (3 a's)
            SayAhh newOpenMouth = new SayAhh("aaaah", 4);//This is creating a new openWide object

            //promp user to open wide
            Console.WriteLine("Please say open and say 'aaah....'");
            //get input from user 
            //string numberOfConsonants = Console.ReadLine();

            //output string or test data
            /////Console.WriteLine(newThroatArray);

            //print the array
            newThroatArray[1] = newOpenMouth; //main object
     
            //validate number of a's from user
            for(int index = 0; index < newThroatArray.Length; index++)
                        {
                            if(!(newThroatArray[index]==null))
                            {
                                Console.WriteLine(newThroatArray[index]);
                            }
                        }
         
        }//end static void 



    }//end class program 
}


   //validate 'h' from user

            //bool true or false ( line input will contain between 0 an 99 a's followed by a single 'h')

                //output 1 no

                //out 2 go 
        
        
        