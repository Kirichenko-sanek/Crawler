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
            this.activGroupBox = new System.Windows.Forms.GroupBox();
            this.triathlon = new System.Windows.Forms.RadioButton();
            this.cucling = new System.Windows.Forms.RadioButton();
            this.folderButton = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBarResult = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.baseball = new System.Windows.Forms.RadioButton();
            this.basketball = new System.Windows.Forms.RadioButton();
            this.football = new System.Windows.Forms.RadioButton();
            this.golf = new System.Windows.Forms.RadioButton();
            this.martialArts = new System.Windows.Forms.RadioButton();
            this.soccer = new System.Windows.Forms.RadioButton();
            this.softball = new System.Windows.Forms.RadioButton();
            this.swimming = new System.Windows.Forms.RadioButton();
            this.tennis = new System.Windows.Forms.RadioButton();
            this.volleyball = new System.Windows.Forms.RadioButton();
            this.winterSports = new System.Windows.Forms.RadioButton();
            this.activGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(154, 200);
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
            // activGroupBox
            // 
            this.activGroupBox.Controls.Add(this.winterSports);
            this.activGroupBox.Controls.Add(this.volleyball);
            this.activGroupBox.Controls.Add(this.tennis);
            this.activGroupBox.Controls.Add(this.swimming);
            this.activGroupBox.Controls.Add(this.softball);
            this.activGroupBox.Controls.Add(this.soccer);
            this.activGroupBox.Controls.Add(this.martialArts);
            this.activGroupBox.Controls.Add(this.golf);
            this.activGroupBox.Controls.Add(this.football);
            this.activGroupBox.Controls.Add(this.basketball);
            this.activGroupBox.Controls.Add(this.baseball);
            this.activGroupBox.Controls.Add(this.triathlon);
            this.activGroupBox.Controls.Add(this.cucling);
            this.activGroupBox.Controls.Add(this.running);
            this.activGroupBox.Location = new System.Drawing.Point(12, 12);
            this.activGroupBox.Name = "activGroupBox";
            this.activGroupBox.Size = new System.Drawing.Size(316, 153);
            this.activGroupBox.TabIndex = 2;
            this.activGroupBox.TabStop = false;
            this.activGroupBox.Text = "active.com";
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
            this.folderButton.Location = new System.Drawing.Point(154, 171);
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
            this.folder.Location = new System.Drawing.Point(15, 194);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(35, 13);
            this.folder.TabIndex = 4;
            this.folder.Text = "label1";
            // 
            // progressBarResult
            // 
            this.progressBarResult.Location = new System.Drawing.Point(12, 229);
            this.progressBarResult.Name = "progressBarResult";
            this.progressBarResult.Size = new System.Drawing.Size(316, 23);
            this.progressBarResult.TabIndex = 5;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // baseball
            // 
            this.baseball.AutoSize = true;
            this.baseball.Location = new System.Drawing.Point(109, 19);
            this.baseball.Name = "baseball";
            this.baseball.Size = new System.Drawing.Size(65, 17);
            this.baseball.TabIndex = 4;
            this.baseball.Text = "Baseball";
            this.baseball.UseVisualStyleBackColor = true;
            this.baseball.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // basketball
            // 
            this.basketball.AutoSize = true;
            this.basketball.Location = new System.Drawing.Point(109, 42);
            this.basketball.Name = "basketball";
            this.basketball.Size = new System.Drawing.Size(74, 17);
            this.basketball.TabIndex = 5;
            this.basketball.Text = "Basketball";
            this.basketball.UseVisualStyleBackColor = true;
            this.basketball.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // football
            // 
            this.football.AutoSize = true;
            this.football.Location = new System.Drawing.Point(109, 65);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(62, 17);
            this.football.TabIndex = 6;
            this.football.Text = "Football";
            this.football.UseVisualStyleBackColor = true;
            this.football.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // golf
            // 
            this.golf.AutoSize = true;
            this.golf.Location = new System.Drawing.Point(109, 88);
            this.golf.Name = "golf";
            this.golf.Size = new System.Drawing.Size(44, 17);
            this.golf.TabIndex = 7;
            this.golf.Text = "Golf";
            this.golf.UseVisualStyleBackColor = true;
            this.golf.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // martialArts
            // 
            this.martialArts.AutoSize = true;
            this.martialArts.Location = new System.Drawing.Point(109, 111);
            this.martialArts.Name = "martialArts";
            this.martialArts.Size = new System.Drawing.Size(77, 17);
            this.martialArts.TabIndex = 8;
            this.martialArts.Text = "Martial Arts";
            this.martialArts.UseVisualStyleBackColor = true;
            this.martialArts.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // soccer
            // 
            this.soccer.AutoSize = true;
            this.soccer.Location = new System.Drawing.Point(109, 134);
            this.soccer.Name = "soccer";
            this.soccer.Size = new System.Drawing.Size(59, 17);
            this.soccer.TabIndex = 9;
            this.soccer.Text = "Soccer";
            this.soccer.UseVisualStyleBackColor = true;
            this.soccer.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // softball
            // 
            this.softball.AutoSize = true;
            this.softball.Location = new System.Drawing.Point(202, 19);
            this.softball.Name = "softball";
            this.softball.Size = new System.Drawing.Size(60, 17);
            this.softball.TabIndex = 10;
            this.softball.Text = "Softball";
            this.softball.UseVisualStyleBackColor = true;
            this.softball.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // swimming
            // 
            this.swimming.AutoSize = true;
            this.swimming.Location = new System.Drawing.Point(202, 42);
            this.swimming.Name = "swimming";
            this.swimming.Size = new System.Drawing.Size(72, 17);
            this.swimming.TabIndex = 11;
            this.swimming.Text = "Swimming";
            this.swimming.UseVisualStyleBackColor = true;
            this.swimming.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tennis
            // 
            this.tennis.AutoSize = true;
            this.tennis.Location = new System.Drawing.Point(202, 65);
            this.tennis.Name = "tennis";
            this.tennis.Size = new System.Drawing.Size(57, 17);
            this.tennis.TabIndex = 12;
            this.tennis.Text = "Tennis";
            this.tennis.UseVisualStyleBackColor = true;
            this.tennis.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // volleyball
            // 
            this.volleyball.AutoSize = true;
            this.volleyball.Location = new System.Drawing.Point(202, 88);
            this.volleyball.Name = "volleyball";
            this.volleyball.Size = new System.Drawing.Size(69, 17);
            this.volleyball.TabIndex = 13;
            this.volleyball.Text = "Volleyball";
            this.volleyball.UseVisualStyleBackColor = true;
            this.volleyball.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // winterSports
            // 
            this.winterSports.AutoSize = true;
            this.winterSports.Location = new System.Drawing.Point(202, 111);
            this.winterSports.Name = "winterSports";
            this.winterSports.Size = new System.Drawing.Size(89, 17);
            this.winterSports.TabIndex = 14;
            this.winterSports.Text = "Winter Sports";
            this.winterSports.UseVisualStyleBackColor = true;
            this.winterSports.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // CrawlerWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 274);
            this.Controls.Add(this.progressBarResult);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.activGroupBox);
            this.Controls.Add(this.Start);
            this.Name = "CrawlerWF";
            this.Text = "Crawler";
            this.activGroupBox.ResumeLayout(false);
            this.activGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RadioButton running;
        private System.Windows.Forms.GroupBox activGroupBox;
        private System.Windows.Forms.RadioButton triathlon;
        private System.Windows.Forms.RadioButton cucling;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Label folder;
        private System.Windows.Forms.FolderBrowserDialog fileDialog;
        private System.Windows.Forms.ProgressBar progressBarResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.RadioButton baseball;
        private System.Windows.Forms.RadioButton basketball;
        private System.Windows.Forms.RadioButton football;
        private System.Windows.Forms.RadioButton golf;
        private System.Windows.Forms.RadioButton martialArts;
        private System.Windows.Forms.RadioButton soccer;
        private System.Windows.Forms.RadioButton softball;
        private System.Windows.Forms.RadioButton swimming;
        private System.Windows.Forms.RadioButton tennis;
        private System.Windows.Forms.RadioButton volleyball;
        private System.Windows.Forms.RadioButton winterSports;
    }
}

