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
            this.StartActiv = new System.Windows.Forms.Button();
            this.RunningActiv = new System.Windows.Forms.RadioButton();
            this.activGroupBox = new System.Windows.Forms.GroupBox();
            this.OutdoorsActiv = new System.Windows.Forms.RadioButton();
            this.FitnessActiv = new System.Windows.Forms.RadioButton();
            this.winterSportsActiv = new System.Windows.Forms.RadioButton();
            this.VolleyballActiv = new System.Windows.Forms.RadioButton();
            this.TennisActiv = new System.Windows.Forms.RadioButton();
            this.SwimmingActiv = new System.Windows.Forms.RadioButton();
            this.SoftballActiv = new System.Windows.Forms.RadioButton();
            this.SoccerActiv = new System.Windows.Forms.RadioButton();
            this.martialArtsActiv = new System.Windows.Forms.RadioButton();
            this.GolfActiv = new System.Windows.Forms.RadioButton();
            this.FootballActiv = new System.Windows.Forms.RadioButton();
            this.BasketballActiv = new System.Windows.Forms.RadioButton();
            this.BaseballActiv = new System.Windows.Forms.RadioButton();
            this.TriathlonActiv = new System.Windows.Forms.RadioButton();
            this.CyclingActiv = new System.Windows.Forms.RadioButton();
            this.folderButton = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBarResult = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.activKidsGroupBox = new System.Windows.Forms.GroupBox();
            this.StartActivKids = new System.Windows.Forms.Button();
            this.TennisActivKids = new System.Windows.Forms.RadioButton();
            this.GolfActivKids = new System.Windows.Forms.RadioButton();
            this.ZumbaActivKids = new System.Windows.Forms.RadioButton();
            this.YogaActivKids = new System.Windows.Forms.RadioButton();
            this.FitnessActivKids = new System.Windows.Forms.RadioButton();
            this.martialArtsActivKids = new System.Windows.Forms.RadioButton();
            this.SkatingActivKids = new System.Windows.Forms.RadioButton();
            this.SkillsActivKids = new System.Windows.Forms.RadioButton();
            this.SwimmingActivKids = new System.Windows.Forms.RadioButton();
            this.RunningActivKids = new System.Windows.Forms.RadioButton();
            this.VolleyballActivKids = new System.Windows.Forms.RadioButton();
            this.SoccerActivKids = new System.Windows.Forms.RadioButton();
            this.LacrosseActivKids = new System.Windows.Forms.RadioButton();
            this.HockeyActivKids = new System.Windows.Forms.RadioButton();
            this.FootballActivKids = new System.Windows.Forms.RadioButton();
            this.SoftballActivKids = new System.Windows.Forms.RadioButton();
            this.BaseballActivKids = new System.Windows.Forms.RadioButton();
            this.BasketballActivKids = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.performingArtsActivKids = new System.Windows.Forms.RadioButton();
            this.GymnasticsActivKids = new System.Windows.Forms.RadioButton();
            this.TumblingActivKids = new System.Windows.Forms.RadioButton();
            this.CheerleadingActivKids = new System.Windows.Forms.RadioButton();
            this.GamesActivKids = new System.Windows.Forms.RadioButton();
            this.AcademicsActivKids = new System.Windows.Forms.RadioButton();
            this.LanguagesActivKids = new System.Windows.Forms.RadioButton();
            this.FoodAndNutritionActivKids = new System.Windows.Forms.RadioButton();
            this.ArtsAndCraftsActivKids = new System.Windows.Forms.RadioButton();
            this.HikingActivKids = new System.Windows.Forms.RadioButton();
            this.CampingActivKids = new System.Windows.Forms.RadioButton();
            this.CampsActivKids = new System.Windows.Forms.RadioButton();
            this.FishingActivKids = new System.Windows.Forms.RadioButton();
            this.activGroupBox.SuspendLayout();
            this.activKidsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartActiv
            // 
            this.StartActiv.Location = new System.Drawing.Point(6, 206);
            this.StartActiv.Name = "StartActiv";
            this.StartActiv.Size = new System.Drawing.Size(171, 23);
            this.StartActiv.TabIndex = 0;
            this.StartActiv.Text = "Start";
            this.StartActiv.UseVisualStyleBackColor = true;
            this.StartActiv.Click += new System.EventHandler(this.StartActiv_Click);
            // 
            // RunningActiv
            // 
            this.RunningActiv.AutoSize = true;
            this.RunningActiv.Checked = true;
            this.RunningActiv.Location = new System.Drawing.Point(6, 19);
            this.RunningActiv.Name = "RunningActiv";
            this.RunningActiv.Size = new System.Drawing.Size(65, 17);
            this.RunningActiv.TabIndex = 1;
            this.RunningActiv.TabStop = true;
            this.RunningActiv.Text = "Running";
            this.RunningActiv.UseVisualStyleBackColor = true;
            this.RunningActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // activGroupBox
            // 
            this.activGroupBox.Controls.Add(this.OutdoorsActiv);
            this.activGroupBox.Controls.Add(this.FitnessActiv);
            this.activGroupBox.Controls.Add(this.winterSportsActiv);
            this.activGroupBox.Controls.Add(this.VolleyballActiv);
            this.activGroupBox.Controls.Add(this.TennisActiv);
            this.activGroupBox.Controls.Add(this.StartActiv);
            this.activGroupBox.Controls.Add(this.SwimmingActiv);
            this.activGroupBox.Controls.Add(this.SoftballActiv);
            this.activGroupBox.Controls.Add(this.SoccerActiv);
            this.activGroupBox.Controls.Add(this.martialArtsActiv);
            this.activGroupBox.Controls.Add(this.GolfActiv);
            this.activGroupBox.Controls.Add(this.FootballActiv);
            this.activGroupBox.Controls.Add(this.BasketballActiv);
            this.activGroupBox.Controls.Add(this.BaseballActiv);
            this.activGroupBox.Controls.Add(this.TriathlonActiv);
            this.activGroupBox.Controls.Add(this.CyclingActiv);
            this.activGroupBox.Controls.Add(this.RunningActiv);
            this.activGroupBox.Location = new System.Drawing.Point(12, 12);
            this.activGroupBox.Name = "activGroupBox";
            this.activGroupBox.Size = new System.Drawing.Size(188, 242);
            this.activGroupBox.TabIndex = 2;
            this.activGroupBox.TabStop = false;
            this.activGroupBox.Text = "active.com";
            // 
            // OutdoorsActiv
            // 
            this.OutdoorsActiv.AutoSize = true;
            this.OutdoorsActiv.Location = new System.Drawing.Point(6, 111);
            this.OutdoorsActiv.Name = "OutdoorsActiv";
            this.OutdoorsActiv.Size = new System.Drawing.Size(68, 17);
            this.OutdoorsActiv.TabIndex = 16;
            this.OutdoorsActiv.Text = "Outdoors";
            this.OutdoorsActiv.UseVisualStyleBackColor = true;
            // 
            // FitnessActiv
            // 
            this.FitnessActiv.AutoSize = true;
            this.FitnessActiv.Location = new System.Drawing.Point(6, 88);
            this.FitnessActiv.Name = "FitnessActiv";
            this.FitnessActiv.Size = new System.Drawing.Size(58, 17);
            this.FitnessActiv.TabIndex = 15;
            this.FitnessActiv.Text = "Fitness";
            this.FitnessActiv.UseVisualStyleBackColor = true;
            // 
            // winterSportsActiv
            // 
            this.winterSportsActiv.AutoSize = true;
            this.winterSportsActiv.Location = new System.Drawing.Point(88, 183);
            this.winterSportsActiv.Name = "winterSportsActiv";
            this.winterSportsActiv.Size = new System.Drawing.Size(89, 17);
            this.winterSportsActiv.TabIndex = 14;
            this.winterSportsActiv.Text = "Winter Sports";
            this.winterSportsActiv.UseVisualStyleBackColor = true;
            this.winterSportsActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // VolleyballActiv
            // 
            this.VolleyballActiv.AutoSize = true;
            this.VolleyballActiv.Location = new System.Drawing.Point(88, 160);
            this.VolleyballActiv.Name = "VolleyballActiv";
            this.VolleyballActiv.Size = new System.Drawing.Size(69, 17);
            this.VolleyballActiv.TabIndex = 13;
            this.VolleyballActiv.Text = "Volleyball";
            this.VolleyballActiv.UseVisualStyleBackColor = true;
            this.VolleyballActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // TennisActiv
            // 
            this.TennisActiv.AutoSize = true;
            this.TennisActiv.Location = new System.Drawing.Point(88, 134);
            this.TennisActiv.Name = "TennisActiv";
            this.TennisActiv.Size = new System.Drawing.Size(57, 17);
            this.TennisActiv.TabIndex = 12;
            this.TennisActiv.Text = "Tennis";
            this.TennisActiv.UseVisualStyleBackColor = true;
            this.TennisActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // SwimmingActiv
            // 
            this.SwimmingActiv.AutoSize = true;
            this.SwimmingActiv.Location = new System.Drawing.Point(88, 111);
            this.SwimmingActiv.Name = "SwimmingActiv";
            this.SwimmingActiv.Size = new System.Drawing.Size(72, 17);
            this.SwimmingActiv.TabIndex = 11;
            this.SwimmingActiv.Text = "Swimming";
            this.SwimmingActiv.UseVisualStyleBackColor = true;
            this.SwimmingActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // SoftballActiv
            // 
            this.SoftballActiv.AutoSize = true;
            this.SoftballActiv.Location = new System.Drawing.Point(88, 88);
            this.SoftballActiv.Name = "SoftballActiv";
            this.SoftballActiv.Size = new System.Drawing.Size(60, 17);
            this.SoftballActiv.TabIndex = 10;
            this.SoftballActiv.Text = "Softball";
            this.SoftballActiv.UseVisualStyleBackColor = true;
            this.SoftballActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // SoccerActiv
            // 
            this.SoccerActiv.AutoSize = true;
            this.SoccerActiv.Location = new System.Drawing.Point(88, 65);
            this.SoccerActiv.Name = "SoccerActiv";
            this.SoccerActiv.Size = new System.Drawing.Size(59, 17);
            this.SoccerActiv.TabIndex = 9;
            this.SoccerActiv.Text = "Soccer";
            this.SoccerActiv.UseVisualStyleBackColor = true;
            this.SoccerActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // martialArtsActiv
            // 
            this.martialArtsActiv.AutoSize = true;
            this.martialArtsActiv.Location = new System.Drawing.Point(88, 42);
            this.martialArtsActiv.Name = "martialArtsActiv";
            this.martialArtsActiv.Size = new System.Drawing.Size(77, 17);
            this.martialArtsActiv.TabIndex = 8;
            this.martialArtsActiv.Text = "Martial Arts";
            this.martialArtsActiv.UseVisualStyleBackColor = true;
            this.martialArtsActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // GolfActiv
            // 
            this.GolfActiv.AutoSize = true;
            this.GolfActiv.Location = new System.Drawing.Point(88, 19);
            this.GolfActiv.Name = "GolfActiv";
            this.GolfActiv.Size = new System.Drawing.Size(44, 17);
            this.GolfActiv.TabIndex = 7;
            this.GolfActiv.Text = "Golf";
            this.GolfActiv.UseVisualStyleBackColor = true;
            this.GolfActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // FootballActiv
            // 
            this.FootballActiv.AutoSize = true;
            this.FootballActiv.Location = new System.Drawing.Point(6, 183);
            this.FootballActiv.Name = "FootballActiv";
            this.FootballActiv.Size = new System.Drawing.Size(62, 17);
            this.FootballActiv.TabIndex = 6;
            this.FootballActiv.Text = "Football";
            this.FootballActiv.UseVisualStyleBackColor = true;
            this.FootballActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // BasketballActiv
            // 
            this.BasketballActiv.AutoSize = true;
            this.BasketballActiv.Location = new System.Drawing.Point(6, 160);
            this.BasketballActiv.Name = "BasketballActiv";
            this.BasketballActiv.Size = new System.Drawing.Size(74, 17);
            this.BasketballActiv.TabIndex = 5;
            this.BasketballActiv.Text = "Basketball";
            this.BasketballActiv.UseVisualStyleBackColor = true;
            this.BasketballActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // BaseballActiv
            // 
            this.BaseballActiv.AutoSize = true;
            this.BaseballActiv.Location = new System.Drawing.Point(6, 134);
            this.BaseballActiv.Name = "BaseballActiv";
            this.BaseballActiv.Size = new System.Drawing.Size(65, 17);
            this.BaseballActiv.TabIndex = 4;
            this.BaseballActiv.Text = "Baseball";
            this.BaseballActiv.UseVisualStyleBackColor = true;
            this.BaseballActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // TriathlonActiv
            // 
            this.TriathlonActiv.AutoSize = true;
            this.TriathlonActiv.Location = new System.Drawing.Point(6, 65);
            this.TriathlonActiv.Name = "TriathlonActiv";
            this.TriathlonActiv.Size = new System.Drawing.Size(66, 17);
            this.TriathlonActiv.TabIndex = 3;
            this.TriathlonActiv.Text = "Triathlon";
            this.TriathlonActiv.UseVisualStyleBackColor = true;
            this.TriathlonActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // CyclingActiv
            // 
            this.CyclingActiv.AutoSize = true;
            this.CyclingActiv.Location = new System.Drawing.Point(6, 42);
            this.CyclingActiv.Name = "CyclingActiv";
            this.CyclingActiv.Size = new System.Drawing.Size(59, 17);
            this.CyclingActiv.TabIndex = 2;
            this.CyclingActiv.Text = "Cycling";
            this.CyclingActiv.UseVisualStyleBackColor = true;
            this.CyclingActiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(12, 269);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(188, 23);
            this.folderButton.TabIndex = 3;
            this.folderButton.Text = "Select folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // folder
            // 
            this.folder.AutoSize = true;
            this.folder.Location = new System.Drawing.Point(209, 274);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(35, 13);
            this.folder.TabIndex = 4;
            this.folder.Text = "label1";
            // 
            // progressBarResult
            // 
            this.progressBarResult.Location = new System.Drawing.Point(12, 313);
            this.progressBarResult.Name = "progressBarResult";
            this.progressBarResult.Size = new System.Drawing.Size(604, 23);
            this.progressBarResult.TabIndex = 5;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // activKidsGroupBox
            // 
            this.activKidsGroupBox.Controls.Add(this.FishingActivKids);
            this.activKidsGroupBox.Controls.Add(this.CampsActivKids);
            this.activKidsGroupBox.Controls.Add(this.CampingActivKids);
            this.activKidsGroupBox.Controls.Add(this.HikingActivKids);
            this.activKidsGroupBox.Controls.Add(this.ArtsAndCraftsActivKids);
            this.activKidsGroupBox.Controls.Add(this.FoodAndNutritionActivKids);
            this.activKidsGroupBox.Controls.Add(this.LanguagesActivKids);
            this.activKidsGroupBox.Controls.Add(this.AcademicsActivKids);
            this.activKidsGroupBox.Controls.Add(this.GamesActivKids);
            this.activKidsGroupBox.Controls.Add(this.CheerleadingActivKids);
            this.activKidsGroupBox.Controls.Add(this.TumblingActivKids);
            this.activKidsGroupBox.Controls.Add(this.GymnasticsActivKids);
            this.activKidsGroupBox.Controls.Add(this.performingArtsActivKids);
            this.activKidsGroupBox.Controls.Add(this.StartActivKids);
            this.activKidsGroupBox.Controls.Add(this.TennisActivKids);
            this.activKidsGroupBox.Controls.Add(this.GolfActivKids);
            this.activKidsGroupBox.Controls.Add(this.ZumbaActivKids);
            this.activKidsGroupBox.Controls.Add(this.YogaActivKids);
            this.activKidsGroupBox.Controls.Add(this.FitnessActivKids);
            this.activKidsGroupBox.Controls.Add(this.martialArtsActivKids);
            this.activKidsGroupBox.Controls.Add(this.SkatingActivKids);
            this.activKidsGroupBox.Controls.Add(this.SkillsActivKids);
            this.activKidsGroupBox.Controls.Add(this.SwimmingActivKids);
            this.activKidsGroupBox.Controls.Add(this.RunningActivKids);
            this.activKidsGroupBox.Controls.Add(this.VolleyballActivKids);
            this.activKidsGroupBox.Controls.Add(this.SoccerActivKids);
            this.activKidsGroupBox.Controls.Add(this.LacrosseActivKids);
            this.activKidsGroupBox.Controls.Add(this.HockeyActivKids);
            this.activKidsGroupBox.Controls.Add(this.FootballActivKids);
            this.activKidsGroupBox.Controls.Add(this.SoftballActivKids);
            this.activKidsGroupBox.Controls.Add(this.BaseballActivKids);
            this.activKidsGroupBox.Controls.Add(this.BasketballActivKids);
            this.activKidsGroupBox.Location = new System.Drawing.Point(206, 12);
            this.activKidsGroupBox.Name = "activKidsGroupBox";
            this.activKidsGroupBox.Size = new System.Drawing.Size(410, 242);
            this.activKidsGroupBox.TabIndex = 6;
            this.activKidsGroupBox.TabStop = false;
            this.activKidsGroupBox.Text = "activekids.com";
            // 
            // StartActivKids
            // 
            this.StartActivKids.Location = new System.Drawing.Point(6, 206);
            this.StartActivKids.Name = "StartActivKids";
            this.StartActivKids.Size = new System.Drawing.Size(396, 23);
            this.StartActivKids.TabIndex = 27;
            this.StartActivKids.Text = "Start";
            this.StartActivKids.UseVisualStyleBackColor = true;
            this.StartActivKids.Click += new System.EventHandler(this.StartActivKids_Click);
            // 
            // TennisActivKids
            // 
            this.TennisActivKids.AutoSize = true;
            this.TennisActivKids.Location = new System.Drawing.Point(98, 134);
            this.TennisActivKids.Name = "TennisActivKids";
            this.TennisActivKids.Size = new System.Drawing.Size(57, 17);
            this.TennisActivKids.TabIndex = 26;
            this.TennisActivKids.Text = "Tennis";
            this.TennisActivKids.UseVisualStyleBackColor = true;
            // 
            // GolfActivKids
            // 
            this.GolfActivKids.AutoSize = true;
            this.GolfActivKids.Location = new System.Drawing.Point(97, 111);
            this.GolfActivKids.Name = "GolfActivKids";
            this.GolfActivKids.Size = new System.Drawing.Size(44, 17);
            this.GolfActivKids.TabIndex = 25;
            this.GolfActivKids.Text = "Golf";
            this.GolfActivKids.UseVisualStyleBackColor = true;
            // 
            // ZumbaActivKids
            // 
            this.ZumbaActivKids.AutoSize = true;
            this.ZumbaActivKids.Location = new System.Drawing.Point(97, 180);
            this.ZumbaActivKids.Name = "ZumbaActivKids";
            this.ZumbaActivKids.Size = new System.Drawing.Size(58, 17);
            this.ZumbaActivKids.TabIndex = 24;
            this.ZumbaActivKids.Text = "Zumba";
            this.ZumbaActivKids.UseVisualStyleBackColor = true;
            // 
            // YogaActivKids
            // 
            this.YogaActivKids.AutoSize = true;
            this.YogaActivKids.Location = new System.Drawing.Point(98, 160);
            this.YogaActivKids.Name = "YogaActivKids";
            this.YogaActivKids.Size = new System.Drawing.Size(50, 17);
            this.YogaActivKids.TabIndex = 23;
            this.YogaActivKids.Text = "Yoga";
            this.YogaActivKids.UseVisualStyleBackColor = true;
            // 
            // FitnessActivKids
            // 
            this.FitnessActivKids.AutoSize = true;
            this.FitnessActivKids.Location = new System.Drawing.Point(185, 19);
            this.FitnessActivKids.Name = "FitnessActivKids";
            this.FitnessActivKids.Size = new System.Drawing.Size(58, 17);
            this.FitnessActivKids.TabIndex = 22;
            this.FitnessActivKids.Text = "Fitness";
            this.FitnessActivKids.UseVisualStyleBackColor = true;
            // 
            // martialArtsActivKids
            // 
            this.martialArtsActivKids.AutoSize = true;
            this.martialArtsActivKids.Location = new System.Drawing.Point(185, 42);
            this.martialArtsActivKids.Name = "martialArtsActivKids";
            this.martialArtsActivKids.Size = new System.Drawing.Size(77, 17);
            this.martialArtsActivKids.TabIndex = 21;
            this.martialArtsActivKids.Text = "Martial Arts";
            this.martialArtsActivKids.UseVisualStyleBackColor = true;
            // 
            // SkatingActivKids
            // 
            this.SkatingActivKids.AutoSize = true;
            this.SkatingActivKids.Location = new System.Drawing.Point(97, 88);
            this.SkatingActivKids.Name = "SkatingActivKids";
            this.SkatingActivKids.Size = new System.Drawing.Size(61, 17);
            this.SkatingActivKids.TabIndex = 20;
            this.SkatingActivKids.Text = "Skating";
            this.SkatingActivKids.UseVisualStyleBackColor = true;
            // 
            // SkillsActivKids
            // 
            this.SkillsActivKids.AutoSize = true;
            this.SkillsActivKids.Location = new System.Drawing.Point(97, 65);
            this.SkillsActivKids.Name = "SkillsActivKids";
            this.SkillsActivKids.Size = new System.Drawing.Size(49, 17);
            this.SkillsActivKids.TabIndex = 19;
            this.SkillsActivKids.Text = "Skills";
            this.SkillsActivKids.UseVisualStyleBackColor = true;
            // 
            // SwimmingActivKids
            // 
            this.SwimmingActivKids.AutoSize = true;
            this.SwimmingActivKids.Location = new System.Drawing.Point(97, 42);
            this.SwimmingActivKids.Name = "SwimmingActivKids";
            this.SwimmingActivKids.Size = new System.Drawing.Size(72, 17);
            this.SwimmingActivKids.TabIndex = 18;
            this.SwimmingActivKids.Text = "Swimming";
            this.SwimmingActivKids.UseVisualStyleBackColor = true;
            // 
            // RunningActivKids
            // 
            this.RunningActivKids.AutoSize = true;
            this.RunningActivKids.Location = new System.Drawing.Point(97, 19);
            this.RunningActivKids.Name = "RunningActivKids";
            this.RunningActivKids.Size = new System.Drawing.Size(65, 17);
            this.RunningActivKids.TabIndex = 17;
            this.RunningActivKids.Text = "Running";
            this.RunningActivKids.UseVisualStyleBackColor = true;
            // 
            // VolleyballActivKids
            // 
            this.VolleyballActivKids.AutoSize = true;
            this.VolleyballActivKids.Location = new System.Drawing.Point(6, 183);
            this.VolleyballActivKids.Name = "VolleyballActivKids";
            this.VolleyballActivKids.Size = new System.Drawing.Size(69, 17);
            this.VolleyballActivKids.TabIndex = 16;
            this.VolleyballActivKids.Text = "Volleyball";
            this.VolleyballActivKids.UseVisualStyleBackColor = true;
            // 
            // SoccerActivKids
            // 
            this.SoccerActivKids.AutoSize = true;
            this.SoccerActivKids.Location = new System.Drawing.Point(6, 160);
            this.SoccerActivKids.Name = "SoccerActivKids";
            this.SoccerActivKids.Size = new System.Drawing.Size(59, 17);
            this.SoccerActivKids.TabIndex = 15;
            this.SoccerActivKids.Text = "Soccer";
            this.SoccerActivKids.UseVisualStyleBackColor = true;
            // 
            // LacrosseActivKids
            // 
            this.LacrosseActivKids.AutoSize = true;
            this.LacrosseActivKids.Location = new System.Drawing.Point(6, 134);
            this.LacrosseActivKids.Name = "LacrosseActivKids";
            this.LacrosseActivKids.Size = new System.Drawing.Size(68, 17);
            this.LacrosseActivKids.TabIndex = 14;
            this.LacrosseActivKids.Text = "Lacrosse";
            this.LacrosseActivKids.UseVisualStyleBackColor = true;
            // 
            // HockeyActivKids
            // 
            this.HockeyActivKids.AutoSize = true;
            this.HockeyActivKids.Location = new System.Drawing.Point(6, 111);
            this.HockeyActivKids.Name = "HockeyActivKids";
            this.HockeyActivKids.Size = new System.Drawing.Size(62, 17);
            this.HockeyActivKids.TabIndex = 13;
            this.HockeyActivKids.Text = "Hockey";
            this.HockeyActivKids.UseVisualStyleBackColor = true;
            // 
            // FootballActivKids
            // 
            this.FootballActivKids.AutoSize = true;
            this.FootballActivKids.Location = new System.Drawing.Point(6, 88);
            this.FootballActivKids.Name = "FootballActivKids";
            this.FootballActivKids.Size = new System.Drawing.Size(62, 17);
            this.FootballActivKids.TabIndex = 12;
            this.FootballActivKids.Text = "Football";
            this.FootballActivKids.UseVisualStyleBackColor = true;
            // 
            // SoftballActivKids
            // 
            this.SoftballActivKids.AutoSize = true;
            this.SoftballActivKids.Location = new System.Drawing.Point(6, 65);
            this.SoftballActivKids.Name = "SoftballActivKids";
            this.SoftballActivKids.Size = new System.Drawing.Size(60, 17);
            this.SoftballActivKids.TabIndex = 11;
            this.SoftballActivKids.Text = "Softball";
            this.SoftballActivKids.UseVisualStyleBackColor = true;
            // 
            // BaseballActivKids
            // 
            this.BaseballActivKids.AutoSize = true;
            this.BaseballActivKids.Location = new System.Drawing.Point(6, 42);
            this.BaseballActivKids.Name = "BaseballActivKids";
            this.BaseballActivKids.Size = new System.Drawing.Size(65, 17);
            this.BaseballActivKids.TabIndex = 7;
            this.BaseballActivKids.Text = "Baseball";
            this.BaseballActivKids.UseVisualStyleBackColor = true;
            // 
            // BasketballActivKids
            // 
            this.BasketballActivKids.AutoSize = true;
            this.BasketballActivKids.Checked = true;
            this.BasketballActivKids.Location = new System.Drawing.Point(6, 19);
            this.BasketballActivKids.Name = "BasketballActivKids";
            this.BasketballActivKids.Size = new System.Drawing.Size(74, 17);
            this.BasketballActivKids.TabIndex = 6;
            this.BasketballActivKids.TabStop = true;
            this.BasketballActivKids.Text = "Basketball";
            this.BasketballActivKids.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork1);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // performingArtsActivKids
            // 
            this.performingArtsActivKids.AutoSize = true;
            this.performingArtsActivKids.Location = new System.Drawing.Point(185, 65);
            this.performingArtsActivKids.Name = "performingArtsActivKids";
            this.performingArtsActivKids.Size = new System.Drawing.Size(96, 17);
            this.performingArtsActivKids.TabIndex = 28;
            this.performingArtsActivKids.Text = "Performing Arts";
            this.performingArtsActivKids.UseVisualStyleBackColor = true;
            // 
            // GymnasticsActivKids
            // 
            this.GymnasticsActivKids.AutoSize = true;
            this.GymnasticsActivKids.Location = new System.Drawing.Point(185, 88);
            this.GymnasticsActivKids.Name = "GymnasticsActivKids";
            this.GymnasticsActivKids.Size = new System.Drawing.Size(79, 17);
            this.GymnasticsActivKids.TabIndex = 29;
            this.GymnasticsActivKids.Text = "Gymnastics";
            this.GymnasticsActivKids.UseVisualStyleBackColor = true;
            // 
            // TumblingActivKids
            // 
            this.TumblingActivKids.AutoSize = true;
            this.TumblingActivKids.Location = new System.Drawing.Point(185, 111);
            this.TumblingActivKids.Name = "TumblingActivKids";
            this.TumblingActivKids.Size = new System.Drawing.Size(68, 17);
            this.TumblingActivKids.TabIndex = 30;
            this.TumblingActivKids.Text = "Tumbling";
            this.TumblingActivKids.UseVisualStyleBackColor = true;
            // 
            // CheerleadingActivKids
            // 
            this.CheerleadingActivKids.AutoSize = true;
            this.CheerleadingActivKids.Location = new System.Drawing.Point(185, 134);
            this.CheerleadingActivKids.Name = "CheerleadingActivKids";
            this.CheerleadingActivKids.Size = new System.Drawing.Size(87, 17);
            this.CheerleadingActivKids.TabIndex = 31;
            this.CheerleadingActivKids.Text = "Cheerleading";
            this.CheerleadingActivKids.UseVisualStyleBackColor = true;
            // 
            // GamesActivKids
            // 
            this.GamesActivKids.AutoSize = true;
            this.GamesActivKids.Location = new System.Drawing.Point(185, 160);
            this.GamesActivKids.Name = "GamesActivKids";
            this.GamesActivKids.Size = new System.Drawing.Size(58, 17);
            this.GamesActivKids.TabIndex = 32;
            this.GamesActivKids.Text = "Games";
            this.GamesActivKids.UseVisualStyleBackColor = true;
            // 
            // AcademicsActivKids
            // 
            this.AcademicsActivKids.AutoSize = true;
            this.AcademicsActivKids.Location = new System.Drawing.Point(185, 180);
            this.AcademicsActivKids.Name = "AcademicsActivKids";
            this.AcademicsActivKids.Size = new System.Drawing.Size(77, 17);
            this.AcademicsActivKids.TabIndex = 33;
            this.AcademicsActivKids.Text = "Academics";
            this.AcademicsActivKids.UseVisualStyleBackColor = true;
            // 
            // LanguagesActivKids
            // 
            this.LanguagesActivKids.AutoSize = true;
            this.LanguagesActivKids.Location = new System.Drawing.Point(292, 19);
            this.LanguagesActivKids.Name = "LanguagesActivKids";
            this.LanguagesActivKids.Size = new System.Drawing.Size(78, 17);
            this.LanguagesActivKids.TabIndex = 34;
            this.LanguagesActivKids.Text = "Languages";
            this.LanguagesActivKids.UseVisualStyleBackColor = true;
            // 
            // FoodAndNutritionActivKids
            // 
            this.FoodAndNutritionActivKids.AutoSize = true;
            this.FoodAndNutritionActivKids.Location = new System.Drawing.Point(292, 42);
            this.FoodAndNutritionActivKids.Name = "FoodAndNutritionActivKids";
            this.FoodAndNutritionActivKids.Size = new System.Drawing.Size(110, 17);
            this.FoodAndNutritionActivKids.TabIndex = 35;
            this.FoodAndNutritionActivKids.Text = "Food and nutrition";
            this.FoodAndNutritionActivKids.UseVisualStyleBackColor = true;
            // 
            // ArtsAndCraftsActivKids
            // 
            this.ArtsAndCraftsActivKids.AutoSize = true;
            this.ArtsAndCraftsActivKids.Location = new System.Drawing.Point(292, 65);
            this.ArtsAndCraftsActivKids.Name = "ArtsAndCraftsActivKids";
            this.ArtsAndCraftsActivKids.Size = new System.Drawing.Size(93, 17);
            this.ArtsAndCraftsActivKids.TabIndex = 36;
            this.ArtsAndCraftsActivKids.Text = "Arts and crafts";
            this.ArtsAndCraftsActivKids.UseVisualStyleBackColor = true;
            // 
            // HikingActivKids
            // 
            this.HikingActivKids.AutoSize = true;
            this.HikingActivKids.Location = new System.Drawing.Point(292, 88);
            this.HikingActivKids.Name = "HikingActivKids";
            this.HikingActivKids.Size = new System.Drawing.Size(55, 17);
            this.HikingActivKids.TabIndex = 37;
            this.HikingActivKids.Text = "Hiking";
            this.HikingActivKids.UseVisualStyleBackColor = true;
            // 
            // CampingActivKids
            // 
            this.CampingActivKids.AutoSize = true;
            this.CampingActivKids.Location = new System.Drawing.Point(292, 111);
            this.CampingActivKids.Name = "CampingActivKids";
            this.CampingActivKids.Size = new System.Drawing.Size(66, 17);
            this.CampingActivKids.TabIndex = 38;
            this.CampingActivKids.Text = "Camping";
            this.CampingActivKids.UseVisualStyleBackColor = true;
            // 
            // CampsActivKids
            // 
            this.CampsActivKids.AutoSize = true;
            this.CampsActivKids.Location = new System.Drawing.Point(292, 134);
            this.CampsActivKids.Name = "CampsActivKids";
            this.CampsActivKids.Size = new System.Drawing.Size(57, 17);
            this.CampsActivKids.TabIndex = 39;
            this.CampsActivKids.Text = "Camps";
            this.CampsActivKids.UseVisualStyleBackColor = true;
            // 
            // FishingActivKids
            // 
            this.FishingActivKids.AutoSize = true;
            this.FishingActivKids.Location = new System.Drawing.Point(292, 160);
            this.FishingActivKids.Name = "FishingActivKids";
            this.FishingActivKids.Size = new System.Drawing.Size(58, 17);
            this.FishingActivKids.TabIndex = 40;
            this.FishingActivKids.Text = "Fishing";
            this.FishingActivKids.UseVisualStyleBackColor = true;
            // 
            // CrawlerWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 348);
            this.Controls.Add(this.activKidsGroupBox);
            this.Controls.Add(this.progressBarResult);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.activGroupBox);
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

        private System.Windows.Forms.Button StartActiv;
        private System.Windows.Forms.RadioButton RunningActiv;
        private System.Windows.Forms.GroupBox activGroupBox;
        private System.Windows.Forms.RadioButton TriathlonActiv;
        private System.Windows.Forms.RadioButton CyclingActiv;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Label folder;
        private System.Windows.Forms.FolderBrowserDialog fileDialog;
        private System.Windows.Forms.ProgressBar progressBarResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.RadioButton BaseballActiv;
        private System.Windows.Forms.RadioButton BasketballActiv;
        private System.Windows.Forms.RadioButton FootballActiv;
        private System.Windows.Forms.RadioButton GolfActiv;
        private System.Windows.Forms.RadioButton martialArtsActiv;
        private System.Windows.Forms.RadioButton SoccerActiv;
        private System.Windows.Forms.RadioButton SoftballActiv;
        private System.Windows.Forms.RadioButton SwimmingActiv;
        private System.Windows.Forms.RadioButton TennisActiv;
        private System.Windows.Forms.RadioButton VolleyballActiv;
        private System.Windows.Forms.RadioButton winterSportsActiv;
        private System.Windows.Forms.RadioButton OutdoorsActiv;
        private System.Windows.Forms.RadioButton FitnessActiv;
        private System.Windows.Forms.GroupBox activKidsGroupBox;
        private System.Windows.Forms.RadioButton BasketballActivKids;
        private System.Windows.Forms.RadioButton BaseballActivKids;
        private System.Windows.Forms.RadioButton SoftballActivKids;
        private System.Windows.Forms.RadioButton FootballActivKids;
        private System.Windows.Forms.RadioButton HockeyActivKids;
        private System.Windows.Forms.RadioButton LacrosseActivKids;
        private System.Windows.Forms.RadioButton SoccerActivKids;
        private System.Windows.Forms.RadioButton VolleyballActivKids;
        private System.Windows.Forms.RadioButton RunningActivKids;
        private System.Windows.Forms.RadioButton SwimmingActivKids;
        private System.Windows.Forms.RadioButton SkillsActivKids;
        private System.Windows.Forms.RadioButton martialArtsActivKids;
        private System.Windows.Forms.RadioButton SkatingActivKids;
        private System.Windows.Forms.RadioButton YogaActivKids;
        private System.Windows.Forms.RadioButton FitnessActivKids;
        private System.Windows.Forms.RadioButton GolfActivKids;
        private System.Windows.Forms.RadioButton ZumbaActivKids;
        private System.Windows.Forms.RadioButton TennisActivKids;
        private System.Windows.Forms.Button StartActivKids;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton performingArtsActivKids;
        private System.Windows.Forms.RadioButton GymnasticsActivKids;
        private System.Windows.Forms.RadioButton TumblingActivKids;
        private System.Windows.Forms.RadioButton CheerleadingActivKids;
        private System.Windows.Forms.RadioButton GamesActivKids;
        private System.Windows.Forms.RadioButton AcademicsActivKids;
        private System.Windows.Forms.RadioButton LanguagesActivKids;
        private System.Windows.Forms.RadioButton FoodAndNutritionActivKids;
        private System.Windows.Forms.RadioButton ArtsAndCraftsActivKids;
        private System.Windows.Forms.RadioButton HikingActivKids;
        private System.Windows.Forms.RadioButton CampingActivKids;
        private System.Windows.Forms.RadioButton CampsActivKids;
        private System.Windows.Forms.RadioButton FishingActivKids;
    }
}

