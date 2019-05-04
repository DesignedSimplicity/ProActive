using NReco.VideoConverter;
using NReco.VideoInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProActive
{
    public class Services
    {
        /// <summary>
        /// Loads all GoPro video files from the given path
        /// </summary>
        public List<FileInfo> FindVideos(string pathUri)
        {
            var files = new List<FileInfo>();
            var dir = new DirectoryInfo(pathUri);
            foreach (var file in dir.GetFiles())
            {
                // check GoPro file name format
                if (file.Extension.ToUpperInvariant() == ".MP4" && file.Name.Length == 12 && file.Name[0] == 'G')
                {
                    files.Add(file);
                }
            }
            return files;
        }

        /// <summary>
        /// Loads metadata about a video file
        /// </summary>
        public GoProVideo LoadVideo(FileInfo file, bool loadThumb = false)
        {
            var info = ExtractMetadata(file.FullName);
            var video = new GoProVideo(file, info);
            if (loadThumb)
            {
                video.Thumbnail = LoadThumb(file.FullName);
            }
            return video;
        }

        /// <summary>
        /// Extracts a thumbnail image from the video file
        /// </summary>
        public Image LoadThumb(string videoUri, float? frameTime = null)
        {
            var extract = new FFMpegConverter();
            using (var stream = new MemoryStream())
            {
                extract.GetVideoThumbnail(videoUri, stream, frameTime);
                return Image.FromStream(stream);
            }
        }


        private GoProVideoInfo ExtractMetadata(string videoUri)
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
                    case "firmware": //firmware=HD7.01.01.61.00
                        data.Firmware = tag.Value;
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

        public void DebugMetadata(string videoUri)
        {
            
        }

    }
}
