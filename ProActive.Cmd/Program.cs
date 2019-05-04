using ProActive.Lib;
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
            var videoUri = "";

            videoUri = @"D:\___ProActive\20181129 - Hyperlapse Depart GH010008 1080p10x.MP4";

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

            //new ParseVideo().ExtractMetadata(videoUri);
            new ParseVideo().PrintMetadata(videoUri);
            //new ParseVideo().CreateThumbnail(videoUri);
            Console.ReadKey();
        }
    }
}
