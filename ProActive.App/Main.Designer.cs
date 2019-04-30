namespace ProActive.App
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.txtPath = new System.Windows.Forms.ToolStripTextBox();
            this.cmdLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstVideos = new System.Windows.Forms.ListView();
            this.lstThumbs = new System.Windows.Forms.ListView();
            this.imgThumbs = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimestamp = new System.Windows.Forms.TextBox();
            this.lstMetadata = new System.Windows.Forms.ListBox();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtPath,
            this.cmdLoad});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(984, 27);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // txtPath
            // 
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(200, 23);
            // 
            // cmdLoad
            // 
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(45, 23);
            this.cmdLoad.Text = "Load";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstVideos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.lstThumbs);
            this.splitContainer1.Size = new System.Drawing.Size(984, 534);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 1;
            // 
            // lstVideos
            // 
            this.lstVideos.CheckBoxes = true;
            this.lstVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVideos.Location = new System.Drawing.Point(0, 0);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(250, 534);
            this.lstVideos.TabIndex = 0;
            this.lstVideos.UseCompatibleStateImageBehavior = false;
            this.lstVideos.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lstThumbs
            // 
            this.lstThumbs.BackColor = System.Drawing.SystemColors.WindowText;
            this.lstThumbs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstThumbs.ForeColor = System.Drawing.SystemColors.Window;
            this.lstThumbs.LargeImageList = this.imgThumbs;
            this.lstThumbs.Location = new System.Drawing.Point(0, 0);
            this.lstThumbs.Margin = new System.Windows.Forms.Padding(0);
            this.lstThumbs.Name = "lstThumbs";
            this.lstThumbs.Size = new System.Drawing.Size(730, 170);
            this.lstThumbs.TabIndex = 1;
            this.lstThumbs.UseCompatibleStateImageBehavior = false;
            // 
            // imgThumbs
            // 
            this.imgThumbs.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgThumbs.ImageSize = new System.Drawing.Size(256, 144);
            this.imgThumbs.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.lstMetadata);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 170);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(730, 364);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 28);
            this.panel1.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(73, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(277, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Video Title:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTimestamp);
            this.panel2.Location = new System.Drawing.Point(359, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 28);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date/Time:";
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimestamp.Location = new System.Drawing.Point(73, 3);
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.Size = new System.Drawing.Size(277, 20);
            this.txtTimestamp.TabIndex = 1;
            // 
            // lstMetadata
            // 
            this.lstMetadata.FormattingEnabled = true;
            this.lstMetadata.Location = new System.Drawing.Point(3, 37);
            this.lstMetadata.Name = "lstMetadata";
            this.lstMetadata.Size = new System.Drawing.Size(350, 186);
            this.lstMetadata.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Main";
            this.Text = "GoProActive";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripTextBox txtPath;
        private System.Windows.Forms.ToolStripMenuItem cmdLoad;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstVideos;
        private System.Windows.Forms.ListView lstThumbs;
        private System.Windows.Forms.ImageList imgThumbs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimestamp;
        private System.Windows.Forms.ListBox lstMetadata;
    }
}

