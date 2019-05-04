namespace ProActive
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.lblPath = new System.Windows.Forms.ToolStripLabel();
            this.txtPath = new System.Windows.Forms.ToolStripTextBox();
            this.cmdPath = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lstVideos = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cmdLocation = new System.Windows.Forms.Button();
            this.lstMeta = new System.Windows.Forms.ListBox();
            this.grpTags = new System.Windows.Forms.GroupBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.grpTimestamp = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.grpTitle = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmdProcess = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.grpTags.SuspendLayout();
            this.grpTimestamp.SuspendLayout();
            this.grpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPath,
            this.txtPath,
            this.cmdPath,
            this.toolStripSeparator1,
            this.cmdProcess});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // lblPath
            // 
            this.lblPath.IsLink = true;
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(34, 22);
            this.lblPath.Text = "Path:";
            // 
            // txtPath
            // 
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(500, 25);
            // 
            // cmdPath
            // 
            this.cmdPath.Image = ((System.Drawing.Image)(resources.GetObject("cmdPath.Image")));
            this.cmdPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPath.Name = "cmdPath";
            this.cmdPath.Size = new System.Drawing.Size(53, 22);
            this.cmdPath.Text = "Load";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lstVideos);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.trackBar);
            this.splitContainer.Panel2.Controls.Add(this.picBox);
            this.splitContainer.Panel2.Controls.Add(this.cmdLocation);
            this.splitContainer.Panel2.Controls.Add(this.lstMeta);
            this.splitContainer.Panel2.Controls.Add(this.grpTags);
            this.splitContainer.Panel2.Controls.Add(this.grpTimestamp);
            this.splitContainer.Panel2.Controls.Add(this.grpTitle);
            this.splitContainer.Size = new System.Drawing.Size(1184, 636);
            this.splitContainer.SplitterDistance = 592;
            this.splitContainer.TabIndex = 3;
            // 
            // lstVideos
            // 
            this.lstVideos.CheckBoxes = true;
            this.lstVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVideos.LargeImageList = this.imageList;
            this.lstVideos.Location = new System.Drawing.Point(0, 0);
            this.lstVideos.MultiSelect = false;
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.ShowItemToolTips = true;
            this.lstVideos.Size = new System.Drawing.Size(592, 636);
            this.lstVideos.TabIndex = 0;
            this.lstVideos.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(160, 90);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.Enabled = false;
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(7, 588);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(569, 45);
            this.trackBar.TabIndex = 6;
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.BackColor = System.Drawing.Color.Black;
            this.picBox.Location = new System.Drawing.Point(7, 219);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(569, 363);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // cmdLocation
            // 
            this.cmdLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLocation.Enabled = false;
            this.cmdLocation.Location = new System.Drawing.Point(296, 156);
            this.cmdLocation.Name = "cmdLocation";
            this.cmdLocation.Size = new System.Drawing.Size(280, 56);
            this.cmdLocation.TabIndex = 4;
            this.cmdLocation.Text = "Location";
            this.cmdLocation.UseVisualStyleBackColor = true;
            // 
            // lstMeta
            // 
            this.lstMeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMeta.FormattingEnabled = true;
            this.lstMeta.Location = new System.Drawing.Point(7, 156);
            this.lstMeta.Name = "lstMeta";
            this.lstMeta.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstMeta.Size = new System.Drawing.Size(280, 56);
            this.lstMeta.TabIndex = 3;
            // 
            // grpTags
            // 
            this.grpTags.Controls.Add(this.txtTags);
            this.grpTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTags.Location = new System.Drawing.Point(0, 100);
            this.grpTags.Name = "grpTags";
            this.grpTags.Size = new System.Drawing.Size(588, 50);
            this.grpTags.TabIndex = 2;
            this.grpTags.TabStop = false;
            this.grpTags.Text = "Meta Tags:";
            // 
            // txtTags
            // 
            this.txtTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTags.Location = new System.Drawing.Point(7, 20);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(569, 20);
            this.txtTags.TabIndex = 0;
            // 
            // grpTimestamp
            // 
            this.grpTimestamp.Controls.Add(this.txtDate);
            this.grpTimestamp.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTimestamp.Location = new System.Drawing.Point(0, 50);
            this.grpTimestamp.Name = "grpTimestamp";
            this.grpTimestamp.Size = new System.Drawing.Size(588, 50);
            this.grpTimestamp.TabIndex = 1;
            this.grpTimestamp.TabStop = false;
            this.grpTimestamp.Text = "Date/Time:";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Location = new System.Drawing.Point(7, 20);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(569, 20);
            this.txtDate.TabIndex = 0;
            // 
            // grpTitle
            // 
            this.grpTitle.Controls.Add(this.txtTitle);
            this.grpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTitle.Location = new System.Drawing.Point(0, 0);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(588, 50);
            this.grpTitle.TabIndex = 0;
            this.grpTitle.TabStop = false;
            this.grpTitle.Text = "Video Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(7, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(569, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // cmdProcess
            // 
            this.cmdProcess.Image = ((System.Drawing.Image)(resources.GetObject("cmdProcess.Image")));
            this.cmdProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(100, 22);
            this.cmdProcess.Text = "Process Batch";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProActive";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.grpTags.ResumeLayout(false);
            this.grpTags.PerformLayout();
            this.grpTimestamp.ResumeLayout(false);
            this.grpTimestamp.PerformLayout();
            this.grpTitle.ResumeLayout(false);
            this.grpTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel lblPath;
        private System.Windows.Forms.ToolStripTextBox txtPath;
        private System.Windows.Forms.ToolStripButton cmdPath;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView lstVideos;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox grpTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox grpTimestamp;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox grpTags;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.ListBox lstMeta;
        private System.Windows.Forms.Button cmdLocation;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdProcess;
    }
}

