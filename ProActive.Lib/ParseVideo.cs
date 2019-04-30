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

        private DateTime ExtractDateTime(string timestamp)
        {
            return DateTime.Parse(timestamp.Substring(0, 16).Replace('T', ' '));
        }

        private decimal ExtractLatitude(string location)
        {
            var split = location.IndexOfAny(new char[] { '-', '+' }, 1);
            var latitude = location.Substring(0, split);
            return Convert.ToDecimal(latitude);
        }

        private decimal ExtractLongitude(string location)
        {
            var split = location.IndexOfAny(new char[] { '-', '+' }, 1);
            var longitude = location.Substring(split).TrimEnd(new char[] { '/', ';' });
            return Convert.ToDecimal(longitude);
        }

        public GoProVideoInfo ExtractMetadata(string videoUri)
        {
            var data = new GoProVideoInfo();

            var probe = new FFProbe();
            var info = probe.GetMediaInfo(videoUri);

            data.VideoUri = videoUri;
            data.Duration = info.Duration;
            
            foreach (var tag in info.FormatTags)
            {
                switch (tag.Key.ToLowerInvariant())
                {
                    case "creation_time": // creation_time=2016-01-11T12:37:02.000000Z
                        data.Recorded = ExtractDateTime(tag.Value);
                        break;
                    case "location": // location=-45.0267+168.6460/;
                        data.Latitude = ExtractLatitude(tag.Value);
                        data.Longitude = ExtractLongitude(tag.Value);
                        break;
                }
            }

            var stream = info.Streams[0];
            data.CodecName = stream.CodecName;
            data.FrameRate = stream.FrameRate;
            data.Height = stream.Height;
            data.Width = stream.Width;

            foreach (var tag in stream.Tags)
            {
                switch (tag.Key.ToLowerInvariant())
                {
                    case "rotate":  // rotate=180
                        data.IsRotated = tag.Value == "180";
                        break;
                }
            }

            return data;
        }
    }
}
