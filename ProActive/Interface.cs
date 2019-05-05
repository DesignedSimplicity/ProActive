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
        public PictureBox PictureBox { get; set; }

        private GoProSet _selectedSet = null;

        private string BuildTags(GoProVideoInfo info)
        {
            var tags = $"{info.Width}x{info.Height}x";
            tags += Math.Round(info.FrameRate, 0).ToString("00");
            //tags += info.CodecName;
            return tags;
        }

        public void SaveChanges()
        {
            if (_selectedSet != null)
            {
                _selectedSet.Title = Title.Text;
                _selectedSet.Date = Date.Text;
                _selectedSet.Tags = Tags.Text;

                Title.BackColor = SystemColors.Window;
                Date.BackColor = SystemColors.Window;
                Tags.BackColor = SystemColors.Window;
            }
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
                videoItem.ToolTipText = $"Duration: {video.Info.Duration.Hours} h {video.Info.Duration.Minutes} m {video.Info.Duration.Seconds} s";

                videoItem.ImageKey = video.Name;
                ImageList.Images.Add(videoItem.ImageKey,
                    video.Thumbnail.GetThumbnailImage(ImageList.ImageSize.Width, ImageList.ImageSize.Height, null, IntPtr.Zero));

                VideoList.Items.Add(videoItem);
            }

            VideoList.EndUpdate();
        }

        public void SelectGroup(ListViewGroup group)
        {
            // clear list
            if (PictureBox.Image != null)
            {
                PictureBox.Image.Dispose();
                PictureBox.Image = null;
            }

            Meta.Items.Clear();
            if (group == null)
            {
                _selectedSet = null;

                Title.BackColor = SystemColors.Window;
                Date.BackColor = SystemColors.Window;
                Tags.BackColor = SystemColors.Window;

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
                _selectedSet = (GoProSet)group.Tag;
                Title.Text = _selectedSet.Title;
                Date.Text = _selectedSet.Date;
                Tags.Text = _selectedSet.Tags;

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
                        if (info == null)
                        {
                            info = video.Info;
                            TrackBar.Tag = video.File.FullName;
                            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            PictureBox.Image = (Image)video.Thumbnail.Clone();
                        }
                    }
                }

                Meta.Items.Add($"Duration:\t\t{duration.Hours} h {duration.Minutes} m {duration.Seconds} s");
                if (info != null)
                {
                    TrackBar.Enabled = true;
                    TrackBar.Maximum = Convert.ToInt32(Math.Floor(info.Duration.TotalMinutes));
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

        public ProActiveBatch PrepareBatch()
        {
            var batch = new ProActiveBatch();
            foreach (ListViewItem item in VideoList.Items)
            {
                var video = (GoProVideo)item.Tag;
                
                if (item.Checked)
                {
                    if (!batch.Queue.ContainsKey(video.Group))
                    {
                        batch.Queue.Add(video.Group, new ProActiveSet());
                    }
                    var batchSet = batch.Queue[video.Group];
                    batchSet.GoProSet = (GoProSet)item.Group.Tag;
                    batchSet.Videos.Add(video);
                }
                else
                {
                    batch.Exclude.Add(video);
                }
            }
            return batch;
        }
    }
}
