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
    public partial class MtPluginDownloadSuccessful : Form
    {
        public MtPluginDownloadSuccessful(string path)
        {
            InitializeComponent();
            FileDownloadPath = path;
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
