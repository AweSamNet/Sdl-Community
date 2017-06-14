using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sdl.Community.MtEnhancedProvider
{
    public partial class MtPluginDownloadSuccessfulDialog : Form
    {
        public MtPluginDownloadSuccessfulDialog(string path)
        {
            InitializeComponent();
            FileDownloadPath = path;
            LoadResources();
        }

        /// <summary>
        /// Loads strings to the form from our resources file....defaults have been set in the designer
        /// </summary>
        private void LoadResources()
        {
            Text = MtPluginDownloadSuccessfulDialogResources.form_Text;
            lbl_success.Text = MtPluginDownloadSuccessfulDialogResources.lbl_success_Text;
            btn_later.Text = MtPluginDownloadSuccessfulDialogResources.btn_later_Text;
            btn_openDownloadsFolder.Text = MtPluginDownloadSuccessfulDialogResources.btn_openDownloadsFolder_Text;
        }

        public string FileDownloadPath { get; set; }

        private void btn_openDownloadsFolder_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_later_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
