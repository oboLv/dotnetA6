using System.Collections.Generic;
using MovieProg.Models;
using Newtonsoft.Json;
using System.Linq;
using System.IO;
using MovieProg.Files;

namespace MovieProg.Data
{
    public class ShowFile : IFile
    {
        public void Add(IMedia media)
        {
            throw new System.NotImplementedException();
        }

        public List<IMedia> GetMedia()
        {
            throw new System.NotImplementedException();
        }
    }
}