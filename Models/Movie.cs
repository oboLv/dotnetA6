using System.Collections.Generic;
using System;
using System.IO;


namespace MovieProg.Models
{
    public class Movie : Media
    {
        public List<string> genres { get; set; }

        public override string Display()
        {
            var genreString = string.Join("/", genres);
            
            
            var display = $"{id, -5}{title, -100}{genreString, 2}";
            return display;
        }
    }
}