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
        private Engine _engine;
        public Main()
        {
            InitializeComponent();

            cmdLoad.Click += LoadPath;
            lstVideos.SelectedIndexChanged += SelectedVideos;

            _engine = new Engine(lstVideos, lstThumbs, imgThumbs);

            StartDebug();
        }

        private void StartDebug()
        {
            txtPath.Text = @"E:\_GoPro\20190212-QueenstownBike2";
            LoadPath(null, null);
        }

        private void SelectedVideos(object sender, EventArgs e)
        {
            var list = new List<ListViewItem>();
            foreach (ListViewItem item in lstVideos.SelectedItems)
            {
                list.Add(item);
            }
            _engine.SelectSourceVideos(list);
        }

        private void LoadPath(object sender, EventArgs e)
        {
            var pathUri = txtPath.Text;
            if (Directory.Exists(pathUri))
            {
                var fs = new FileSystem();
                var videos = fs.LoadVideos(pathUri);
                _engine.ShowSourceVideos(videos);
            }
        }
    }
}
