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
                else if(choice == "4")
                {
                    Console.Clear();
                    var newGenreList = new List<string>();
                    System.Console.Write("Enter Title: ");
                    var newTitle = Console.ReadLine();
                    System.Console.WriteLine(newTitle);
                    var newGenreBool = false;
                    do
                    {
                        System.Console.Write("Enter genre: ");
                        var newGenre = Console.ReadLine();
                        System.Console.WriteLine(newGenre);
                        newGenreList.Add(newGenre);
                        System.Console.WriteLine("Add more genres? (Y/N)");
                        var moreGenres = Console.ReadLine();
                        if(moreGenres.ToUpper() == "Y")
                        {
                            break;
                        }
                        else
                        {
                            newGenreBool = true;
                        }
                    }while(!newGenreBool);
                    var joinedGenres = String.Join("|", newGenreList.ToArray());
                    var newID = 0;
                    foreach(int i in movieID)
                    {
                        if(i > newID)
                        {
                            newID = i + 1;
                        }
                    }
                    movieID.Add(newID);
                    titles.Add(newTitle);
                    genres.Add(joinedGenres);
                    var readyAddition = $"{newID},{newTitle},{joinedGenres}";
                    var writer = new StreamWriter(file);
                }
                else if(choice == "3")
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
