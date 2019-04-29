using System;
using System.Collections.Generic;
using System.Text;
using NReco.VideoInfo;

namespace ProActive.Lib
{
    public class ParseVideo
    {
        public void Test()
        {
            var videoUri = @"C:\test\test.mp4";
            var probe = new FFProbe();
            var info = probe.GetMediaInfo(videoUri);
            Console.WriteLine(info.FormatName);
            Console.WriteLine(info.Duration);

        }
    }
}
