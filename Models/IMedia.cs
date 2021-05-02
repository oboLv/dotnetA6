using System;
using System.Collections.Generic;

namespace MovieProg.Models
{
    public interface IMedia
    {
        int id { get; set; }
        string title { get; set; }
        List<string> genres { get; set; }
        
        public string Display();
    }
}