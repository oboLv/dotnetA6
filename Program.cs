using System;
using System.Collections.Generic;
using MovieProg.Models;
using Microsoft.Extensions.DependencyInjection;
using MovieProg.Files;
using MovieProg.Data;

namespace MovieProg
{
    class Program
    {
        static void Main(string[] args)
        {

            var mf = new MovieFile();
            var vf = new VideoFile();
            var sf = new ShowFile();
            DX dx = new DX(mf, sf, vf);
            
            var exit = false;
            while(!exit)
            {
                var choice = dx.MainMenu();
                if(choice == "1")
                {
                    dx.ShowMovies();
                }
                else if(choice == "2")
                {
                    dx.ShowShows();
                }
                else if(choice == "3")
                {
                    dx.ShowVideos();
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
                    System.Console.WriteLine("Press any key to continue:");
                    Console.ReadKey();
                }
            }
        }
    }
}
