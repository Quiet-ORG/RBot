namespace RBot
{
    partial class UpdatesForm
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
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.lblReleaseName = new Telerik.WinControls.UI.RadLabel();
            this.lblUpdateInfo = new Telerik.WinControls.UI.RadLabel();
            this.lblAllReleases = new Telerik.WinControls.UI.RadLabel();
            this.lblTimeLabel = new Telerik.WinControls.UI.RadLabel();
            this.lblStatus = new Telerik.WinControls.UI.RadLabel();
            this.lblLatestVersion = new Telerik.WinControls.UI.RadLabel();
            this.lnkDownload = new System.Windows.Forms.LinkLabel();
            this.lnkDownloadSelected = new System.Windows.Forms.LinkLabel();
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.cbReleases = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblReleaseName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUpdateInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAllReleases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTimeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLatestVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReleaseName
            // 
            this.lblReleaseName.Location = new System.Drawing.Point(12, 19);
            this.lblReleaseName.Name = "lblReleaseName";
            this.lblReleaseName.Size = new System.Drawing.Size(80, 18);
            this.lblReleaseName.TabIndex = 27;
            this.lblReleaseName.Text = "Release: Name";
            this.lblReleaseName.ThemeName = "VisualStudio2012Dark";
            // 
            // lblUpdateInfo
            // 
            this.lblUpdateInfo.Location = new System.Drawing.Point(13, 147);
            this.lblUpdateInfo.Name = "lblUpdateInfo";
            this.lblUpdateInfo.Size = new System.Drawing.Size(106, 18);
            this.lblUpdateInfo.TabIndex = 32;
            this.lblUpdateInfo.Text = "No update selected.";
            this.lblUpdateInfo.ThemeName = "VisualStudio2012Dark";
            // 
            // lblAllReleases
            // 
            this.lblAllReleases.Location = new System.Drawing.Point(12, 108);
            this.lblAllReleases.Name = "lblAllReleases";
            this.lblAllReleases.Size = new System.Drawing.Size(67, 18);
            this.lblAllReleases.TabIndex = 31;
            this.lblAllReleases.Text = "All Releases:";
            this.lblAllReleases.ThemeName = "VisualStudio2012Dark";
            // 
            // lblTimeLabel
            // 
            this.lblTimeLabel.Location = new System.Drawing.Point(12, 35);
            this.lblTimeLabel.Name = "lblTimeLabel";
            this.lblTimeLabel.Size = new System.Drawing.Size(60, 18);
            this.lblTimeLabel.TabIndex = 30;
            this.lblTimeLabel.Text = "Time: Time";
            this.lblTimeLabel.ThemeName = "VisualStudio2012Dark";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 61);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 19);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Loading Status...";
            this.lblStatus.ThemeName = "VisualStudio2012Dark";
            // 
            // lblLatestVersion
            // 
            this.lblLatestVersion.Location = new System.Drawing.Point(12, 3);
            this.lblLatestVersion.Name = "lblLatestVersion";
            this.lblLatestVersion.Size = new System.Drawing.Size(129, 18);
            this.lblLatestVersion.TabIndex = 28;
            this.lblLatestVersion.Text = "Latest Version: Loading...";
            this.lblLatestVersion.ThemeName = "VisualStudio2012Dark";
            // 
            // lnkDownload
            // 
            this.lnkDownload.AutoSize = true;
            this.lnkDownload.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lnkDownload.Location = new System.Drawing.Point(258, 63);
            this.lnkDownload.Name = "lnkDownload";
            this.lnkDownload.Size = new System.Drawing.Size(61, 13);
            this.lnkDownload.TabIndex = 26;
            this.lnkDownload.TabStop = true;
            this.lnkDownload.Text = "Download";
            this.lnkDownload.Visible = false;
            this.lnkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownload_LinkClicked);
            // 
            // lnkDownloadSelected
            // 
            this.lnkDownloadSelected.AutoSize = true;
            this.lnkDownloadSelected.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lnkDownloadSelected.Location = new System.Drawing.Point(258, 148);
            this.lnkDownloadSelected.Name = "lnkDownloadSelected";
            this.lnkDownloadSelected.Size = new System.Drawing.Size(61, 13);
            this.lnkDownloadSelected.TabIndex = 25;
            this.lnkDownloadSelected.TabStop = true;
            this.lnkDownloadSelected.Text = "Download";
            this.lnkDownloadSelected.Visible = false;
            this.lnkDownloadSelected.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownloadSelected_LinkClicked);
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lnkRefresh.Location = new System.Drawing.Point(12, 92);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(46, 13);
            this.lnkRefresh.TabIndex = 24;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "Refresh";
            this.lnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefresh_LinkClicked);
            // 
            // cbReleases
            // 
            this.cbReleases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cbReleases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReleases.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbReleases.FormattingEnabled = true;
            this.cbReleases.Location = new System.Drawing.Point(12, 126);
            this.cbReleases.Name = "cbReleases";
            this.cbReleases.Size = new System.Drawing.Size(303, 21);
            this.cbReleases.TabIndex = 23;
            this.cbReleases.SelectedIndexChanged += new System.EventHandler(this.cbReleases_SelectedIndexChanged);
            // 
            // UpdatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 175);
            this.Controls.Add(this.lblReleaseName);
            this.Controls.Add(this.lblUpdateInfo);
            this.Controls.Add(this.lblAllReleases);
            this.Controls.Add(this.lblTimeLabel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLatestVersion);
            this.Controls.Add(this.lnkDownload);
            this.Controls.Add(this.lnkDownloadSelected);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.cbReleases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdatesForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Updates";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.UpdatesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblReleaseName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUpdateInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAllReleases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTimeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLatestVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadLabel lblReleaseName;
        private Telerik.WinControls.UI.RadLabel lblUpdateInfo;
        private Telerik.WinControls.UI.RadLabel lblAllReleases;
        private Telerik.WinControls.UI.RadLabel lblTimeLabel;
        private Telerik.WinControls.UI.RadLabel lblStatus;
        private Telerik.WinControls.UI.RadLabel lblLatestVersion;
        private System.Windows.Forms.LinkLabel lnkDownload;
        private System.Windows.Forms.LinkLabel lnkDownloadSelected;
        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.ComboBox cbReleases;
    }
}