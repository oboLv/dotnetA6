using System;
using System.IO;
using System.Collections.Generic;
using MovieProg.Models;
using MovieProg.Files;
using MovieProg.Data;


namespace MovieProg
{

    public class DX
    {
        private IFile _movieFile;
        private IFile _showFile;
        private IFile _videoFile;
        public DX(MovieFile mf, ShowFile sf, VideoFile vf)
        {
            _movieFile = mf;
            _showFile = sf;
            _videoFile = vf;
        }
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

        public void ShowMovies()
        {
            Console.Clear();
            System.Console.WriteLine("{0, -5}{1, -50}{2, 2}", "ID", "Title", "Genres");
            foreach (var movie in _movieFile.GetMedia())
            {
                System.Console.WriteLine(movie.Display());
            }
            System.Console.WriteLine("Press any key to return to menu:");
            Console.ReadKey();
        }


        public void ShowVideos()
        {
            var videos = _videoFile.GetMedia();
            Console.Clear();
            System.Console.WriteLine("{0, -5}{1, -50}{2, 6}{3, 6}{4, 5}", "ID", "Title", "Format", "Length", "Regions", "Genres");
            foreach (var video in videos)
            {
                System.Console.WriteLine(video.Display());
            }
            System.Console.WriteLine("Press any key to return to menu:");
            Console.ReadKey();
        }

        public void ShowShows()
        {
            var shows = _showFile.GetMedia();
            Console.Clear();
            System.Console.WriteLine("{0, -5}{1, -50}{2, 8}{3, 8}{4, -30}{5}", "ID", "Title", "Season", "Episode", "Writers", "Genres");
            foreach (var show in shows)
            {
                System.Console.WriteLine(show.Display());
            }
            System.Console.WriteLine("Press any key to return to menu:");
            Console.ReadKey();
        }
        // public List<Show> GetShows()
        // {
        //     var shows = new List<Show>();
        //     var reader = new StreamReader("shows.csv");
        //     var skipHeader = reader.ReadLine();
        //     while (!reader.EndOfStream)
        //     {
        //         var newShow = new Show();
        //         var line = reader.ReadLine();
        //         var split = line.Split(',');
        //         newShow.id = Convert.ToInt32(split[0]);
        //         newShow.title = split[1];
        //         newShow.season = Convert.ToInt32(split[2]);
        //         newShow.episode = Convert.ToInt32(split[3]);
        //         newShow.writers = new List<string>(split[4].Split('|'));
        //         shows.Add(newShow);
        //     }
        //     reader.Close();
        //     return shows;
        // }


        // public List<Video> GetVideos()
        // {
        //     var videos = new List<Video>();
        //     var reader = new StreamReader("videos.csv");
        //     while (!reader.EndOfStream)
        //     {
        //         var newVid = new Video();
        //         var line = reader.ReadLine();
        //         var split = line.Split(',');
        //         newVid.id = Convert.ToInt32(split[0]);
        //         newVid.title = split[1];
        //         newVid.format = split[2];
        //         newVid.length = Convert.ToInt32(split[3]);
        //         var splitRegions = split[4].Split('|');
        //         newVid.regions = new List<string>(splitRegions);
        //         videos.Add(newVid);
        //     }
        //     reader.Close();
        //     return videos;
        // }

        // public List<Movie> GetMovies()
        // {
        //     var movies = new List<Movie>();
        //     var reader = new StreamReader("movies.csv");
        //     while (!reader.EndOfStream)
        //     {
        //         var newMovie = new Movie();
        //         var line = reader.ReadLine();
        //         var split = line.Split(',');
        //         newMovie.id = Convert.ToInt32(split[0]);
        //         newMovie.title = split[1];
        //         newMovie.genres = new List<String>(split[2].Split('|'));
        //         movies.Add(newMovie);
        //     }
        //     reader.Close();
        //     return movies;
        // }
        public void AddMovie()
        {
            _movieFile.Add(new Movie());
        }
        public void AddShow()
        {

        }
        public void AddVideo()
        {

        }
    }
}