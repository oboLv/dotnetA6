using System;
using System.IO;
using System.Collections.Generic;
using MovieProg.Models;


namespace MovieProg
{
    public class DX
    {
        public string MainMenu()
        {
            System.Console.WriteLine("1. List movies");
            System.Console.WriteLine("2. List shows");
            System.Console.WriteLine("3. List videos");
            System.Console.WriteLine("4. Add movie");
            System.Console.WriteLine("5. Add show");
            System.Console.WriteLine("6. Add video");
            System.Console.WriteLine("7. Exit");
            var choice = Console.ReadLine();
            return choice;
        }

        public void ShowMovies(List<Movie> movies)
        {
            Console.Clear();
            
            var exitview = false;
            var displaybool = true;
            while (!exitview)
            {
                if (displaybool == true)
                {
                    System.Console.WriteLine("{0, -5}{1, -100}{2, 2}", "ID", "Title", "Genres");
                }
                var choiceview = Console.ReadLine();
                if (choiceview == "1")
                {
                    displaybool = true;
                    Console.Clear();
                }
                else if (choiceview == "2")
                {
                    exitview = true;
                }
                else
                {
                    displaybool = false;
                    System.Console.WriteLine("Try again");
                }
            }

        }

        public void ShowVideos(List<Video> videos)
        {

        }

        public void ShowShows(List<Show> shows)
        {

        }
        public List<Show> GetShows()
        {
            var shows = new List<Show>();
            var reader = new StreamReader("shows.csv");
            var skipHeader = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var newShow = new Show();
                var line = reader.ReadLine();
                var split = line.Split(',');
                newShow.id = Convert.ToInt32(split[0]);
                newShow.title = split[1];
                newShow.season = Convert.ToInt32(split[2]);
                newShow.episode = Convert.ToInt32(split[3]);
                newShow.writers = new List<string>(split[4].Split('|'));
                shows.Add(newShow);
            }
            reader.Close();
            return shows;
        }


        public List<Video> GetVideos()
        {
            var videos = new List<Video>();
            var reader = new StreamReader("videos.csv");
            var skipHeader = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var newVid = new Video();
                var line = reader.ReadLine();
                var split = line.Split(',');
                newVid.id = Convert.ToInt32(split[0]);
                newVid.title = split[1];
                newVid.format = split[2];
                newVid.length = Convert.ToInt32(split[3]);
                var splitRegions = Convert.ToInt32(split[4].Split('|'));
                newVid.regions = new List<int>(splitRegions);
                videos.Add(newVid);
            }
            reader.Close();
            return videos;
        }

        public List<Movie> GetMovies()
        {
            var movies = new List<Movie>();
            var reader = new StreamReader("movies.csv");
            var skipHeader = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var newMovie = new Movie();
                var line = reader.ReadLine();
                var split = line.Split(',');
                newMovie.id = Convert.ToInt32(split[0]);
                newMovie.title = split[1];
                newMovie.genres = new List<String>(split[2].Split('|'));
                movies.Add(newMovie);
            }
            reader.Close();
            return movies;
        }
    }
}