using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProActive
{
    public class GoProSet
    {
        public string Date { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
    }

    public class GoProVideo
    {
        public GoProVideo(FileInfo file, GoProVideoInfo info)
        {
            File = file;
            Info = info;
        }

        public FileInfo File { get; private set; }
        public GoProVideoInfo Info { get; private set; }
        public Image Thumbnail { get; set; }

        public string Name => File.Name.Substring(0, 8);
        public string Group => File.Name.Substring(4, 4);
        public string Index => File.Name.Substring(2, 2);
    }

    public class GoProVideoInfo
    {
        public string VideoUri { get; set; }
        public DateTime Recorded { get; set; }
        public TimeSpan Duration { get; set; }

        public string Firmware { get; set; }
        public string CodecName { get; set; }
        public float FrameRate { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public bool IsRotated { get; set; }

        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
