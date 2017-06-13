using AweSamNet.Integration.GithubReleaseAutoUpdater.Models;
using AweSamNet.Integration.GitHubReleaseAutoUpdater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sdl.Community.MtEnhancedProvider
{
    public partial class MtPluginUpdateAvailableDialog : Form
    {
        public MtPluginUpdateAvailableDialog(string currentVersion, string latestVersion, string releaseNotes)
        {
            InitializeComponent();
            lbl_currentVersion.Text = currentVersion;
            lbl_latestVersion.Text = latestVersion;
            txt_releaseNotes.Text = releaseNotes;
        }

        public NewVersionOptions NewVersionOption { get; set; } = NewVersionOptions.RemindMeLater;

        private void btn_update_Click(object sender, EventArgs e)
        {
            NewVersionOption = NewVersionOptions.DownloadUpdate;
            Close();
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            NewVersionOption = NewVersionOptions.SkipThisVersion;
            Close();
        }

        private void btn_later_Click(object sender, EventArgs e)
        {
            NewVersionOption = NewVersionOptions.RemindMeLater;
            Close();
        }
    }
}
