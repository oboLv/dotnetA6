using System.Collections.Generic;
using System;
using System.IO;
using MovieProg.Data;
using Newtonsoft.Json;
using System.Linq;

namespace MovieProg.Models
{
    public class Movie : IMedia
    {
        public Movie()
        {
            var list = new List<IMedia>();
            using (var reader = new StreamReader("movies.json"))
            {
                while(!reader.EndOfStream)
                {
                    list.Add(JsonConvert.DeserializeObject<Movie>(reader.ReadLine()));
                }
            }
            
            this.id = list.Max(i => i.id) + 1;
               
            System.Console.Write("Enter title: ");
            this.title = Console.ReadLine();
            System.Console.Write("Enter genre:");
            var newGenreBool = false;
            do
            {
                System.Console.Write("Enter genre: ");
                this.genres.Add(Console.ReadLine());
                System.Console.WriteLine("Add more genres? (Y/N)");
                var moreGenres = Console.ReadLine();
                if (moreGenres.ToUpper() == "Y")
                {
                    break;
                }
                else if (moreGenres.ToUpper() == "N")
                {
                    newGenreBool = true;
                }
                else
                {
                    System.Console.WriteLine("Try again.");
                }
            } while (!newGenreBool);
            
        }
        public int id { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }

        public string Display()
        {
            var genreString = string.Join("/", genres);
            
            var display = $"{id, -5}{title, -50}{genreString, 2}";
            return display;
        }
    }
}