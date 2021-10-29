namespace RBot
{
    partial class CosmeticForm
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
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.lnkGrabTarget = new System.Windows.Forms.LinkLabel();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopyAll = new Telerik.WinControls.UI.RadButton();
            this.btnEquipSelected = new Telerik.WinControls.UI.RadButton();
            this.btnGrabCosm = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopyAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEquipSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGrabCosm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPlayer
            // 
            this.cbPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cbPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(12, 13);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(294, 21);
            this.cbPlayer.TabIndex = 0;
            // 
            // lbItems
            // 
            this.lbItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lbItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbItems.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(12, 54);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(394, 169);
            this.lbItems.TabIndex = 2;
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lnkRefresh.Location = new System.Drawing.Point(9, 38);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(84, 13);
            this.lnkRefresh.TabIndex = 3;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "Refresh Players";
            this.lnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefresh_LinkClicked);
            // 
            // lnkGrabTarget
            // 
            this.lnkGrabTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkGrabTarget.AutoSize = true;
            this.lnkGrabTarget.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lnkGrabTarget.Location = new System.Drawing.Point(342, 38);
            this.lnkGrabTarget.Name = "lnkGrabTarget";
            this.lnkGrabTarget.Size = new System.Drawing.Size(67, 13);
            this.lnkGrabTarget.TabIndex = 6;
            this.lnkGrabTarget.TabStop = true;
            this.lnkGrabTarget.Text = "Grab Target";
            this.lnkGrabTarget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGrabTarget_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel1.Controls.Add(this.btnCopyAll, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEquipSelected, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 233);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 27);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyAll.Location = new System.Drawing.Point(3, 3);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(191, 21);
            this.btnCopyAll.TabIndex = 0;
            this.btnCopyAll.Text = "Equip All";
            this.btnCopyAll.ThemeName = "VisualStudio2012Dark";
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // btnEquipSelected
            // 
            this.btnEquipSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquipSelected.Location = new System.Drawing.Point(200, 3);
            this.btnEquipSelected.Name = "btnEquipSelected";
            this.btnEquipSelected.Size = new System.Drawing.Size(191, 21);
            this.btnEquipSelected.TabIndex = 1;
            this.btnEquipSelected.Text = "Equip Selected";
            this.btnEquipSelected.ThemeName = "VisualStudio2012Dark";
            this.btnEquipSelected.Click += new System.EventHandler(this.btnEquipSelected_Click);
            // 
            // btnGrabCosm
            // 
            this.btnGrabCosm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabCosm.Location = new System.Drawing.Point(312, 12);
            this.btnGrabCosm.Name = "btnGrabCosm";
            this.btnGrabCosm.Size = new System.Drawing.Size(94, 23);
            this.btnGrabCosm.TabIndex = 8;
            this.btnGrabCosm.Text = "Grab";
            this.btnGrabCosm.ThemeName = "VisualStudio2012Dark";
            this.btnGrabCosm.Click += new System.EventHandler(this.btnGrabCosm_Click);
            // 
            // CosmeticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 269);
            this.Controls.Add(this.btnGrabCosm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lnkGrabTarget);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.cbPlayer);
            this.Name = "CosmeticForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "SWF Cosmetics";
            this.ThemeName = "VisualStudio2012Dark";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCopyAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEquipSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGrabCosm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.LinkLabel lnkGrabTarget;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton btnCopyAll;
        private Telerik.WinControls.UI.RadButton btnEquipSelected;
        private Telerik.WinControls.UI.RadButton btnGrabCosm;
    }
}