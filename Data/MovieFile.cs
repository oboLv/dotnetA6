using System.Collections.Generic;
using MovieProg.Models;
using Newtonsoft.Json;
using System.Linq;
using System.IO;
using MovieProg.Files;


namespace MovieProg.Data
{
    public class MovieFile : IFile
    {
        private readonly string _filename = "movies.json";

        public void Add(IMedia media)
        {
            var json = JsonConvert.SerializeObject(media);
            var trim = string.Concat(json.Where(c => !char.IsWhiteSpace(c)));
            using (var writer = new StreamWriter(_filename))
            {
                writer.WriteLine(trim);
            }
        }

        public List<IMedia> GetMedia()
        {
            var list = new List<IMedia>();
            using (var reader = new StreamReader(_filename))
            {
                while(!reader.EndOfStream)
                {
                    list.Add(JsonConvert.DeserializeObject<Movie>(reader.ReadLine()));
                }
            }
            return list;
        }
    }
}