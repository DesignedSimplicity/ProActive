using ProActive.Lib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProActive.App
{
    public class Engine
    {
        private Dictionary<string, GoProVideoInfo> _infoCache;
        private Dictionary<string, Image> _thumbsCache;
        private ParseVideo _parseVideo;

        private ListView _videosList;
        private ListView _thumbsList;
        private ImageList _thumbs;

        private TextBox _title;
        private TextBox _timestamp;
        private ListBox _metadata;

        public Engine(ListView videoList, 
            ListView thumbList, 
            ImageList thumbs,
            TextBox title,
            TextBox timestamp,
            ListBox metadata)
        {
            _infoCache = new Dictionary<string, GoProVideoInfo>();
            _thumbsCache = new Dictionary<string, Image>();
            _parseVideo = new ParseVideo();
            _videosList = videoList;
            _thumbsList = thumbList;
            _thumbs = thumbs;

            _title = title;
            _timestamp = timestamp;
            _metadata = metadata;
        }

        public void ShowSourceVideos(List<GoProVideo> sources)
        {
            _videosList.BeginUpdate();
            _videosList.Items.Clear();
            _videosList.Groups.Clear();

            foreach (var video in sources)
            {
                var group = _videosList.Groups[video.Group];
                if (group == null)
                {
                    group = _videosList.Groups.Add(video.Group, video.Group);
                }

                var videoItem = new ListViewItem();
                videoItem.Tag = video;
                videoItem.Checked = true;
                videoItem.Group = group;
                videoItem.Text = video.Name;
                videoItem.Name = video.File.FullName;
                _videosList.Items.Add(videoItem);
            }

            _videosList.EndUpdate();
        }

        public void SelectSourceVideos(IEnumerable<ListViewItem> items)
        {
            _thumbsList.BeginUpdate();
            _thumbsList.Clear();
            _thumbs.Images.Clear();

            GoProVideo mainVideo = null;
            GoProVideoInfo metaData = null;
            
            foreach (ListViewItem item in items)
            {
                var video = (GoProVideo)item.Tag;
                var videoUri = video.File.FullName;

                var thumb = LoadThumb(videoUri);
                _thumbs.Images.Add(video.Name, thumb);
                _thumbsList.Items.Add(new ListViewItem()
                {
                    ImageKey = video.Name
                });

                if (metaData == null)
                {
                    mainVideo = video;
                    metaData = LoadInfo(videoUri);
                }
            }

            _thumbsList.EndUpdate();

            ShowInfo(mainVideo, metaData);
        }

        private void ShowInfo(GoProVideo video, GoProVideoInfo info)
        {
            _title.Text = video.Group;
            _timestamp.Text = info.Recorded.ToString("yyyyMMdd-HHmm");

            _metadata.Items.Clear();
            _metadata.Items.Add($"Duration:\t{info.Duration}");
            _metadata.Items.Add($"CodecName:\t{info.CodecName}");
            _metadata.Items.Add($"FrameRate:\t{info.FrameRate}");
            _metadata.Items.Add($"Resolution:\t{info.Width}x{info.Height}");
            _metadata.Items.Add($"Location:\t{info.Latitude}x{info.Longitude}");
        }

        private GoProVideoInfo LoadInfo(string videoUri)
        {
            var key = videoUri.ToLowerInvariant();
            if (_infoCache.ContainsKey(key))
            {
                return _infoCache[key];
            }
            else
            {
                var info = _parseVideo.ExtractMetadata(videoUri);
                _infoCache.Add(key, info);
                return info;
            }
        }

        private Image LoadThumb(string videoUri)
        {
            var key = videoUri.ToLowerInvariant();
            if (_thumbsCache.ContainsKey(key))
            {
                return _thumbsCache[key];
            }
            else
            {
                var image = _parseVideo.ExtractThumbnail(videoUri);
                var thumb = image.GetThumbnailImage(_thumbs.ImageSize.Width, _thumbs.ImageSize.Height, null, IntPtr.Zero);
                _thumbsCache.Add(key, thumb);
                return thumb;
            }
        }
    }
}
