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

        public bool FromGoPro => File.Name.Length == 12 && UpperName.StartsWith("GH");

        public string Name => UpperName.Substring(0, 8);
        public string Group => UpperName.Substring(4, 4);
        public string Index => UpperName.Substring(2, 2);

        private string UpperName => File.Name.ToUpperInvariant();
    }
}
