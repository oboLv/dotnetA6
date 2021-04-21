using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;


namespace MovieProg.Models
{
    public class Video : Media
    {
        public string format { get; set; }
        public int length { get; set; }
        public List<int> regions { get; set; }

        public override string Display()
        {
            var display = $"{id, -5}{title, -100}{format, 2}";
            return display;
        }
    }
}