using System.Collections.Generic;
using System;
using System.IO;


namespace MovieProg.Models
{
    public class Show : Media
    {
        public int season { get; set; }
        public int episode { get; set; }
        public List<string> writers { get; set; }

        public override string Display()
        {
            var writerString = string.Join("/", writers);
            var display = $"{id, -5}{title, -100}{season, 2}{episode, 2}{writerString}";
            return display;
        }
    }
}