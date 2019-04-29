using System;
using System.Collections.Generic;
using System.Text;
using NReco.VideoInfo;
using NReco.VideoConverter;
using System.Drawing;
using System.IO;

namespace ProActive.Lib
{
    public class ParseVideo
    {
        public Image ExtractThumbnail(string videoUri, float? frameTime = null)
        {
            var extract = new FFMpegConverter();
            using (
            var stream = new MemoryStream())
            {
                extract.GetVideoThumbnail(videoUri, stream, frameTime);
                return Image.FromStream(stream);
            }
        }

        public void CreateThumbnail(string videoUri, float? frameTime = null)
        {
            var thumbUri = videoUri + ".jpg";
            var extract = new FFMpegConverter();
            extract.GetVideoThumbnail(videoUri, thumbUri, frameTime);
        }

        public void PrintMetadata(string videoUri)
        {
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
        }
    }
}
