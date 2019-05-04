namespace ProActive
{
    partial class Batch
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
            this.lstBatch = new System.Windows.Forms.ListView();
            this.colInput = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOutput = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdProcess = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBatch
            // 
            this.lstBatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInput,
            this.colOutput,
            this.colStatus});
            this.lstBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstBatch.Location = new System.Drawing.Point(0, 0);
            this.lstBatch.Name = "lstBatch";
            this.lstBatch.Size = new System.Drawing.Size(584, 270);
            this.lstBatch.TabIndex = 0;
            this.lstBatch.UseCompatibleStateImageBehavior = false;
            this.lstBatch.View = System.Windows.Forms.View.Details;
            // 
            // colInput
            // 
            this.colInput.Text = "Input";
            // 
            // colOutput
            // 
            this.colOutput.Text = "Output";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // cmdProcess
            // 
            this.cmdProcess.Location = new System.Drawing.Point(416, 276);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(75, 23);
            this.cmdProcess.TabIndex = 1;
            this.cmdProcess.Text = "Process";
            this.cmdProcess.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(497, 276);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // Batch
            // 
            this.AcceptButton = this.cmdProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdProcess);
            this.Controls.Add(this.lstBatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Batch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Batch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstBatch;
        private System.Windows.Forms.ColumnHeader colInput;
        private System.Windows.Forms.ColumnHeader colOutput;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Button cmdProcess;
        private System.Windows.Forms.Button cmdCancel;
    }
}