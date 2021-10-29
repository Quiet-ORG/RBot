namespace RBot
{
    partial class AutoReloginForm
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
            this.cbServers = new System.Windows.Forms.ComboBox();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.chkRelogin = new Telerik.WinControls.UI.RadCheckBox();
            this.chkReloginAny = new Telerik.WinControls.UI.RadCheckBox();
            this.chkSafeRelogin = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chkRelogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReloginAny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSafeRelogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbServers
            // 
            this.cbServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cbServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbServers.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(12, 12);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(335, 21);
            this.cbServers.TabIndex = 0;
            // 
            // chkRelogin
            // 
            this.chkRelogin.Location = new System.Drawing.Point(12, 39);
            this.chkRelogin.Name = "chkRelogin";
            this.chkRelogin.Size = new System.Drawing.Size(88, 18);
            this.chkRelogin.TabIndex = 4;
            this.chkRelogin.Text = "Auto Relogin";
            this.chkRelogin.ThemeName = "VisualStudio2012Dark";
            // 
            // chkReloginAny
            // 
            this.chkReloginAny.Location = new System.Drawing.Point(12, 62);
            this.chkReloginAny.Name = "chkReloginAny";
            this.chkReloginAny.Size = new System.Drawing.Size(133, 18);
            this.chkReloginAny.TabIndex = 5;
            this.chkReloginAny.Text = "Relogin To Any Server";
            this.chkReloginAny.ThemeName = "VisualStudio2012Dark";
            // 
            // chkSafeRelogin
            // 
            this.chkSafeRelogin.Location = new System.Drawing.Point(12, 85);
            this.chkSafeRelogin.Name = "chkSafeRelogin";
            this.chkSafeRelogin.Size = new System.Drawing.Size(85, 18);
            this.chkSafeRelogin.TabIndex = 6;
            this.chkSafeRelogin.Text = "Safe Relogin";
            this.chkSafeRelogin.ThemeName = "VisualStudio2012Dark";
            // 
            // AutoReloginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 112);
            this.Controls.Add(this.chkSafeRelogin);
            this.Controls.Add(this.chkReloginAny);
            this.Controls.Add(this.chkRelogin);
            this.Controls.Add(this.cbServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AutoReloginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Auto Relogin";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.chkRelogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReloginAny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSafeRelogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbServers;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadCheckBox chkRelogin;
        private Telerik.WinControls.UI.RadCheckBox chkReloginAny;
        private Telerik.WinControls.UI.RadCheckBox chkSafeRelogin;
    }
}