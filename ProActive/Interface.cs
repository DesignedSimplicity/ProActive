using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProActive
{
    public class Interface
    {
        public ImageList ImageList { get; set; }
        public ListView VideoList { get; set; }
        public TextBox Title { get; set; }
        public TextBox Date { get; set; }
        public TextBox Tags { get; set; }
        public ListBox Meta { get; set; }
        public Button Location { get; set; }
        public TrackBar TrackBar { get; set; }

        private string BuildTags(GoProVideoInfo info)
        {
            var tags = $"{info.Width}x{info.Height}x";
            tags += Math.Round(info.FrameRate, 0).ToString("00");
            //tags += info.CodecName;
            return tags;
        }

        public void ShowVideos(List<GoProVideo> videos)
        {
            VideoList.BeginUpdate();
            VideoList.Items.Clear();
            VideoList.Groups.Clear();
            ImageList.Images.Clear();

            foreach (var video in videos)
            {
                var group = VideoList.Groups[video.Group];
                if (group == null)
                {
                    group = VideoList.Groups.Add(video.Group, video.Group);
                    group.Tag = new GoProSet()
                    {
                        Title = video.Group,
                        Date = video.Info.Recorded.ToString("yyyyMMdd"),
                        Tags = BuildTags(video.Info),
                    };
                }

                var videoItem = new ListViewItem();
                videoItem.Tag = video;
                videoItem.Checked = true;
                videoItem.Group = group;
                videoItem.Text = video.Name;
                videoItem.Name = video.File.FullName;

                videoItem.ImageKey = video.Name;
                ImageList.Images.Add(videoItem.ImageKey,
                    video.Thumbnail.GetThumbnailImage(ImageList.ImageSize.Width, ImageList.ImageSize.Height, null, IntPtr.Zero));

                VideoList.Items.Add(videoItem);
            }

            VideoList.EndUpdate();
        }

        public void SelectGroup(ListViewGroup group)
        {
            Meta.Items.Clear();
            if (group == null)
            {
                Title.Text = "";
                Date.Text = "";
                Tags.Text = "";

                Location.Enabled = false;
                Location.Text = "Location";
                
                TrackBar.Enabled = false;
                TrackBar.Value = 0;
                TrackBar.Maximum = 0;

                foreach (ListViewItem item in VideoList.Items)
                {
                    item.ForeColor = SystemColors.ControlText;
                    item.BackColor = SystemColors.Control;
                }
            }
            else
            {
                var videoSet = (GoProSet)group.Tag;
                Title.Text = videoSet.Title;
                Date.Text = videoSet.Date;
                Tags.Text = videoSet.Tags;

                GoProVideoInfo info = null;
                var duration = TimeSpan.FromTicks(0);
                foreach (ListViewItem item in group.Items)
                {
                    item.ForeColor = SystemColors.HighlightText;
                    item.BackColor = SystemColors.Highlight;
                    if (item.Checked)
                    {
                        var video = (GoProVideo)item.Tag;
                        duration += video.Info.Duration;
                        if (info == null) info = video.Info;
                    }
                }

                Meta.Items.Add($"Duration:\t\t{duration.Hours} h {duration.Minutes} m {duration.Seconds} s");
                if (info != null)
                {
                    TrackBar.Enabled = true;
                    TrackBar.Maximum = Convert.ToInt32(info.Duration.TotalMinutes);
                    Meta.Items.Add($"Resolution:\t{info.Width}x{info.Height}");
                    Meta.Items.Add($"Compression:\t{info.FrameRate.ToString("0.0")} FPS {info.CodecName}");
                    Meta.Items.Add($"Firmware:\t\t{info.Firmware}");
                }

                if (info.Latitude.HasValue && info.Longitude.HasValue)
                {
                    Location.Enabled = true;
                    Location.Text = $"{info.Latitude.Value.ToString("0.0000")}x{info.Longitude.Value.ToString("0.0000")}";
                }
            }
        }
    }
}
