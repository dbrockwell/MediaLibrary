using System;
using NLog.Web;
using System.IO;

namespace MediaLibrary
{
    class Program
    {
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Info("Program started");
            string scrubbedFile = FileScrubber.ScrubMovies("movies.csv");
            logger.Info(scrubbedFile);
            MovieFile movieFile = new MovieFile(scrubbedFile);

            string choice = "";
            do{
                Console.WriteLine("1) Add Movie");
                Console.WriteLine("2) Display All Movies");
                Console.WriteLine("Enter to quit");
                choice = Console.ReadLine();
                logger.Info("User choice: {Choice}", choice);

                if(choice == "1") {

                } else if(choice == "2") {
                    
                }
            } while (choice == "1" || choice == "2");


            logger.Info("Program ended");
        }
    }
}
