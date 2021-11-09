namespace RBot
{
    partial class StatsForm
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
            this.statsTimer = new System.Windows.Forms.Timer(this.components);
            this.lnkReset = new System.Windows.Forms.LinkLabel();
            this.lblKills = new Telerik.WinControls.UI.RadLabel();
            this.lblDeaths = new Telerik.WinControls.UI.RadLabel();
            this.lblQuests = new Telerik.WinControls.UI.RadLabel();
            this.lblPickups = new Telerik.WinControls.UI.RadLabel();
            this.lblRelogins = new Telerik.WinControls.UI.RadLabel();
            this.lblTime = new Telerik.WinControls.UI.RadLabel();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.lblKills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDeaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPickups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRelogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statsTimer
            // 
            this.statsTimer.Enabled = true;
            this.statsTimer.Interval = 1000;
            this.statsTimer.Tick += new System.EventHandler(this.statsTimer_Tick);
            // 
            // lnkReset
            // 
            this.lnkReset.AutoSize = true;
            this.lnkReset.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lnkReset.Location = new System.Drawing.Point(199, 3);
            this.lnkReset.Name = "lnkReset";
            this.lnkReset.Size = new System.Drawing.Size(35, 13);
            this.lnkReset.TabIndex = 1;
            this.lnkReset.TabStop = true;
            this.lnkReset.Text = "Reset";
            this.lnkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReset_LinkClicked);
            // 
            // lblKills
            // 
            this.lblKills.Location = new System.Drawing.Point(12, 2);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(37, 18);
            this.lblKills.TabIndex = 2;
            this.lblKills.Text = "Kills: 0";
            this.lblKills.ThemeName = "VisualStudio2012Dark";
            // 
            // lblDeaths
            // 
            this.lblDeaths.Location = new System.Drawing.Point(12, 18);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(53, 18);
            this.lblDeaths.TabIndex = 3;
            this.lblDeaths.Text = "Deaths: 0";
            this.lblDeaths.ThemeName = "VisualStudio2012Dark";
            // 
            // lblQuests
            // 
            this.lblQuests.Location = new System.Drawing.Point(12, 34);
            this.lblQuests.Name = "lblQuests";
            this.lblQuests.Size = new System.Drawing.Size(91, 18);
            this.lblQuests.TabIndex = 4;
            this.lblQuests.Text = "Quests (A/C): 0/0";
            this.lblQuests.ThemeName = "VisualStudio2012Dark";
            // 
            // lblPickups
            // 
            this.lblPickups.Location = new System.Drawing.Point(12, 51);
            this.lblPickups.Name = "lblPickups";
            this.lblPickups.Size = new System.Drawing.Size(56, 18);
            this.lblPickups.TabIndex = 5;
            this.lblPickups.Text = "Pickups: 0";
            this.lblPickups.ThemeName = "VisualStudio2012Dark";
            // 
            // lblRelogins
            // 
            this.lblRelogins.Location = new System.Drawing.Point(12, 67);
            this.lblRelogins.Name = "lblRelogins";
            this.lblRelogins.Size = new System.Drawing.Size(61, 18);
            this.lblRelogins.TabIndex = 6;
            this.lblRelogins.Text = "Relogins: 0";
            this.lblRelogins.ThemeName = "VisualStudio2012Dark";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(12, 84);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(78, 18);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time: 00:00:00";
            this.lblTime.ThemeName = "VisualStudio2012Dark";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 108);
            this.Controls.Add(this.lblPickups);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRelogins);
            this.Controls.Add(this.lblQuests);
            this.Controls.Add(this.lblDeaths);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.lnkReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StatsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Stats";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.lblKills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDeaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPickups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRelogins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer statsTimer;
        private System.Windows.Forms.LinkLabel lnkReset;
        private Telerik.WinControls.UI.RadLabel lblKills;
        private Telerik.WinControls.UI.RadLabel lblDeaths;
        private Telerik.WinControls.UI.RadLabel lblQuests;
        private Telerik.WinControls.UI.RadLabel lblPickups;
        private Telerik.WinControls.UI.RadLabel lblRelogins;
        private Telerik.WinControls.UI.RadLabel lblTime;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}