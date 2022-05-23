using System;

namespace ConsoleCalc //handles all the user's inputs (user interaction) 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========Media Program=========");

            var mediaManager = new MediaManager();
            var media = mediaManager.GetMedia();
            

            foreach (Media anMedia in media)//prints the "list" above
            {
                Console.WriteLine(anMedia);
            }
            Console.ReadKey();//catches program so it doesn't close 
        }
    }
    //TODO Read



    //TODO Write 


}
