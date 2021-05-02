using MovieProg.Models;
using System.Collections.Generic;

namespace MovieProg.Files
{
    public interface IFile
    {
        List<IMedia> GetMedia();
        void Add(IMedia media);
    }
}