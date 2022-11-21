using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service.Forms
{
    public partial class Changelog : Form
    {
        public Changelog()
        {
            InitializeComponent();
        }

        private void Changelog_Load(object sender, EventArgs e)
        {
            VersionChange();
        }

        //Az assembly versiont nézi ami a ClickOnce-al nem változik
        private void VersionChange()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            verzioszamText_label.Text = versionInfo.FileVersion;
        }
    }
}
