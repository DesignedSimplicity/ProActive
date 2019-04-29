using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProActive.Lib
{
    public class FileSystem
    {
        /// <summary>
        /// Loads all GoPro video files from the given path
        /// </summary>
        public List<GoProVideo> LoadVideos(string pathUri)
        {
            var videos = new List<GoProVideo>();
            var dir = new DirectoryInfo(pathUri);
            foreach (var file in dir.GetFiles())
            {
                if (file.Extension.ToUpperInvariant() == ".MP4")
                {
                    var video = new GoProVideo(file);
                    if (video.FromGoPro)
                    {
                        videos.Add(video);
                    }
                }
            }
            return videos.OrderBy(x => x.Group).ThenBy(x => x.Index).ToList();
        }
    }
}
