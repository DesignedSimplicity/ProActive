using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProActive.Lib;

namespace ProActive.App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


            cmdLoad.Click += LoadPath;
            lstVideos.SelectedIndexChanged += SelectedVideos;


            StartDebug();
        }

        private void StartDebug()
        {
            txtPath.Text = @"E:\_GoPro\20190212-QueenstownBike2";
            LoadPath(null, null);
        }

        private void SelectedVideos(object sender, EventArgs e)
        {
            lstThumbs.Clear();
            imgThumbs.Images.Clear();
           

            var thumbs = new ParseVideo();
            foreach (ListViewItem item in lstVideos.SelectedItems)
            {
                var video = (GoProVideo)item.Tag;
                var thumb = thumbs.ExtractThumbnail(video.File.FullName);
                imgThumbs.Images.Add(video.Name, thumb);
                lstThumbs.Items.Add(new ListViewItem()
                {
                    ImageKey = video.Name
                });
            }
            
        }        

        private void LoadPath(object sender, EventArgs e)
        {
            lstVideos.Items.Clear();
            lstVideos.Groups.Clear();

            var pathUri = txtPath.Text;
            if (Directory.Exists(pathUri))
            {
                var fs = new FileSystem();
                var videos = fs.LoadVideos(pathUri);
                foreach(var video in videos)
                {
                    var group = lstVideos.Groups[video.Group];
                    if (group == null)
                    {
                        group = lstVideos.Groups.Add(video.Group, video.Group);
                    }

                    var videoItem = new ListViewItem();
                    videoItem.Tag = video;
                    videoItem.Checked = true;
                    videoItem.Group = group;
                    videoItem.Text = video.Name;
                    videoItem.Name = video.File.FullName;
                    lstVideos.Items.Add(videoItem);
                }
            }
        }
    }
}
