using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProActive.Lib
{
    public class GoProVideo
    {
        public GoProVideo(FileInfo file)
        {
            File = file;
        }

        public FileInfo File { get; private set; }

        public bool FromGoPro => File.Name.Length == 12 && UpperName.StartsWith("G");

        public string Name => UpperName.Substring(0, 8);
        public string Group => UpperName.Substring(4, 4);
        public string Index => UpperName.Substring(2, 2);

        private string UpperName => File.Name.ToUpperInvariant();
    }

    public class GoProVideoInfo
    {
        public string VideoUri { get; set; }
        //public DateTime Created { get; set; }
        public DateTime Recorded { get; set; }
        public TimeSpan Duration { get; set; }

        public string CodecName { get; set; }
        public float FrameRate { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public bool IsRotated { get; set; }
        //public bool HasData { get; set; }

        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
