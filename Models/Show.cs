using System.Collections.Generic;
using System;
using System.IO;


namespace MovieProg.Models
{
    public class Show : IMedia
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }
        public int season { get; set; }
        public int episode { get; set; }
        public List<string> writers { get; set; }

        public string Display()
        {
            var writerString = string.Join("/", writers);
            var genreString = string.Join("/", genres);
            var display = $"{id, -5}{title, -50}{season, 8}{episode, 8}{writerString, -30}{genreString}";
            return display;
        }
    }
}