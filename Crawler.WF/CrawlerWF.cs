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

            _manager = manager;
            folder.Text = "";
            var path = "";
            Start.Enabled = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
            Start.Enabled = false;
            folderButton.Enabled = false;
            activGroupBox.Enabled = false;
            MessageBox.Show(@"Performed data collection. Please wait");
            var a = new Thread(() =>
            {
                var buttons = this.activGroupBox.Controls.OfType<RadioButton>()
                    .FirstOrDefault(n => n.Checked);

                if (buttons != null)
                {
                    switch (buttons.Name)
                    {
                        case "running":
                        {
                            _manager.GetInfoActivComManagerRunning(path);
                            break;
                        }
                        case "cucling":
                        {
                            _manager.GetInfoActivComManagerCycling(path);
                            break;
                        }
                        case "triathlon":
                        {
                            _manager.GetInfoActivComManagerTriathlon(path);
                            break;
                        }
                        case "baseball":
                        {
                            _manager.GetInfoActivComManagerBaseball(path);
                            break;
                        }
                        case "basketball":
                        {
                            _manager.GetInfoActivComManagerBasketball(path);
                            break;
                        }
                        case "football":
                        {
                            _manager.GetInfoActivComManagerFootball(path);
                            break;
                        }
                        case "golf":
                        {
                            _manager.GetInfoActivComManagerGolf(path);
                            break;
                        }
                        case "martialArts":
                        {
                            _manager.GetInfoActivComManagerMartialArts(path);
                            break;
                        }
                        case "soccer":
                        {
                            _manager.GetInfoActivComManagerSoccer(path);
                            break;
                        }
                        case "softball":
                        {
                            _manager.GetInfoActivComManagerSoftball(path);
                            break;
                        }
                        case "swimming":
                        {
                            _manager.GetInfoActivComManagerSwimming(path);
                            break;
                        }
                        case "tennis":
                        {
                            _manager.GetInfoActivComManagerTennis(path);
                            break;
                        }
                        case "volleyball":
                        {
                            _manager.GetInfoActivComManagerVolleyball(path);
                            break;
                        }
                        case "winterSports":
                        {
                            _manager.GetInfoActivComManagerWinterSports(path);
                            break;
                        }
                    }
                }

            });

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
                Start.Enabled = true;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (;;)
            {
                var a = _manager.GetProgressMax();
                var b = _manager.GetProgressNow();
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

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarResult.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Start.Enabled = true;
            folderButton.Enabled = true;
            activGroupBox.Enabled = true;
            MessageBox.Show(@"End");
        }
    }
}
