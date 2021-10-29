namespace RBot
{
    partial class LoadersForm
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
            this.cbLoadType = new System.Windows.Forms.ComboBox();
            this.lbGrab = new System.Windows.Forms.ListBox();
            this.cbGrabType = new System.Windows.Forms.ComboBox();
            this.lnkIds = new System.Windows.Forms.LinkLabel();
            this.btnGrab = new Telerik.WinControls.UI.RadButton();
            this.txtIds = new Telerik.WinControls.UI.RadTextBox();
            this.btnLoad = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.propsGrabbed = new Telerik.WinControls.UI.RadPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.btnGrab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propsGrabbed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoadType
            // 
            this.cbLoadType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cbLoadType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoadType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbLoadType.FormattingEnabled = true;
            this.cbLoadType.Items.AddRange(new object[] {
            "Shop",
            "Quests"});
            this.cbLoadType.Location = new System.Drawing.Point(420, 11);
            this.cbLoadType.Name = "cbLoadType";
            this.cbLoadType.Size = new System.Drawing.Size(61, 21);
            this.cbLoadType.TabIndex = 2;
            this.cbLoadType.Text = "Shop";
            // 
            // lbGrab
            // 
            this.lbGrab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lbGrab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbGrab.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbGrab.FormattingEnabled = true;
            this.lbGrab.Location = new System.Drawing.Point(12, 67);
            this.lbGrab.Name = "lbGrab";
            this.lbGrab.Size = new System.Drawing.Size(219, 221);
            this.lbGrab.TabIndex = 3;
            // 
            // cbGrabType
            // 
            this.cbGrabType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cbGrabType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGrabType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbGrabType.FormattingEnabled = true;
            this.cbGrabType.Items.AddRange(new object[] {
            "Shop Items",
            "Shop IDs",
            "Quests",
            "Inventory Items",
            "Temp Inventory Items",
            "Bank Items",
            "Cell Monsters",
            "Map Monsters",
            "Map Item IDs"});
            this.cbGrabType.Location = new System.Drawing.Point(12, 298);
            this.cbGrabType.Name = "cbGrabType";
            this.cbGrabType.Size = new System.Drawing.Size(219, 21);
            this.cbGrabType.TabIndex = 5;
            this.cbGrabType.Text = "Shop Items";
            // 
            // lnkIds
            // 
            this.lnkIds.AutoSize = true;
            this.lnkIds.BackColor = System.Drawing.Color.Transparent;
            this.lnkIds.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lnkIds.Location = new System.Drawing.Point(427, 43);
            this.lnkIds.Name = "lnkIds";
            this.lnkIds.Size = new System.Drawing.Size(56, 13);
            this.lnkIds.TabIndex = 7;
            this.lnkIds.TabStop = true;
            this.lnkIds.Text = "Quest IDs";
            this.lnkIds.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIds_LinkClicked);
            // 
            // btnGrab
            // 
            this.btnGrab.Location = new System.Drawing.Point(237, 297);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(244, 23);
            this.btnGrab.TabIndex = 9;
            this.btnGrab.Text = "Grab";
            this.btnGrab.ThemeName = "VisualStudio2012Dark";
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // txtIds
            // 
            this.txtIds.Location = new System.Drawing.Point(12, 11);
            this.txtIds.Name = "txtIds";
            this.txtIds.Size = new System.Drawing.Size(406, 24);
            this.txtIds.TabIndex = 10;
            this.txtIds.ThemeName = "VisualStudio2012Dark";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(407, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.ThemeName = "VisualStudio2012Dark";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // propsGrabbed
            // 
            this.propsGrabbed.EnableFiltering = false;
            this.propsGrabbed.EnableGrouping = false;
            this.propsGrabbed.EnableSorting = false;
            this.propsGrabbed.HelpVisible = false;
            this.propsGrabbed.Location = new System.Drawing.Point(237, 67);
            this.propsGrabbed.Name = "propsGrabbed";
            this.propsGrabbed.ReadOnly = true;
            this.propsGrabbed.Size = new System.Drawing.Size(244, 225);
            this.propsGrabbed.TabIndex = 11;
            this.propsGrabbed.ThemeName = "VisualStudio2012Dark";
            // 
            // LoadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 332);
            this.Controls.Add(this.propsGrabbed);
            this.Controls.Add(this.txtIds);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lnkIds);
            this.Controls.Add(this.cbGrabType);
            this.Controls.Add(this.lbGrab);
            this.Controls.Add(this.cbLoadType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoadersForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Loaders";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.btnGrab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propsGrabbed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbLoadType;
        private System.Windows.Forms.ListBox lbGrab;
        private System.Windows.Forms.ComboBox cbGrabType;
        private System.Windows.Forms.LinkLabel lnkIds;
        private Telerik.WinControls.UI.RadButton btnGrab;
        private Telerik.WinControls.UI.RadTextBox txtIds;
        private Telerik.WinControls.UI.RadButton btnLoad;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadPropertyGrid propsGrabbed;
    }
}