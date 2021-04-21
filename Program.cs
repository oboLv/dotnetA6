using System;
using System.Collections.Generic;
using System.IO;
using MovieProg.Models;
namespace MovieProg
{
    class Program
    {
        static void Main(string[] args)
        {

            var dx = new DX();
            var movies = new List<Movie>(dx.GetMovies());
            var videos = new List<Video>(dx.GetVideos());
            var shows = new List<Show>(dx.GetShows());
            var choice = dx.MainMenu();
            var exit = false;
            while(!exit)
            {
                
                if(choice == "1")
                {
                    dx.ShowMovies(movies);
                }
                else if(choice == "2")
                {
                    dx.ShowShows(shows);
                }
                else if(choice == "3")
                {
                    dx.ShowVideos(videos);
                }
                else if(choice == "4")
                {
                    dx.AddMovie();
                }
                else if(choice == "5")
                {
                    dx.AddShow();
                }
                else if(choice == "6")
                {
                    dx.AddVideo();
                }
                else if(choice == "7")
                {
                    exit = true;
                }
                else
                {
                    System.Console.WriteLine("Try again.");
                }
            }
        }
    }
}
