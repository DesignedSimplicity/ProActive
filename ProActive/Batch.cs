using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProActive
{
    public partial class Batch : Form
    {
        public Batch()
        {
            InitializeComponent();

            cmdCancel.Click += CancelBatch;
            cmdProcess.Click += ProcessBatch;            
        }

        private void CancelBatch(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ProcessBatch(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lstBatch.Items)
            {
                try
                {
                    var source = item.Name;
                    var extension = Path.GetExtension(source);
                    var folder = Path.GetDirectoryName(source);
                    var rename = item.Tag.ToString() + extension;
                    var destination = Path.Combine(folder, rename);
                    File.Move(source, destination);

                    item.SubItems[2].Text = "Renamed!";
                }
                catch (Exception ex)
                {
                    item.SubItems[2].Text = $"Error: {ex.Message}";
                }
            }
            cmdProcess.Enabled = false;
            cmdCancel.Text = "Close";

            var main = (Main)this.Owner;
            main.RefreshPath();
        }

        public void LoadBatch(ProActiveBatch batch)
        {
            lstBatch.BeginUpdate();
            lstBatch.Items.Clear();
            foreach (var batchItem in batch.Queue.Values)
            {
                var batchSet = batchItem.GoProSet;
                foreach(var video in batchItem.Videos)
                {
                    var rename = $"{batchSet.Date} {batchSet.Title} {video.Name} {batchSet.Tags}";

                    var item = new ListViewItem();
                    item.Tag = rename;
                    item.Name = video.File.FullName;
                    item.Text = video.Name;
                    item.SubItems.Add(rename);
                    item.SubItems.Add("Queued");
                    lstBatch.Items.Add(item);
                }
            }
            lstBatch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstBatch.EndUpdate();
        }
    }
}
