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
            LoadResources();

        }
        /// <summary>
        /// Loads strings to the form from our resources file....defaults have been set in the designer
        /// </summary>
        private void LoadResources()
        {
            Text = MtPluginUpdateAvailableDialogResources.form_Text;
            lbl_message.Text = MtPluginUpdateAvailableDialogResources.lbl_message_Text;
            lbl_current_label.Text = MtPluginUpdateAvailableDialogResources.lbl_current_label_Text;
            lbl_latestVersion_label.Text = MtPluginUpdateAvailableDialogResources.lbl_latestVersion_label_Text;
            lbl_releaseNotes.Text = MtPluginUpdateAvailableDialogResources.lbl_releaseNotes_Text;
            btn_later.Text = MtPluginUpdateAvailableDialogResources.btn_later_Text;
            btn_update.Text = MtPluginUpdateAvailableDialogResources.btn_update_Text;
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
