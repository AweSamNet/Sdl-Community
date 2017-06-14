namespace Sdl.Community.MtEnhancedProvider
{
    partial class MtPluginUpdateAvailableDialog
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
            this.btn_later = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_current_label = new System.Windows.Forms.Label();
            this.lbl_latestVersion_label = new System.Windows.Forms.Label();
            this.lbl_releaseNotes = new System.Windows.Forms.Label();
            this.lbl_currentVersion = new System.Windows.Forms.Label();
            this.lbl_latestVersion = new System.Windows.Forms.Label();
            this.txt_releaseNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_later
            // 
            this.btn_later.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_later.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_later.Location = new System.Drawing.Point(137, 301);
            this.btn_later.Name = "btn_later";
            this.btn_later.Size = new System.Drawing.Size(102, 23);
            this.btn_later.TabIndex = 1;
            this.btn_later.Text = "Remind me later";
            this.btn_later.UseVisualStyleBackColor = true;
            this.btn_later.Click += new System.EventHandler(this.btn_later_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_update.Location = new System.Drawing.Point(245, 301);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(102, 23);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Download update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(12, 13);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(255, 13);
            this.lbl_message.TabIndex = 3;
            this.lbl_message.Text = "A new update for MT Enhanced Plugin is avaialable.";
            // 
            // lbl_current_label
            // 
            this.lbl_current_label.AutoSize = true;
            this.lbl_current_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_label.Location = new System.Drawing.Point(9, 35);
            this.lbl_current_label.Name = "lbl_current_label";
            this.lbl_current_label.Size = new System.Drawing.Size(102, 13);
            this.lbl_current_label.TabIndex = 4;
            this.lbl_current_label.Text = "Current Version: ";
            // 
            // lbl_latestVersion_label
            // 
            this.lbl_latestVersion_label.AutoSize = true;
            this.lbl_latestVersion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latestVersion_label.Location = new System.Drawing.Point(9, 58);
            this.lbl_latestVersion_label.Name = "lbl_latestVersion_label";
            this.lbl_latestVersion_label.Size = new System.Drawing.Size(92, 13);
            this.lbl_latestVersion_label.TabIndex = 5;
            this.lbl_latestVersion_label.Text = "Latest Version:";
            // 
            // lbl_releaseNotes
            // 
            this.lbl_releaseNotes.AutoSize = true;
            this.lbl_releaseNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_releaseNotes.Location = new System.Drawing.Point(9, 80);
            this.lbl_releaseNotes.Name = "lbl_releaseNotes";
            this.lbl_releaseNotes.Size = new System.Drawing.Size(94, 13);
            this.lbl_releaseNotes.TabIndex = 6;
            this.lbl_releaseNotes.Text = "Release Notes:";
            // 
            // lbl_currentVersion
            // 
            this.lbl_currentVersion.Location = new System.Drawing.Point(117, 35);
            this.lbl_currentVersion.Name = "lbl_currentVersion";
            this.lbl_currentVersion.Size = new System.Drawing.Size(150, 15);
            this.lbl_currentVersion.TabIndex = 7;
            // 
            // lbl_latestVersion
            // 
            this.lbl_latestVersion.Location = new System.Drawing.Point(117, 58);
            this.lbl_latestVersion.Name = "lbl_latestVersion";
            this.lbl_latestVersion.Size = new System.Drawing.Size(150, 15);
            this.lbl_latestVersion.TabIndex = 8;
            // 
            // txt_releaseNotes
            // 
            this.txt_releaseNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_releaseNotes.Location = new System.Drawing.Point(12, 97);
            this.txt_releaseNotes.Multiline = true;
            this.txt_releaseNotes.Name = "txt_releaseNotes";
            this.txt_releaseNotes.ReadOnly = true;
            this.txt_releaseNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_releaseNotes.Size = new System.Drawing.Size(335, 198);
            this.txt_releaseNotes.TabIndex = 9;
            // 
            // MtPluginUpdateAvailableDialog
            // 
            this.AcceptButton = this.btn_update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_later;
            this.ClientSize = new System.Drawing.Size(359, 336);
            this.Controls.Add(this.txt_releaseNotes);
            this.Controls.Add(this.lbl_latestVersion);
            this.Controls.Add(this.lbl_currentVersion);
            this.Controls.Add(this.lbl_releaseNotes);
            this.Controls.Add(this.lbl_latestVersion_label);
            this.Controls.Add(this.lbl_current_label);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_later);
            this.MinimumSize = new System.Drawing.Size(375, 375);
            this.Name = "MtPluginUpdateAvailableDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MT Enhanced Update Available";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_later;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_current_label;
        private System.Windows.Forms.Label lbl_latestVersion_label;
        private System.Windows.Forms.Label lbl_releaseNotes;
        private System.Windows.Forms.Label lbl_currentVersion;
        private System.Windows.Forms.Label lbl_latestVersion;
        private System.Windows.Forms.TextBox txt_releaseNotes;
    }
}