namespace Crawler.WF
{
    partial class CrawlerWF
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
            this.Start = new System.Windows.Forms.Button();
            this.running = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.triathlon = new System.Windows.Forms.RadioButton();
            this.cucling = new System.Windows.Forms.RadioButton();
            this.folderButton = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(160, 77);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(174, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // running
            // 
            this.running.AutoSize = true;
            this.running.Checked = true;
            this.running.Location = new System.Drawing.Point(6, 19);
            this.running.Name = "running";
            this.running.Size = new System.Drawing.Size(65, 17);
            this.running.TabIndex = 1;
            this.running.TabStop = true;
            this.running.Text = "Running";
            this.running.UseVisualStyleBackColor = true;
            this.running.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.triathlon);
            this.groupBox1.Controls.Add(this.cucling);
            this.groupBox1.Controls.Add(this.running);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "active.com";
            // 
            // triathlon
            // 
            this.triathlon.AutoSize = true;
            this.triathlon.Location = new System.Drawing.Point(6, 65);
            this.triathlon.Name = "triathlon";
            this.triathlon.Size = new System.Drawing.Size(66, 17);
            this.triathlon.TabIndex = 3;
            this.triathlon.Text = "Triathlon";
            this.triathlon.UseVisualStyleBackColor = true;
            this.triathlon.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // cucling
            // 
            this.cucling.AutoSize = true;
            this.cucling.Location = new System.Drawing.Point(6, 42);
            this.cucling.Name = "cucling";
            this.cucling.Size = new System.Drawing.Size(59, 17);
            this.cucling.TabIndex = 2;
            this.cucling.Text = "Cycling";
            this.cucling.UseVisualStyleBackColor = true;
            this.cucling.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(160, 28);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(174, 23);
            this.folderButton.TabIndex = 3;
            this.folderButton.Text = "Select folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // folder
            // 
            this.folder.AutoSize = true;
            this.folder.Location = new System.Drawing.Point(15, 111);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(35, 13);
            this.folder.TabIndex = 4;
            this.folder.Text = "label1";
            // 
            // CrawlerWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 133);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Start);
            this.Name = "CrawlerWF";
            this.Text = "Crawler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RadioButton running;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton triathlon;
        private System.Windows.Forms.RadioButton cucling;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Label folder;
        private System.Windows.Forms.FolderBrowserDialog fileDialog;
    }
}

