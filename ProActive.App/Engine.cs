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
        private Dictionary<string, Image> _thumbsCache;
        private ParseVideo _parseVideo;

        private ListView _videosList;
        private ListView _thumbsList;
        private ImageList _thumbs;

        public Engine(ListView videoList, ListView thumbList, ImageList thumbs)
        {
            _thumbsCache = new Dictionary<string, Image>();
            _parseVideo = new ParseVideo();
            _videosList = videoList;
            _thumbsList = thumbList;
            _thumbs = thumbs;
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

            
            foreach (ListViewItem item in items)
            {
                var video = (GoProVideo)item.Tag;
                var thumb = LoadThumb(video.File.FullName);
                _thumbs.Images.Add(video.Name, thumb);
                _thumbsList.Items.Add(new ListViewItem()
                {
                    ImageKey = video.Name
                });
            }

            _thumbsList.EndUpdate();
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
