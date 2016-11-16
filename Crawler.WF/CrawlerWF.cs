using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Crawler.Core.Interfaces.Manager;

namespace Crawler.WF
{
    public partial class CrawlerWF : Form
    {
        private readonly IManager _manager;
        private string path = "";

        public CrawlerWF(IManager manager)
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker1.WorkerReportsProgress = true;

            _manager = manager;
            folder.Text = "";
            var path = "";
            StartActiv.Enabled = false;
            StartActivKids.Enabled = false;
        }

        private void StartActiv_Click(object sender, EventArgs e)
        {
            
            StartActiv.Enabled = false;
            StartActivKids.Enabled = false;
            folderButton.Enabled = false;
            activGroupBox.Enabled = false;
            activKidsGroupBox.Enabled = false;
            var a = new Thread(() =>
            {
                var buttons = this.activGroupBox.Controls.OfType<RadioButton>()
                    .FirstOrDefault(n => n.Checked);

                if (buttons != null)
                {
                    switch (buttons.Name)
                    {
                        case "martialArtsActiv":
                        {
                            _manager.GetInfoActivComManager("Martial-Arts", path);
                            break;
                        }
                        case "winterSportsActiv":
                        {
                            _manager.GetInfoActivComManager("Winter-Sports", path);
                            break;
                        }
                        default:
                        {
                            _manager.GetInfoActivComManager(buttons.Name.Replace("Activ", ""), path);
                            break;
                        }
                    }
                }
            });
            backgroundWorker.RunWorkerAsync();
            a.Start();
        }

        private void StartActivKids_Click(object sender, EventArgs e)
        {
            StartActiv.Enabled = false;
            StartActivKids.Enabled = false;
            folderButton.Enabled = false;
            activGroupBox.Enabled = false;
            activKidsGroupBox.Enabled = false;
            var a = new Thread(() =>
            {
                var buttonsKids = this.activKidsGroupBox.Controls.OfType<RadioButton>()
                    .FirstOrDefault(n => n.Checked);

                if (buttonsKids != null)
                {
                    switch (buttonsKids.Name)
                    {
                        case "martialArtsActivKids":
                        {
                            _manager.GetInfoActivKidsComManager("Martial-Arts", path);
                            break;
                        }
                        case "performingArtsActivKids":
                        {
                            _manager.GetInfoActivKidsComManager("Performing-Arts", path);
                            break;
                        }
                        case "FoodAndNutritionActivKids":
                        {
                            _manager.GetInfoActivKidsComManager("Food-and-nutrition", path);
                            break;
                        }
                        case "ArtsAndCraftsActivKids":
                        {
                            _manager.GetInfoActivKidsComManager("Arts-and-crafts", path);
                            break;
                        }
                        case "HikingActivKids":
                        {
                            _manager.GetInfoActivKidsComManager("Outdoors/Hiking", path);
                            break;
                        }
                        case "CampingActivKids":
                        {
                            _manager.GetInfoActivKidsComManager("Outdoors/Camping", path);
                            break;
                        }
                        default:
                        {
                            _manager.GetInfoActivKidsComManager(buttonsKids.Name.Replace("ActivKids", ""), path);
                            break;
                        }
                    }
                }
            });
            backgroundWorker1.RunWorkerAsync();
            a.Start();
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                folder.Text = fileDialog.SelectedPath;
                path = fileDialog.SelectedPath;
                StartActiv.Enabled = true;
                StartActivKids.Enabled = true;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(10000);
            for (;;)
            {
                var a = _manager.GetProgressMaxActivCom();
                var b = _manager.GetProgressNowActivCom();
                if (a != 0 && b != 0)
                {
                    int c = b * 100 / a;
                    backgroundWorker.ReportProgress(c);
                }
                Thread.Sleep(2000);
                if (b >= a && a != 0 )
                {
                    backgroundWorker.ReportProgress(0);
                        break;   
                }
            }
        }
        private void backgroundWorker_DoWork1(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(10000);
            for (;;)
            {
                var a = _manager.GetProgressMaxActivKidsCom();
                var b = _manager.GetProgressNowActivKidsCom();
                if (a != 0 && b != 0)
                {
                    int c = b * 100 / a;
                    backgroundWorker1.ReportProgress(c);
                }
                Thread.Sleep(2000);
                if (b >= a && a != 0)
                {
                    backgroundWorker1.ReportProgress(0);
                    break;
                }
            }
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarResult.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StartActiv.Enabled = true;
            StartActivKids.Enabled = true;
            folderButton.Enabled = true;
            activGroupBox.Enabled = true;
            activKidsGroupBox.Enabled = true;
            MessageBox.Show(@"End");
        }

       
    }
}
