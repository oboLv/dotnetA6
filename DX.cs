using System;
using System.IO;
using System.Collections.Generic;
using MovieProg.Models;


namespace MovieProg
{
    public interface IDX
    {
        void AddMovie();
        void AddShow();
        void AddVideo();
        List<Movie> GetMovies();
        List<Show> GetShows();
        List<Video> GetVideos();
        string MainMenu();
        void ShowMovies(List<Movie> movies);
        void ShowShows(List<Show> shows);
        void ShowVideos(List<Video> videos);
    }

    public class DX : IDX
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
            System.Console.WriteLine("{0, -5}{1, -100}{2, 2}", "ID", "Title", "Genres");
            foreach (var movie in movies)
            {
                System.Console.WriteLine(movie.Display());
            }
            System.Console.WriteLine("Press any key to return to menu:");
            var hold = Console.ReadKey();
        }


        public void ShowVideos(List<Video> videos)
        {
            Console.Clear();
            System.Console.WriteLine("{0, -5}{1, -100}{2, 6}{3, 6}{4, 5}", "ID", "Title", "Format", "Length", "Regions");
            foreach (var video in videos)
            {
                System.Console.WriteLine(video.Display());
            }
            System.Console.WriteLine("Press any key to return to menu:");
            var hold = Console.ReadKey();
        }

        public void ShowShows(List<Show> shows)
        {
            Console.Clear();
            System.Console.WriteLine("{0, -5}{1, -100}{2, 8}{3, 8}{4}", "ID", "Title", "Genres");
            foreach (var show in shows)
            {
                System.Console.WriteLine(show.Display());
            }
            System.Console.WriteLine("Press any key to return to menu:");
            var hold = Console.ReadKey();
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
        public void AddMovie()
        {
            var addMov = new Movie();
            System.Console.Write("Enter title: ");
            addMov.title = Console.ReadLine();
            System.Console.Write("Enter genre:");
            var newGenreBool = false;
            do
            {
                System.Console.Write("Enter genre: ");
                addMov.genres.Add(Console.ReadLine());
                System.Console.WriteLine("Add more genres? (Y/N)");
                var moreGenres = Console.ReadLine();
                if (moreGenres.ToUpper() == "Y")
                {
                    break;
                }
                else
                {
                    newGenreBool = true;
                }
            } while (!newGenreBool);
        }
        public void AddShow()
        {

        }
        public void AddVideo()
        {

        }
    }
}