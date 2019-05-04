using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProActive
{
    public partial class Main : Form
    {
        private Services _services = new Services();
        private Interface _interface = new Interface();

        public Main()
        {
            InitializeComponent();

            cmdPath.Click += LoadPath;
            cmdLocation.Click += ShowLocation;
            trackBar.ValueChanged += ShowThumbnail;
            lstVideos.SelectedIndexChanged += SelectedVideos;

            _interface.ImageList = imageList;
            _interface.VideoList = lstVideos;
            _interface.Title = txtTitle;
            _interface.Date = txtDate;
            _interface.Tags = txtTags;
            _interface.Meta = lstMeta;
            _interface.Location = cmdLocation;
            _interface.TrackBar = trackBar;

            StartDebug();
        }

        private void ShowThumbnail(object sender, EventArgs e)
        {
            var videoUri = lstVideos.SelectedItems[0].Name;
            var thumb = _services.LoadThumb(videoUri, trackBar.Value);
            picBox.Image = thumb;
        }

        private void ShowLocation(object sender, EventArgs e)
        {
            var url = @"https://www.google.com/maps/search/?api=1&query=" + cmdLocation.Text.Replace("x", ",");
            System.Diagnostics.Process.Start(url);
        }

        private void StartDebug()
        {
            txtPath.Text = @"D:\___ProActive";
            LoadPath(null, null);
        }

        private void SelectedVideos(object sender, EventArgs e)
        {
            var list = new List<ListViewItem>();
            if (lstVideos.SelectedItems.Count == 0)
            {
                // clear list
                _interface.SelectGroup(null);
            }
            else
            {
                _interface.SelectGroup(lstVideos.SelectedItems[0].Group);
            }
        }

        private void LoadPath(object sender, EventArgs e)
        {
            var pathUri = txtPath.Text;
            if (Directory.Exists(pathUri))
            {
                var videos = new List<GoProVideo>();
                foreach(var file in _services.FindVideos(pathUri))
                {
                    videos.Add(_services.LoadVideo(file, true));
                }
                var list = videos.OrderBy(x => x.Group).ThenBy(x => x.Index).ToList();
                _interface.ShowVideos(list);
            }
        }
    }
}
