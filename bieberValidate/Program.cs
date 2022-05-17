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
            string openMouth = Convert.ToString(Console.ReadLine()); 
            
            

            //print the array
            newThroatArray[1] = newOpenMouth; //main object
            for(int index = 0; index < newThroatArray.Length; index++)
                        {
                            if(!(newThroatArray[index]==null))
                            {
                                Console.WriteLine(newThroatArray[index]);
                            }
                        }//end print array 
            
        }//end static void 



    }//end class program 
}


   //validate 'h' from user

            //bool true or false ( line input will contain between 0 an 99 a's followed by a single 'h')

                //output 1 no

                //out 2 go 
        
        
        