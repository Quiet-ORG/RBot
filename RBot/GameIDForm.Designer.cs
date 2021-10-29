namespace RBot
{
    partial class GameIDForm
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
            this.lbQuests = new System.Windows.Forms.ListBox();
            this.lnkUpdate = new System.Windows.Forms.LinkLabel();
            this.btnCopyID = new Telerik.WinControls.UI.RadButton();
            this.btnCopyName = new Telerik.WinControls.UI.RadButton();
            this.btnLoad = new Telerik.WinControls.UI.RadButton();
            this.txtFilter = new Telerik.WinControls.UI.RadTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new Telerik.WinControls.UI.RadLabel();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopyID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuests
            // 
            this.lbQuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.lbQuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbQuests.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbQuests.FormattingEnabled = true;
            this.lbQuests.Location = new System.Drawing.Point(12, 40);
            this.lbQuests.Name = "lbQuests";
            this.lbQuests.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbQuests.Size = new System.Drawing.Size(462, 234);
            this.lbQuests.TabIndex = 0;
            // 
            // lnkUpdate
            // 
            this.lnkUpdate.AutoSize = true;
            this.lnkUpdate.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lnkUpdate.Location = new System.Drawing.Point(432, 15);
            this.lnkUpdate.Name = "lnkUpdate";
            this.lnkUpdate.Size = new System.Drawing.Size(45, 13);
            this.lnkUpdate.TabIndex = 6;
            this.lnkUpdate.TabStop = true;
            this.lnkUpdate.Text = "Update";
            this.lnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
            // 
            // btnCopyID
            // 
            this.btnCopyID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyID.Location = new System.Drawing.Point(3, 3);
            this.btnCopyID.Name = "btnCopyID";
            this.btnCopyID.Size = new System.Drawing.Size(154, 20);
            this.btnCopyID.TabIndex = 7;
            this.btnCopyID.Text = "Copy IDs (CTRL + C)";
            this.btnCopyID.ThemeName = "VisualStudio2012Dark";
            this.btnCopyID.Click += new System.EventHandler(this.btnCopyID_Click);
            // 
            // btnCopyName
            // 
            this.btnCopyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyName.Location = new System.Drawing.Point(314, 3);
            this.btnCopyName.Name = "btnCopyName";
            this.btnCopyName.Size = new System.Drawing.Size(145, 20);
            this.btnCopyName.TabIndex = 8;
            this.btnCopyName.Text = "Copy Names (Ctrl+Shift+C)";
            this.btnCopyName.ThemeName = "VisualStudio2012Dark";
            this.btnCopyName.Click += new System.EventHandler(this.btnCopyName_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Location = new System.Drawing.Point(163, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(145, 20);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load (Ctrl+L)";
            this.btnLoad.ThemeName = "VisualStudio2012Dark";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Enabled = false;
            this.txtFilter.Location = new System.Drawing.Point(50, 11);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(376, 24);
            this.txtFilter.TabIndex = 10;
            this.txtFilter.Text = "Loading...";
            this.txtFilter.ThemeName = "VisualStudio2012Dark";
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.44695F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.55305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.btnCopyID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyName, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 283);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 26);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(14, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(33, 18);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Filter:";
            this.lblSearch.ThemeName = "VisualStudio2012Dark";
            // 
            // GameIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 316);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lnkUpdate);
            this.Controls.Add(this.lbQuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameIDForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "IDs";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.GameIDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCopyID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuests;
        private System.Windows.Forms.LinkLabel lnkUpdate;
        private Telerik.WinControls.UI.RadButton btnCopyID;
        private Telerik.WinControls.UI.RadButton btnCopyName;
        private Telerik.WinControls.UI.RadButton btnLoad;
        private Telerik.WinControls.UI.RadTextBox txtFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel lblSearch;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}