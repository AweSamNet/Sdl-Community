namespace Sdl.Community.MtEnhancedProvider
{
    partial class MtPluginDownloadSuccessful
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MtPluginDownloadSuccessful));
            this.lbl_success = new System.Windows.Forms.Label();
            this.btn_openDownloadsFolder = new System.Windows.Forms.Button();
            this.btn_later = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_success
            // 
            this.lbl_success.Location = new System.Drawing.Point(13, 13);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(290, 86);
            this.lbl_success.TabIndex = 0;
            this.lbl_success.Text = resources.GetString("lbl_success.Text");
            // 
            // btn_openDownloadsFolder
            // 
            this.btn_openDownloadsFolder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_openDownloadsFolder.Location = new System.Drawing.Point(170, 128);
            this.btn_openDownloadsFolder.Name = "btn_openDownloadsFolder";
            this.btn_openDownloadsFolder.Size = new System.Drawing.Size(133, 23);
            this.btn_openDownloadsFolder.TabIndex = 1;
            this.btn_openDownloadsFolder.Text = "Open Downloads folder";
            this.btn_openDownloadsFolder.UseVisualStyleBackColor = true;
            this.btn_openDownloadsFolder.Click += new System.EventHandler(this.btn_openDownloadsFolder_Click);
            // 
            // btn_later
            // 
            this.btn_later.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_later.Location = new System.Drawing.Point(89, 128);
            this.btn_later.Name = "btn_later";
            this.btn_later.Size = new System.Drawing.Size(75, 23);
            this.btn_later.TabIndex = 2;
            this.btn_later.Text = "Later";
            this.btn_later.UseVisualStyleBackColor = true;
            this.btn_later.Click += new System.EventHandler(this.btn_later_Click);
            // 
            // MtPluginDownloadSuccessful
            // 
            this.AcceptButton = this.btn_openDownloadsFolder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_later;
            this.ClientSize = new System.Drawing.Size(314, 161);
            this.Controls.Add(this.btn_later);
            this.Controls.Add(this.btn_openDownloadsFolder);
            this.Controls.Add(this.lbl_success);
            this.MaximumSize = new System.Drawing.Size(330, 200);
            this.MinimumSize = new System.Drawing.Size(330, 200);
            this.Name = "MtPluginDownloadSuccessful";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MT Enhanced Download Success";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.Button btn_openDownloadsFolder;
        private System.Windows.Forms.Button btn_later;
    }
}