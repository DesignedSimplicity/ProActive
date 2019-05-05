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

            txtTitle.KeyPress += TextEdited;
            txtDate.KeyPress += TextEdited;
            txtTags.KeyPress += TextEdited;

            lblPath.Click += PickPath;
            cmdPath.Click += LoadPath;
            txtPath.KeyPress += EnterPath;
            cmdProcess.Click += ProcessBatch;
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
            _interface.PictureBox = picBox;
        }

        private void ProcessBatch(object sender, EventArgs e)
        {
            var batch = new Batch();
            batch.LoadBatch(_interface.PrepareBatch());
            batch.ShowDialog(this);
        }

        private void EnterPath(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoadPath(sender, e);
            }
        }

        private void PickPath(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folder.SelectedPath;
                LoadPath(sender, e);
            }
        }

        private void TextEdited(object sender, KeyPressEventArgs e)
        {
            // todo - toggle dirty
            var txt = (TextBox)sender;
            txt.BackColor = Color.LightYellow;
            if (e.KeyChar == (char)13)
            {
                _interface.SaveChanges();
            }
        }

        private void ShowThumbnail(object sender, EventArgs e)
        {
            var videoUri = trackBar.Tag.ToString();
            var thumb = _services.LoadThumb(videoUri, trackBar.Value * 60);
            if (picBox.Image != null) picBox.Image.Dispose();
            picBox.Image = thumb;
        }

        private void ShowLocation(object sender, EventArgs e)
        {
            var url = @"https://www.google.com/maps/search/?api=1&query=" + cmdLocation.Text.Replace("x", ",");
            System.Diagnostics.Process.Start(url);
        }

        private void SelectedVideos(object sender, EventArgs e)
        {
            if (lstVideos.SelectedItems.Count == 0)
            {
                _interface.SelectGroup(null);
            }
            else
            {
                _interface.SelectGroup(lstVideos.SelectedItems[0].Group);
            }
        }

        private void LoadPath(object sender, EventArgs e)
        {
            RefreshPath();
        }

        public void RefreshPath()
        {
            var pathUri = txtPath.Text.Trim();
            if (Directory.Exists(pathUri))
            {
                var videos = new List<GoProVideo>();
                foreach (var file in _services.FindVideos(pathUri))
                {
                    videos.Add(_services.LoadVideo(file, true));
                }
                var list = videos.OrderBy(x => x.Group).ThenBy(x => x.Index).ToList();
                _interface.ShowVideos(list);
            }
        }
    }
}
