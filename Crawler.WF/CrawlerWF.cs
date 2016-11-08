using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.Windsor;
using Crawler.BL.CW;
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
            _manager = manager;
            folder.Text = "";
            var path = "";
            Start.Enabled = false;

        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            
            MessageBox.Show(@"Performed data collection. Please wait");
            
            if (running.Checked)
            {
                _manager.GetInfoActivComManagerRunning(path);
            }
            if (cucling.Checked)
            {
                _manager.GetInfoActivComManagerCycling(path);
            }
            if (triathlon.Checked)
            {
                _manager.GetInfoActivComManagerTriathlon(path);
            }
            this.Enabled = true;
            MessageBox.Show(@"End");
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
    }
}
