using Prius_Service.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            VersionChange();
        }

        //Az assembly versiont nézi ami a ClickOnce-al nem változik
        private void VersionChange()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            version_linkLabel.Text = versionInfo.FileVersion;
        }

        private void email_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            email_linkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo("mailto:mikesmarcell@gmail.com") { UseShellExecute = true });
        }

        private void version_linkLabel_Click(object sender, EventArgs e)
        {
            Changelog changelog = new Changelog();
            changelog.Show();
        }
    }
}
