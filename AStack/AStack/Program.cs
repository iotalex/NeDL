using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        

       /* internal class Program1
        {
            static void Main(string[] args)
            {
                Console.WriteLine("========Media Program=========");

                var mediaManager = new MediaManager();//access to mediaManager.cs

                var media = mediaManager.GetMedia();//function to iterate and printer list 
                foreach (Media anMedia in media)//prints the "list" above
                {
                    Console.WriteLine(anMedia);
                }
                Console.ReadKey();//catches program so it doesn't close 

                //START CRUD HERE! 

            }//end static void 

        }//end internal class program 
         //TODO Read*/



    }




}
