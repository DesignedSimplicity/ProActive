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
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.txtPath.Size = new System.Drawing.Size(256, 23);
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
            this.splitContainer1.Panel2.Controls.Add(this.lstThumbs);
            this.splitContainer1.Size = new System.Drawing.Size(984, 534);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 1;
            // 
            // lstVideos
            // 
            this.lstVideos.CheckBoxes = true;
            this.lstVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVideos.Location = new System.Drawing.Point(0, 0);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(328, 534);
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
            this.lstThumbs.Size = new System.Drawing.Size(652, 170);
            this.lstThumbs.TabIndex = 1;
            this.lstThumbs.UseCompatibleStateImageBehavior = false;
            // 
            // imgThumbs
            // 
            this.imgThumbs.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgThumbs.ImageSize = new System.Drawing.Size(256, 144);
            this.imgThumbs.TransparentColor = System.Drawing.Color.Transparent;
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
    }
}

