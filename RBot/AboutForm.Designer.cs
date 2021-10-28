
namespace RBot
{
    partial class AboutForm
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
            this.lblRBotVersion = new Telerik.WinControls.UI.RadLabel();
            this.lblBuildDate = new Telerik.WinControls.UI.RadLabel();
            this.CreditLabel = new Telerik.WinControls.UI.RadLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblWebsite = new Telerik.WinControls.UI.RadLabel();
            this.lblProject = new Telerik.WinControls.UI.RadLabel();
            this.lblDiscord = new Telerik.WinControls.UI.RadLabel();
            this.lblLinkWebsite = new System.Windows.Forms.LinkLabel();
            this.lblLinkProject = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.lblDocs = new Telerik.WinControls.UI.RadLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblRBotVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuildDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRBotVersion
            // 
            this.lblRBotVersion.Location = new System.Drawing.Point(12, 12);
            this.lblRBotVersion.Name = "lblRBotVersion";
            this.lblRBotVersion.Size = new System.Drawing.Size(105, 18);
            this.lblRBotVersion.TabIndex = 1;
            this.lblRBotVersion.Text = "RBot Version 0.0.0.0";
            this.lblRBotVersion.ThemeName = "VisualStudio2012Dark";
            // 
            // lblBuildDate
            // 
            this.lblBuildDate.Location = new System.Drawing.Point(12, 36);
            this.lblBuildDate.Name = "lblBuildDate";
            this.lblBuildDate.Size = new System.Drawing.Size(94, 18);
            this.lblBuildDate.TabIndex = 2;
            this.lblBuildDate.Text = "Build Date: [Date]";
            this.lblBuildDate.ThemeName = "VisualStudio2012Dark";
            // 
            // CreditLabel
            // 
            this.CreditLabel.Location = new System.Drawing.Point(12, 165);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(44, 18);
            this.CreditLabel.TabIndex = 3;
            this.CreditLabel.Text = "Credits:";
            this.CreditLabel.ThemeName = "VisualStudio2012Dark";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(15, 181);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(232, 63);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "1) rodit (https://github.com/rodit/)\n     ⤷ Fork: https://github.com/rodit/RBot\n2" +
    ") bluu (???)\n     ⤷ For our template";
            // 
            // lblWebsite
            // 
            this.lblWebsite.Location = new System.Drawing.Point(12, 60);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(49, 18);
            this.lblWebsite.TabIndex = 5;
            this.lblWebsite.Text = "Website:";
            this.lblWebsite.ThemeName = "VisualStudio2012Dark";
            // 
            // lblProject
            // 
            this.lblProject.Location = new System.Drawing.Point(12, 76);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 18);
            this.lblProject.TabIndex = 6;
            this.lblProject.Text = "Project:";
            this.lblProject.ThemeName = "VisualStudio2012Dark";
            // 
            // lblDiscord
            // 
            this.lblDiscord.Location = new System.Drawing.Point(12, 92);
            this.lblDiscord.Name = "lblDiscord";
            this.lblDiscord.Size = new System.Drawing.Size(47, 18);
            this.lblDiscord.TabIndex = 7;
            this.lblDiscord.Text = "Discord:";
            this.lblDiscord.ThemeName = "VisualStudio2012Dark";
            // 
            // lblLinkWebsite
            // 
            this.lblLinkWebsite.AutoSize = true;
            this.lblLinkWebsite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkWebsite.Location = new System.Drawing.Point(58, 62);
            this.lblLinkWebsite.Name = "lblLinkWebsite";
            this.lblLinkWebsite.Size = new System.Drawing.Size(87, 13);
            this.lblLinkWebsite.TabIndex = 8;
            this.lblLinkWebsite.TabStop = true;
            this.lblLinkWebsite.Text = "https://auqw.tk";
            this.lblLinkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkWebsite_LinkClicked);
            // 
            // lblLinkProject
            // 
            this.lblLinkProject.AutoSize = true;
            this.lblLinkProject.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkProject.Location = new System.Drawing.Point(52, 78);
            this.lblLinkProject.Name = "lblLinkProject";
            this.lblLinkProject.Size = new System.Drawing.Size(192, 13);
            this.lblLinkProject.TabIndex = 9;
            this.lblLinkProject.TabStop = true;
            this.lblLinkProject.Text = "https://github.com/Quiet-ORG/RBot";
            this.lblLinkProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkProject_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.linkLabel3.Location = new System.Drawing.Point(56, 94);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(148, 13);
            this.linkLabel3.TabIndex = 10;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://discord.io/AQWBots";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radPictureBox1.DefaultImage = null;
            this.radPictureBox1.Image = global::RBot.Properties.Resources.rbot;
            this.radPictureBox1.Location = new System.Drawing.Point(334, 12);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.ShowScrollBars = false;
            this.radPictureBox1.Size = new System.Drawing.Size(234, 234);
            this.radPictureBox1.SvgImageXml = null;
            this.radPictureBox1.TabIndex = 11;
            this.radPictureBox1.ThemeName = "VisualStudio2012Dark";
            // 
            // lblDocs
            // 
            this.lblDocs.Location = new System.Drawing.Point(12, 108);
            this.lblDocs.Name = "lblDocs";
            this.lblDocs.Size = new System.Drawing.Size(86, 18);
            this.lblDocs.TabIndex = 12;
            this.lblDocs.Text = "Documentation:";
            this.lblDocs.ThemeName = "VisualStudio2012Dark";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.linkLabel1.Location = new System.Drawing.Point(95, 109);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(212, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://quiet-org.github.io/rbot-scripts/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 261);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblDocs);
            this.Controls.Add(this.radPictureBox1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.lblLinkProject);
            this.Controls.Add(this.lblLinkWebsite);
            this.Controls.Add(this.lblDiscord);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.lblBuildDate);
            this.Controls.Add(this.lblRBotVersion);
            this.MinimumSize = new System.Drawing.Size(588, 294);
            this.Name = "AboutForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "About";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblRBotVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuildDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWebsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadLabel lblRBotVersion;
        private Telerik.WinControls.UI.RadLabel lblBuildDate;
        private Telerik.WinControls.UI.RadLabel CreditLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Telerik.WinControls.UI.RadLabel lblWebsite;
        private Telerik.WinControls.UI.RadLabel lblProject;
        private Telerik.WinControls.UI.RadLabel lblDiscord;
        private System.Windows.Forms.LinkLabel lblLinkWebsite;
        private System.Windows.Forms.LinkLabel lblLinkProject;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private Telerik.WinControls.UI.RadLabel lblDocs;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}