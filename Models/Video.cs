using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;


namespace MovieProg.Models
{
    public class Video : IMedia
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }
        public string format { get; set; }
        public int length { get; set; }
        public List<string> regions { get; set; }

        public string Display()
        {
            var regionString = string.Join("/", regions);
            var genreString = string.Join("/", genres);
            var display = $"{id, -5}{title, -50}{format, 6}{length, 6}{regionString, -5}{genreString}";
            return display;
        }
    }
}