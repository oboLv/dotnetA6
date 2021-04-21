using System.IO;
using System;
using System.Collections.Generic;


namespace MovieProg.Models
{
    public abstract class Media
    {
        public int id { get; set; }
        public string title { get; set; }

        public abstract string Display();
    }

    



    



    
}