namespace Sdl.Community.MtEnhancedProvider
{
    partial class MtProviderConfDialog
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
            this.components = new System.ComponentModel.Container();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboProvider = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxMT = new System.Windows.Forms.GroupBox();
            this.btnDeleteSavedMicrosoftCreds = new System.Windows.Forms.Button();
            this.chkCatId = new System.Windows.Forms.CheckBox();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.chkSaveCred = new System.Windows.Forms.CheckBox();
            this.groupBoxGT = new System.Windows.Forms.GroupBox();
            this.btnDeleteSavedGoogleKey = new System.Windows.Forms.Button();
            this.chkSaveKey = new System.Windows.Forms.CheckBox();
            this.textApiKey = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBoxPostedit = new System.Windows.Forms.GroupBox();
            this.txtPostEditFileName = new System.Windows.Forms.TextBox();
            this.btnBrowsePostEditFile = new System.Windows.Forms.Button();
            this.groupBoxPreedit = new System.Windows.Forms.GroupBox();
            this.txtPreEditFileName = new System.Windows.Forms.TextBox();
            this.btnBrowsePreEdit = new System.Windows.Forms.Button();
            this.chkResendDrafts = new System.Windows.Forms.CheckBox();
            this.chkUsePostEdit = new System.Windows.Forms.CheckBox();
            this.chkUsePreEdit = new System.Windows.Forms.CheckBox();
            this.chkPlainTextOnly = new System.Windows.Forms.CheckBox();
            this.btn_checkForUpdates = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxMT.SuspendLayout();
            this.groupBoxGT.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxPostedit.SuspendLayout();
            this.groupBoxPreedit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(207, 327);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "&OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(287, 327);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "&Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboProvider);
            this.groupBox3.Location = new System.Drawing.Point(2, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(332, 55);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose MT provider";
            // 
            // comboProvider
            // 
            this.comboProvider.BackColor = System.Drawing.SystemColors.Window;
            this.comboProvider.FormattingEnabled = true;
            this.comboProvider.Items.AddRange(new object[] {
            "Google Translate",
            "Microsoft Translator"});
            this.comboProvider.Location = new System.Drawing.Point(5, 16);
            this.comboProvider.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboProvider.Name = "comboProvider";
            this.comboProvider.Size = new System.Drawing.Size(324, 21);
            this.comboProvider.TabIndex = 0;
            this.comboProvider.SelectedIndexChanged += new System.EventHandler(this.comboProvider_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 286);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.groupBoxMT);
            this.tabPage1.Controls.Add(this.groupBoxGT);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(345, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Choose provider";
            // 
            // groupBoxMT
            // 
            this.groupBoxMT.Controls.Add(this.btnDeleteSavedMicrosoftCreds);
            this.groupBoxMT.Controls.Add(this.chkCatId);
            this.groupBoxMT.Controls.Add(this.txtCatId);
            this.groupBoxMT.Controls.Add(this.lblClientID);
            this.groupBoxMT.Controls.Add(this.txtClientId);
            this.groupBoxMT.Controls.Add(this.chkSaveCred);
            this.groupBoxMT.Location = new System.Drawing.Point(3, 64);
            this.groupBoxMT.Name = "groupBoxMT";
            this.groupBoxMT.Size = new System.Drawing.Size(329, 198);
            this.groupBoxMT.TabIndex = 5;
            this.groupBoxMT.TabStop = false;
            this.groupBoxMT.Text = "Microsoft Translator credentials";
            this.groupBoxMT.Visible = false;
            // 
            // btnDeleteSavedMicrosoftCreds
            // 
            this.btnDeleteSavedMicrosoftCreds.AutoSize = true;
            this.btnDeleteSavedMicrosoftCreds.Location = new System.Drawing.Point(4, 93);
            this.btnDeleteSavedMicrosoftCreds.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteSavedMicrosoftCreds.Name = "btnDeleteSavedMicrosoftCreds";
            this.btnDeleteSavedMicrosoftCreds.Size = new System.Drawing.Size(145, 25);
            this.btnDeleteSavedMicrosoftCreds.TabIndex = 16;
            this.btnDeleteSavedMicrosoftCreds.Text = "Delete saved credentials";
            this.btnDeleteSavedMicrosoftCreds.UseVisualStyleBackColor = true;
            this.btnDeleteSavedMicrosoftCreds.Click += new System.EventHandler(this.btnDeleteSavedMicrosoftCreds_Click);
            // 
            // chkCatId
            // 
            this.chkCatId.AutoSize = true;
            this.chkCatId.Location = new System.Drawing.Point(5, 129);
            this.chkCatId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkCatId.Name = "chkCatId";
            this.chkCatId.Size = new System.Drawing.Size(106, 17);
            this.chkCatId.TabIndex = 9;
            this.chkCatId.Text = "Use category ID:";
            this.chkCatId.UseVisualStyleBackColor = true;
            this.chkCatId.CheckedChanged += new System.EventHandler(this.chkCatId_CheckedChanged);
            // 
            // txtCatId
            // 
            this.txtCatId.Enabled = false;
            this.txtCatId.Location = new System.Drawing.Point(4, 159);
            this.txtCatId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.Size = new System.Drawing.Size(321, 20);
            this.txtCatId.TabIndex = 10;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(2, 22);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(121, 13);
            this.lblClientID.TabIndex = 15;
            this.lblClientID.Text = "Microsoft Translator Key";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(5, 38);
            this.txtClientId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.PasswordChar = '*';
            this.txtClientId.Size = new System.Drawing.Size(321, 20);
            this.txtClientId.TabIndex = 3;
            // 
            // chkSaveCred
            // 
            this.chkSaveCred.AutoSize = true;
            this.chkSaveCred.Location = new System.Drawing.Point(5, 66);
            this.chkSaveCred.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkSaveCred.Name = "chkSaveCred";
            this.chkSaveCred.Size = new System.Drawing.Size(193, 17);
            this.chkSaveCred.TabIndex = 6;
            this.chkSaveCred.Text = "Save credentials for future sessions";
            this.chkSaveCred.UseVisualStyleBackColor = true;
            // 
            // groupBoxGT
            // 
            this.groupBoxGT.Controls.Add(this.btnDeleteSavedGoogleKey);
            this.groupBoxGT.Controls.Add(this.chkSaveKey);
            this.groupBoxGT.Controls.Add(this.textApiKey);
            this.groupBoxGT.Location = new System.Drawing.Point(3, 268);
            this.groupBoxGT.Name = "groupBoxGT";
            this.groupBoxGT.Size = new System.Drawing.Size(329, 91);
            this.groupBoxGT.TabIndex = 5;
            this.groupBoxGT.TabStop = false;
            this.groupBoxGT.Text = "Google Translate API key";
            this.groupBoxGT.Visible = false;
            // 
            // btnDeleteSavedGoogleKey
            // 
            this.btnDeleteSavedGoogleKey.AutoSize = true;
            this.btnDeleteSavedGoogleKey.Location = new System.Drawing.Point(5, 60);
            this.btnDeleteSavedGoogleKey.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteSavedGoogleKey.Name = "btnDeleteSavedGoogleKey";
            this.btnDeleteSavedGoogleKey.Size = new System.Drawing.Size(105, 25);
            this.btnDeleteSavedGoogleKey.TabIndex = 13;
            this.btnDeleteSavedGoogleKey.Text = "Delete saved key";
            this.btnDeleteSavedGoogleKey.UseVisualStyleBackColor = true;
            this.btnDeleteSavedGoogleKey.Click += new System.EventHandler(this.btnDeleteSavedGoogleKey_Click);
            // 
            // chkSaveKey
            // 
            this.chkSaveKey.AutoSize = true;
            this.chkSaveKey.Location = new System.Drawing.Point(5, 39);
            this.chkSaveKey.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chkSaveKey.Name = "chkSaveKey";
            this.chkSaveKey.Size = new System.Drawing.Size(159, 17);
            this.chkSaveKey.TabIndex = 12;
            this.chkSaveKey.Text = "Save key for future sessions";
            this.chkSaveKey.UseVisualStyleBackColor = true;
            // 
            // textApiKey
            // 
            this.textApiKey.Location = new System.Drawing.Point(5, 18);
            this.textApiKey.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textApiKey.Name = "textApiKey";
            this.textApiKey.PasswordChar = '*';
            this.textApiKey.Size = new System.Drawing.Size(306, 20);
            this.textApiKey.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(345, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Provider options";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBoxPostedit);
            this.groupBox4.Controls.Add(this.groupBoxPreedit);
            this.groupBox4.Controls.Add(this.chkResendDrafts);
            this.groupBox4.Controls.Add(this.chkUsePostEdit);
            this.groupBox4.Controls.Add(this.chkUsePreEdit);
            this.groupBox4.Controls.Add(this.chkPlainTextOnly);
            this.groupBox4.Location = new System.Drawing.Point(2, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(333, 233);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Provider Options";
            // 
            // groupBoxPostedit
            // 
            this.groupBoxPostedit.Controls.Add(this.txtPostEditFileName);
            this.groupBoxPostedit.Controls.Add(this.btnBrowsePostEditFile);
            this.groupBoxPostedit.Location = new System.Drawing.Point(0, 166);
            this.groupBoxPostedit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxPostedit.Name = "groupBoxPostedit";
            this.groupBoxPostedit.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxPostedit.Size = new System.Drawing.Size(326, 45);
            this.groupBoxPostedit.TabIndex = 22;
            this.groupBoxPostedit.TabStop = false;
            this.groupBoxPostedit.Text = "Post-lookup find/replace filename:";
            // 
            // txtPostEditFileName
            // 
            this.txtPostEditFileName.Enabled = false;
            this.txtPostEditFileName.Location = new System.Drawing.Point(2, 17);
            this.txtPostEditFileName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPostEditFileName.MaxLength = 30;
            this.txtPostEditFileName.Name = "txtPostEditFileName";
            this.txtPostEditFileName.ReadOnly = true;
            this.txtPostEditFileName.Size = new System.Drawing.Size(263, 20);
            this.txtPostEditFileName.TabIndex = 8;
            // 
            // btnBrowsePostEditFile
            // 
            this.btnBrowsePostEditFile.Location = new System.Drawing.Point(269, 14);
            this.btnBrowsePostEditFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrowsePostEditFile.Name = "btnBrowsePostEditFile";
            this.btnBrowsePostEditFile.Size = new System.Drawing.Size(55, 23);
            this.btnBrowsePostEditFile.TabIndex = 10;
            this.btnBrowsePostEditFile.Text = "Browse...";
            this.btnBrowsePostEditFile.UseVisualStyleBackColor = true;
            this.btnBrowsePostEditFile.Click += new System.EventHandler(this.btnBrowsePostEditFile_Click);
            // 
            // groupBoxPreedit
            // 
            this.groupBoxPreedit.Controls.Add(this.txtPreEditFileName);
            this.groupBoxPreedit.Controls.Add(this.btnBrowsePreEdit);
            this.groupBoxPreedit.Location = new System.Drawing.Point(2, 87);
            this.groupBoxPreedit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxPreedit.Name = "groupBoxPreedit";
            this.groupBoxPreedit.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxPreedit.Size = new System.Drawing.Size(326, 52);
            this.groupBoxPreedit.TabIndex = 21;
            this.groupBoxPreedit.TabStop = false;
            this.groupBoxPreedit.Text = "Pre-lookup find/replace filename:";
            // 
            // txtPreEditFileName
            // 
            this.txtPreEditFileName.Enabled = false;
            this.txtPreEditFileName.Location = new System.Drawing.Point(5, 19);
            this.txtPreEditFileName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPreEditFileName.MaxLength = 30;
            this.txtPreEditFileName.Name = "txtPreEditFileName";
            this.txtPreEditFileName.ReadOnly = true;
            this.txtPreEditFileName.Size = new System.Drawing.Size(259, 20);
            this.txtPreEditFileName.TabIndex = 20;
            this.txtPreEditFileName.TabStop = false;
            // 
            // btnBrowsePreEdit
            // 
            this.btnBrowsePreEdit.Location = new System.Drawing.Point(267, 17);
            this.btnBrowsePreEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrowsePreEdit.Name = "btnBrowsePreEdit";
            this.btnBrowsePreEdit.Size = new System.Drawing.Size(55, 23);
            this.btnBrowsePreEdit.TabIndex = 14;
            this.btnBrowsePreEdit.Text = "Browse...";
            this.btnBrowsePreEdit.UseVisualStyleBackColor = true;
            this.btnBrowsePreEdit.Click += new System.EventHandler(this.btnBrowsePreEdit_Click);
            // 
            // chkResendDrafts
            // 
            this.chkResendDrafts.AutoSize = true;
            this.chkResendDrafts.Location = new System.Drawing.Point(5, 21);
            this.chkResendDrafts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkResendDrafts.Name = "chkResendDrafts";
            this.chkResendDrafts.Size = new System.Drawing.Size(208, 17);
            this.chkResendDrafts.TabIndex = 11;
            this.chkResendDrafts.Text = "Re-send draft and translated segments";
            this.chkResendDrafts.UseVisualStyleBackColor = true;
            // 
            // chkUsePostEdit
            // 
            this.chkUsePostEdit.AutoSize = true;
            this.chkUsePostEdit.Location = new System.Drawing.Point(2, 144);
            this.chkUsePostEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkUsePostEdit.Name = "chkUsePostEdit";
            this.chkUsePostEdit.Size = new System.Drawing.Size(158, 17);
            this.chkUsePostEdit.TabIndex = 7;
            this.chkUsePostEdit.Text = "Do post-lookup find/replace";
            this.chkUsePostEdit.UseVisualStyleBackColor = true;
            this.chkUsePostEdit.CheckedChanged += new System.EventHandler(this.chkUsePostEdit_CheckedChanged);
            // 
            // chkUsePreEdit
            // 
            this.chkUsePreEdit.AutoSize = true;
            this.chkUsePreEdit.Location = new System.Drawing.Point(5, 65);
            this.chkUsePreEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkUsePreEdit.Name = "chkUsePreEdit";
            this.chkUsePreEdit.Size = new System.Drawing.Size(153, 17);
            this.chkUsePreEdit.TabIndex = 13;
            this.chkUsePreEdit.Text = "Do pre-lookup find/replace";
            this.chkUsePreEdit.UseVisualStyleBackColor = true;
            this.chkUsePreEdit.CheckedChanged += new System.EventHandler(this.chkUsePreEdit_CheckedChanged);
            // 
            // chkPlainTextOnly
            // 
            this.chkPlainTextOnly.AutoSize = true;
            this.chkPlainTextOnly.Location = new System.Drawing.Point(5, 43);
            this.chkPlainTextOnly.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkPlainTextOnly.Name = "chkPlainTextOnly";
            this.chkPlainTextOnly.Size = new System.Drawing.Size(162, 17);
            this.chkPlainTextOnly.TabIndex = 12;
            this.chkPlainTextOnly.Text = "Send plain text only (no tags)";
            this.chkPlainTextOnly.UseVisualStyleBackColor = true;
            // 
            // btn_checkForUpdates
            // 
            this.btn_checkForUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_checkForUpdates.Location = new System.Drawing.Point(9, 327);
            this.btn_checkForUpdates.Name = "btn_checkForUpdates";
            this.btn_checkForUpdates.Size = new System.Drawing.Size(106, 23);
            this.btn_checkForUpdates.TabIndex = 17;
            this.btn_checkForUpdates.Text = "Check for updates";
            this.btn_checkForUpdates.UseVisualStyleBackColor = true;
            this.btn_checkForUpdates.Click += new System.EventHandler(this.btn_checkForUpdates_Click);
            // 
            // MtProviderConfDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 361);
            this.Controls.Add(this.btn_checkForUpdates);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(385, 400);
            this.Name = "MtProviderConfDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxMT.ResumeLayout(false);
            this.groupBoxMT.PerformLayout();
            this.groupBoxGT.ResumeLayout(false);
            this.groupBoxGT.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxPostedit.ResumeLayout(false);
            this.groupBoxPostedit.PerformLayout();
            this.groupBoxPreedit.ResumeLayout(false);
            this.groupBoxPreedit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkCatId;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.GroupBox groupBoxMT;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.CheckBox chkSaveCred;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPreEditFileName;
        private System.Windows.Forms.Button btnBrowsePreEdit;
        private System.Windows.Forms.CheckBox chkResendDrafts;
        private System.Windows.Forms.Button btnBrowsePostEditFile;
        private System.Windows.Forms.TextBox txtPostEditFileName;
        private System.Windows.Forms.CheckBox chkUsePostEdit;
        private System.Windows.Forms.CheckBox chkUsePreEdit;
        private System.Windows.Forms.CheckBox chkPlainTextOnly;
        private System.Windows.Forms.ComboBox comboProvider;
        private System.Windows.Forms.GroupBox groupBoxGT;
        private System.Windows.Forms.CheckBox chkSaveKey;
        private System.Windows.Forms.TextBox textApiKey;
        private System.Windows.Forms.GroupBox groupBoxPreedit;
        private System.Windows.Forms.GroupBox groupBoxPostedit;
        private System.Windows.Forms.Button btnDeleteSavedGoogleKey;
        private System.Windows.Forms.Button btnDeleteSavedMicrosoftCreds;
        private System.Windows.Forms.Button btn_checkForUpdates;
    }
}