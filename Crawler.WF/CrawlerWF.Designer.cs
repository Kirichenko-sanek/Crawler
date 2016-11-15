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
            this.winterSports = new System.Windows.Forms.RadioButton();
            this.volleyball = new System.Windows.Forms.RadioButton();
            this.tennis = new System.Windows.Forms.RadioButton();
            this.swimming = new System.Windows.Forms.RadioButton();
            this.softball = new System.Windows.Forms.RadioButton();
            this.soccer = new System.Windows.Forms.RadioButton();
            this.martialArts = new System.Windows.Forms.RadioButton();
            this.golf = new System.Windows.Forms.RadioButton();
            this.football = new System.Windows.Forms.RadioButton();
            this.basketball = new System.Windows.Forms.RadioButton();
            this.baseball = new System.Windows.Forms.RadioButton();
            this.triathlon = new System.Windows.Forms.RadioButton();
            this.cucling = new System.Windows.Forms.RadioButton();
            this.folderButton = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBarResult = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.fitness = new System.Windows.Forms.RadioButton();
            this.outdoors = new System.Windows.Forms.RadioButton();
            this.activKidsGroupBox = new System.Windows.Forms.GroupBox();
            this.basketballKids = new System.Windows.Forms.RadioButton();
            this.baseballKids = new System.Windows.Forms.RadioButton();
            this.softballKids = new System.Windows.Forms.RadioButton();
            this.footballKids = new System.Windows.Forms.RadioButton();
            this.hockeyKids = new System.Windows.Forms.RadioButton();
            this.lacrosseKids = new System.Windows.Forms.RadioButton();
            this.soccerKids = new System.Windows.Forms.RadioButton();
            this.volleyballKids = new System.Windows.Forms.RadioButton();
            this.runningKids = new System.Windows.Forms.RadioButton();
            this.swimmingKids = new System.Windows.Forms.RadioButton();
            this.lifeguardingKids = new System.Windows.Forms.RadioButton();
            this.skatingKids = new System.Windows.Forms.RadioButton();
            this.martialArtsKids = new System.Windows.Forms.RadioButton();
            this.fitnessKids = new System.Windows.Forms.RadioButton();
            this.yogaKids = new System.Windows.Forms.RadioButton();
            this.zumbaKids = new System.Windows.Forms.RadioButton();
            this.golfKids = new System.Windows.Forms.RadioButton();
            this.tennisKids = new System.Windows.Forms.RadioButton();
            this.activGroupBox.SuspendLayout();
            this.activKidsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(158, 198);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(132, 23);
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
            this.activGroupBox.Controls.Add(this.outdoors);
            this.activGroupBox.Controls.Add(this.fitness);
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
            this.activGroupBox.Size = new System.Drawing.Size(278, 153);
            this.activGroupBox.TabIndex = 2;
            this.activGroupBox.TabStop = false;
            this.activGroupBox.Text = "active.com";
            // 
            // winterSports
            // 
            this.winterSports.AutoSize = true;
            this.winterSports.Location = new System.Drawing.Point(178, 111);
            this.winterSports.Name = "winterSports";
            this.winterSports.Size = new System.Drawing.Size(89, 17);
            this.winterSports.TabIndex = 14;
            this.winterSports.Text = "Winter Sports";
            this.winterSports.UseVisualStyleBackColor = true;
            this.winterSports.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // volleyball
            // 
            this.volleyball.AutoSize = true;
            this.volleyball.Location = new System.Drawing.Point(178, 88);
            this.volleyball.Name = "volleyball";
            this.volleyball.Size = new System.Drawing.Size(69, 17);
            this.volleyball.TabIndex = 13;
            this.volleyball.Text = "Volleyball";
            this.volleyball.UseVisualStyleBackColor = true;
            this.volleyball.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tennis
            // 
            this.tennis.AutoSize = true;
            this.tennis.Location = new System.Drawing.Point(178, 65);
            this.tennis.Name = "tennis";
            this.tennis.Size = new System.Drawing.Size(57, 17);
            this.tennis.TabIndex = 12;
            this.tennis.Text = "Tennis";
            this.tennis.UseVisualStyleBackColor = true;
            this.tennis.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // swimming
            // 
            this.swimming.AutoSize = true;
            this.swimming.Location = new System.Drawing.Point(178, 42);
            this.swimming.Name = "swimming";
            this.swimming.Size = new System.Drawing.Size(72, 17);
            this.swimming.TabIndex = 11;
            this.swimming.Text = "Swimming";
            this.swimming.UseVisualStyleBackColor = true;
            this.swimming.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // softball
            // 
            this.softball.AutoSize = true;
            this.softball.Location = new System.Drawing.Point(178, 19);
            this.softball.Name = "softball";
            this.softball.Size = new System.Drawing.Size(60, 17);
            this.softball.TabIndex = 10;
            this.softball.Text = "Softball";
            this.softball.UseVisualStyleBackColor = true;
            this.softball.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // soccer
            // 
            this.soccer.AutoSize = true;
            this.soccer.Location = new System.Drawing.Point(88, 134);
            this.soccer.Name = "soccer";
            this.soccer.Size = new System.Drawing.Size(59, 17);
            this.soccer.TabIndex = 9;
            this.soccer.Text = "Soccer";
            this.soccer.UseVisualStyleBackColor = true;
            this.soccer.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // martialArts
            // 
            this.martialArts.AutoSize = true;
            this.martialArts.Location = new System.Drawing.Point(88, 111);
            this.martialArts.Name = "martialArts";
            this.martialArts.Size = new System.Drawing.Size(77, 17);
            this.martialArts.TabIndex = 8;
            this.martialArts.Text = "Martial Arts";
            this.martialArts.UseVisualStyleBackColor = true;
            this.martialArts.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // golf
            // 
            this.golf.AutoSize = true;
            this.golf.Location = new System.Drawing.Point(88, 88);
            this.golf.Name = "golf";
            this.golf.Size = new System.Drawing.Size(44, 17);
            this.golf.TabIndex = 7;
            this.golf.Text = "Golf";
            this.golf.UseVisualStyleBackColor = true;
            this.golf.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // football
            // 
            this.football.AutoSize = true;
            this.football.Location = new System.Drawing.Point(88, 65);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(62, 17);
            this.football.TabIndex = 6;
            this.football.Text = "Football";
            this.football.UseVisualStyleBackColor = true;
            this.football.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // basketball
            // 
            this.basketball.AutoSize = true;
            this.basketball.Location = new System.Drawing.Point(88, 42);
            this.basketball.Name = "basketball";
            this.basketball.Size = new System.Drawing.Size(74, 17);
            this.basketball.TabIndex = 5;
            this.basketball.Text = "Basketball";
            this.basketball.UseVisualStyleBackColor = true;
            this.basketball.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // baseball
            // 
            this.baseball.AutoSize = true;
            this.baseball.Location = new System.Drawing.Point(88, 19);
            this.baseball.Name = "baseball";
            this.baseball.Size = new System.Drawing.Size(65, 17);
            this.baseball.TabIndex = 4;
            this.baseball.Text = "Baseball";
            this.baseball.UseVisualStyleBackColor = true;
            this.baseball.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
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
            this.folderButton.Location = new System.Drawing.Point(12, 198);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(132, 23);
            this.folderButton.TabIndex = 3;
            this.folderButton.Text = "Select folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // folder
            // 
            this.folder.AutoSize = true;
            this.folder.Location = new System.Drawing.Point(15, 176);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(35, 13);
            this.folder.TabIndex = 4;
            this.folder.Text = "label1";
            // 
            // progressBarResult
            // 
            this.progressBarResult.Location = new System.Drawing.Point(12, 229);
            this.progressBarResult.Name = "progressBarResult";
            this.progressBarResult.Size = new System.Drawing.Size(278, 23);
            this.progressBarResult.TabIndex = 5;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // fitness
            // 
            this.fitness.AutoSize = true;
            this.fitness.Location = new System.Drawing.Point(6, 88);
            this.fitness.Name = "fitness";
            this.fitness.Size = new System.Drawing.Size(58, 17);
            this.fitness.TabIndex = 15;
            this.fitness.Text = "Fitness";
            this.fitness.UseVisualStyleBackColor = true;
            // 
            // outdoors
            // 
            this.outdoors.AutoSize = true;
            this.outdoors.Location = new System.Drawing.Point(6, 111);
            this.outdoors.Name = "outdoors";
            this.outdoors.Size = new System.Drawing.Size(68, 17);
            this.outdoors.TabIndex = 16;
            this.outdoors.Text = "Outdoors";
            this.outdoors.UseVisualStyleBackColor = true;
            // 
            // activKidsGroupBox
            // 
            this.activKidsGroupBox.Controls.Add(this.tennisKids);
            this.activKidsGroupBox.Controls.Add(this.golfKids);
            this.activKidsGroupBox.Controls.Add(this.zumbaKids);
            this.activKidsGroupBox.Controls.Add(this.yogaKids);
            this.activKidsGroupBox.Controls.Add(this.fitnessKids);
            this.activKidsGroupBox.Controls.Add(this.martialArtsKids);
            this.activKidsGroupBox.Controls.Add(this.skatingKids);
            this.activKidsGroupBox.Controls.Add(this.lifeguardingKids);
            this.activKidsGroupBox.Controls.Add(this.swimmingKids);
            this.activKidsGroupBox.Controls.Add(this.runningKids);
            this.activKidsGroupBox.Controls.Add(this.volleyballKids);
            this.activKidsGroupBox.Controls.Add(this.soccerKids);
            this.activKidsGroupBox.Controls.Add(this.lacrosseKids);
            this.activKidsGroupBox.Controls.Add(this.hockeyKids);
            this.activKidsGroupBox.Controls.Add(this.footballKids);
            this.activKidsGroupBox.Controls.Add(this.softballKids);
            this.activKidsGroupBox.Controls.Add(this.baseballKids);
            this.activKidsGroupBox.Controls.Add(this.basketballKids);
            this.activKidsGroupBox.Location = new System.Drawing.Point(320, 12);
            this.activKidsGroupBox.Name = "activKidsGroupBox";
            this.activKidsGroupBox.Size = new System.Drawing.Size(389, 153);
            this.activKidsGroupBox.TabIndex = 6;
            this.activKidsGroupBox.TabStop = false;
            this.activKidsGroupBox.Text = "activekids.com";
            // 
            // basketballKids
            // 
            this.basketballKids.AutoSize = true;
            this.basketballKids.Location = new System.Drawing.Point(6, 19);
            this.basketballKids.Name = "basketballKids";
            this.basketballKids.Size = new System.Drawing.Size(74, 17);
            this.basketballKids.TabIndex = 6;
            this.basketballKids.Text = "Basketball";
            this.basketballKids.UseVisualStyleBackColor = true;
            // 
            // baseballKids
            // 
            this.baseballKids.AutoSize = true;
            this.baseballKids.Location = new System.Drawing.Point(6, 42);
            this.baseballKids.Name = "baseballKids";
            this.baseballKids.Size = new System.Drawing.Size(65, 17);
            this.baseballKids.TabIndex = 7;
            this.baseballKids.Text = "Baseball";
            this.baseballKids.UseVisualStyleBackColor = true;
            // 
            // softballKids
            // 
            this.softballKids.AutoSize = true;
            this.softballKids.Location = new System.Drawing.Point(6, 65);
            this.softballKids.Name = "softballKids";
            this.softballKids.Size = new System.Drawing.Size(60, 17);
            this.softballKids.TabIndex = 11;
            this.softballKids.Text = "Softball";
            this.softballKids.UseVisualStyleBackColor = true;
            // 
            // footballKids
            // 
            this.footballKids.AutoSize = true;
            this.footballKids.Location = new System.Drawing.Point(6, 88);
            this.footballKids.Name = "footballKids";
            this.footballKids.Size = new System.Drawing.Size(62, 17);
            this.footballKids.TabIndex = 12;
            this.footballKids.Text = "Football";
            this.footballKids.UseVisualStyleBackColor = true;
            // 
            // hockeyKids
            // 
            this.hockeyKids.AutoSize = true;
            this.hockeyKids.Location = new System.Drawing.Point(6, 111);
            this.hockeyKids.Name = "hockeyKids";
            this.hockeyKids.Size = new System.Drawing.Size(62, 17);
            this.hockeyKids.TabIndex = 13;
            this.hockeyKids.Text = "Hockey";
            this.hockeyKids.UseVisualStyleBackColor = true;
            // 
            // lacrosseKids
            // 
            this.lacrosseKids.AutoSize = true;
            this.lacrosseKids.Location = new System.Drawing.Point(6, 134);
            this.lacrosseKids.Name = "lacrosseKids";
            this.lacrosseKids.Size = new System.Drawing.Size(68, 17);
            this.lacrosseKids.TabIndex = 14;
            this.lacrosseKids.Text = "Lacrosse";
            this.lacrosseKids.UseVisualStyleBackColor = true;
            // 
            // soccerKids
            // 
            this.soccerKids.AutoSize = true;
            this.soccerKids.Location = new System.Drawing.Point(97, 19);
            this.soccerKids.Name = "soccerKids";
            this.soccerKids.Size = new System.Drawing.Size(59, 17);
            this.soccerKids.TabIndex = 15;
            this.soccerKids.Text = "Soccer";
            this.soccerKids.UseVisualStyleBackColor = true;
            // 
            // volleyballKids
            // 
            this.volleyballKids.AutoSize = true;
            this.volleyballKids.Location = new System.Drawing.Point(97, 42);
            this.volleyballKids.Name = "volleyballKids";
            this.volleyballKids.Size = new System.Drawing.Size(69, 17);
            this.volleyballKids.TabIndex = 16;
            this.volleyballKids.Text = "Volleyball";
            this.volleyballKids.UseVisualStyleBackColor = true;
            // 
            // runningKids
            // 
            this.runningKids.AutoSize = true;
            this.runningKids.Location = new System.Drawing.Point(97, 65);
            this.runningKids.Name = "runningKids";
            this.runningKids.Size = new System.Drawing.Size(65, 17);
            this.runningKids.TabIndex = 17;
            this.runningKids.Text = "Running";
            this.runningKids.UseVisualStyleBackColor = true;
            // 
            // swimmingKids
            // 
            this.swimmingKids.AutoSize = true;
            this.swimmingKids.Location = new System.Drawing.Point(97, 88);
            this.swimmingKids.Name = "swimmingKids";
            this.swimmingKids.Size = new System.Drawing.Size(72, 17);
            this.swimmingKids.TabIndex = 18;
            this.swimmingKids.Text = "Swimming";
            this.swimmingKids.UseVisualStyleBackColor = true;
            // 
            // lifeguardingKids
            // 
            this.lifeguardingKids.AutoSize = true;
            this.lifeguardingKids.Location = new System.Drawing.Point(97, 111);
            this.lifeguardingKids.Name = "lifeguardingKids";
            this.lifeguardingKids.Size = new System.Drawing.Size(83, 17);
            this.lifeguardingKids.TabIndex = 19;
            this.lifeguardingKids.Text = "Lifeguarding";
            this.lifeguardingKids.UseVisualStyleBackColor = true;
            // 
            // skatingKids
            // 
            this.skatingKids.AutoSize = true;
            this.skatingKids.Location = new System.Drawing.Point(97, 134);
            this.skatingKids.Name = "skatingKids";
            this.skatingKids.Size = new System.Drawing.Size(61, 17);
            this.skatingKids.TabIndex = 20;
            this.skatingKids.Text = "Skating";
            this.skatingKids.UseVisualStyleBackColor = true;
            // 
            // martialArtsKids
            // 
            this.martialArtsKids.AutoSize = true;
            this.martialArtsKids.Location = new System.Drawing.Point(177, 19);
            this.martialArtsKids.Name = "martialArtsKids";
            this.martialArtsKids.Size = new System.Drawing.Size(77, 17);
            this.martialArtsKids.TabIndex = 21;
            this.martialArtsKids.Text = "Martial Arts";
            this.martialArtsKids.UseVisualStyleBackColor = true;
            // 
            // fitnessKids
            // 
            this.fitnessKids.AutoSize = true;
            this.fitnessKids.Location = new System.Drawing.Point(177, 42);
            this.fitnessKids.Name = "fitnessKids";
            this.fitnessKids.Size = new System.Drawing.Size(58, 17);
            this.fitnessKids.TabIndex = 22;
            this.fitnessKids.Text = "Fitness";
            this.fitnessKids.UseVisualStyleBackColor = true;
            // 
            // yogaKids
            // 
            this.yogaKids.AutoSize = true;
            this.yogaKids.Location = new System.Drawing.Point(177, 65);
            this.yogaKids.Name = "yogaKids";
            this.yogaKids.Size = new System.Drawing.Size(50, 17);
            this.yogaKids.TabIndex = 23;
            this.yogaKids.Text = "Yoga";
            this.yogaKids.UseVisualStyleBackColor = true;
            // 
            // zumbaKids
            // 
            this.zumbaKids.AutoSize = true;
            this.zumbaKids.Location = new System.Drawing.Point(177, 88);
            this.zumbaKids.Name = "zumbaKids";
            this.zumbaKids.Size = new System.Drawing.Size(58, 17);
            this.zumbaKids.TabIndex = 24;
            this.zumbaKids.Text = "Zumba";
            this.zumbaKids.UseVisualStyleBackColor = true;
            // 
            // golfKids
            // 
            this.golfKids.AutoSize = true;
            this.golfKids.Location = new System.Drawing.Point(177, 111);
            this.golfKids.Name = "golfKids";
            this.golfKids.Size = new System.Drawing.Size(44, 17);
            this.golfKids.TabIndex = 25;
            this.golfKids.Text = "Golf";
            this.golfKids.UseVisualStyleBackColor = true;
            // 
            // tennisKids
            // 
            this.tennisKids.AutoSize = true;
            this.tennisKids.Location = new System.Drawing.Point(177, 134);
            this.tennisKids.Name = "tennisKids";
            this.tennisKids.Size = new System.Drawing.Size(57, 17);
            this.tennisKids.TabIndex = 26;
            this.tennisKids.Text = "Tennis";
            this.tennisKids.UseVisualStyleBackColor = true;
            // 
            // CrawlerWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 268);
            this.Controls.Add(this.activKidsGroupBox);
            this.Controls.Add(this.progressBarResult);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.activGroupBox);
            this.Controls.Add(this.Start);
            this.Name = "CrawlerWF";
            this.Text = "Crawler";
            this.activGroupBox.ResumeLayout(false);
            this.activGroupBox.PerformLayout();
            this.activKidsGroupBox.ResumeLayout(false);
            this.activKidsGroupBox.PerformLayout();
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
        private System.Windows.Forms.RadioButton outdoors;
        private System.Windows.Forms.RadioButton fitness;
        private System.Windows.Forms.GroupBox activKidsGroupBox;
        private System.Windows.Forms.RadioButton basketballKids;
        private System.Windows.Forms.RadioButton baseballKids;
        private System.Windows.Forms.RadioButton softballKids;
        private System.Windows.Forms.RadioButton footballKids;
        private System.Windows.Forms.RadioButton hockeyKids;
        private System.Windows.Forms.RadioButton lacrosseKids;
        private System.Windows.Forms.RadioButton soccerKids;
        private System.Windows.Forms.RadioButton volleyballKids;
        private System.Windows.Forms.RadioButton runningKids;
        private System.Windows.Forms.RadioButton swimmingKids;
        private System.Windows.Forms.RadioButton lifeguardingKids;
        private System.Windows.Forms.RadioButton martialArtsKids;
        private System.Windows.Forms.RadioButton skatingKids;
        private System.Windows.Forms.RadioButton yogaKids;
        private System.Windows.Forms.RadioButton fitnessKids;
        private System.Windows.Forms.RadioButton golfKids;
        private System.Windows.Forms.RadioButton zumbaKids;
        private System.Windows.Forms.RadioButton tennisKids;
    }
}

