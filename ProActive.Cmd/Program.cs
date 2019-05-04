using NReco.VideoInfo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProActive.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var  videoUri = @"D:\___ProActive\20181129 - Hyperlapse Depart GH010008 1080p10x.MP4";

            if (args != null && args.Length > 0)
            {
                videoUri = args[0];
            }

            while (!File.Exists(videoUri))
            {
                Console.Write("Invalid URI specified. Please enter a URI to a video file: ");
                videoUri = Console.ReadLine();
            }

            videoUri = videoUri.Trim('"');

            var probe = new FFProbe();
            var info = probe.GetMediaInfo(videoUri);
            Console.WriteLine($"Duration={info.Duration}");
            Console.WriteLine($"FormatName={info.FormatName}");
            Console.Write($"FormatTags=");
            foreach (var tag in info.FormatTags)
            {
                Console.Write($"{tag.Key}={tag.Value};");
            }
            Console.WriteLine($"");
            foreach (var stream in info.Streams)
            {
                Console.WriteLine($"Index={stream.Index}");
                Console.WriteLine($"CodecName={stream.CodecName}");
                Console.WriteLine($"CodecType={stream.CodecType}");
                Console.WriteLine($"FrameRate={stream.FrameRate}");
                Console.WriteLine($"Height={stream.Height}");
                Console.WriteLine($"Width={stream.Width}");
                Console.WriteLine($"PixelFormat={stream.PixelFormat}");

                Console.Write($"Tags=");
                foreach (var tag in stream.Tags)
                {
                    Console.Write($"{tag.Key}={tag.Value};");
                }
                Console.WriteLine($"");
            }
            Console.ReadKey();
        }
    }
}
