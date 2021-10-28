
namespace RBot
{
    partial class LogForm
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
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.btnSaveDebug = new Telerik.WinControls.UI.RadButton();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.btnClearDebug = new Telerik.WinControls.UI.RadButton();
            this.txtDebugLog = new Telerik.WinControls.UI.RadTextBox();
            this.tabLogs = new Telerik.WinControls.UI.RadPageView();
            this.tabDebugLog = new Telerik.WinControls.UI.RadPageViewPage();
            this.tabScriptLog = new Telerik.WinControls.UI.RadPageViewPage();
            this.txtScriptLog = new Telerik.WinControls.UI.RadTextBox();
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel3 = new Telerik.WinControls.UI.SplitPanel();
            this.btnSaveScript = new Telerik.WinControls.UI.RadButton();
            this.splitPanel4 = new Telerik.WinControls.UI.SplitPanel();
            this.btnClearScript = new Telerik.WinControls.UI.RadButton();
            this.tabFlashCalls = new Telerik.WinControls.UI.RadPageViewPage();
            this.lbFlashCalls = new System.Windows.Forms.ListBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveDebug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearDebug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebugLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLogs)).BeginInit();
            this.tabLogs.SuspendLayout();
            this.tabDebugLog.SuspendLayout();
            this.tabScriptLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtScriptLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).BeginInit();
            this.splitPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).BeginInit();
            this.splitPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearScript)).BeginInit();
            this.tabFlashCalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.EnableCollapsing = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(1, 274);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(422, 28);
            this.radSplitContainer1.SplitterWidth = 3;
            this.radSplitContainer1.TabIndex = 13;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "VisualStudio2012Dark";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.btnSaveDebug);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(210, 28);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.002369642F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(3, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            this.splitPanel1.ThemeName = "VisualStudio2012Dark";
            // 
            // btnSaveDebug
            // 
            this.btnSaveDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveDebug.Location = new System.Drawing.Point(0, 0);
            this.btnSaveDebug.Name = "btnSaveDebug";
            this.btnSaveDebug.Size = new System.Drawing.Size(210, 28);
            this.btnSaveDebug.TabIndex = 0;
            this.btnSaveDebug.Text = "Save";
            this.btnSaveDebug.ThemeName = "VisualStudio2012Dark";
            this.btnSaveDebug.Click += new System.EventHandler(this.btnClearDebug_Click);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.btnClearDebug);
            this.splitPanel2.Location = new System.Drawing.Point(213, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(209, 28);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.002369672F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(-3, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            this.splitPanel2.ThemeName = "VisualStudio2012Dark";
            // 
            // btnClearDebug
            // 
            this.btnClearDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearDebug.Location = new System.Drawing.Point(0, 0);
            this.btnClearDebug.Name = "btnClearDebug";
            this.btnClearDebug.Size = new System.Drawing.Size(209, 28);
            this.btnClearDebug.TabIndex = 0;
            this.btnClearDebug.Text = "Clear";
            this.btnClearDebug.ThemeName = "VisualStudio2012Dark";
            this.btnClearDebug.Click += new System.EventHandler(this.btnSaveDebug_Click);
            // 
            // txtDebugLog
            // 
            this.txtDebugLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebugLog.Location = new System.Drawing.Point(0, 0);
            this.txtDebugLog.MaxLength = 2147483647;
            this.txtDebugLog.Multiline = true;
            this.txtDebugLog.Name = "txtDebugLog";
            this.txtDebugLog.ReadOnly = true;
            // 
            // 
            // 
            this.txtDebugLog.RootElement.StretchVertically = true;
            this.txtDebugLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebugLog.Size = new System.Drawing.Size(423, 271);
            this.txtDebugLog.TabIndex = 15;
            this.txtDebugLog.ThemeName = "VisualStudio2012Dark";
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.tabDebugLog);
            this.tabLogs.Controls.Add(this.tabScriptLog);
            this.tabLogs.Controls.Add(this.tabFlashCalls);
            this.tabLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLogs.EnableAnalytics = false;
            this.tabLogs.EnableGestures = false;
            this.tabLogs.Location = new System.Drawing.Point(0, 0);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.SelectedPage = this.tabDebugLog;
            this.tabLogs.Size = new System.Drawing.Size(433, 337);
            this.tabLogs.TabIndex = 17;
            this.tabLogs.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.tabLogs.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.tabLogs.GetChildAt(0))).DrawBorder = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.tabLogs.GetChildAt(0))).EnableBorderHighlight = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.tabLogs.GetChildAt(0))).ClipDrawing = true;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.tabLogs.GetChildAt(0))).ClickMode = Telerik.WinControls.ClickMode.Release;
            // 
            // tabDebugLog
            // 
            this.tabDebugLog.Controls.Add(this.txtDebugLog);
            this.tabDebugLog.Controls.Add(this.radSplitContainer1);
            this.tabDebugLog.ItemSize = new System.Drawing.SizeF(46F, 24F);
            this.tabDebugLog.Location = new System.Drawing.Point(5, 30);
            this.tabDebugLog.Name = "tabDebugLog";
            this.tabDebugLog.Size = new System.Drawing.Size(423, 302);
            this.tabDebugLog.Text = "Debug";
            // 
            // tabScriptLog
            // 
            this.tabScriptLog.Controls.Add(this.txtScriptLog);
            this.tabScriptLog.Controls.Add(this.radSplitContainer2);
            this.tabScriptLog.ItemSize = new System.Drawing.SizeF(41F, 24F);
            this.tabScriptLog.Location = new System.Drawing.Point(5, 30);
            this.tabScriptLog.Name = "tabScriptLog";
            this.tabScriptLog.Size = new System.Drawing.Size(423, 302);
            this.tabScriptLog.Text = "Script";
            // 
            // txtScriptLog
            // 
            this.txtScriptLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScriptLog.Location = new System.Drawing.Point(0, 0);
            this.txtScriptLog.MaxLength = 2147483647;
            this.txtScriptLog.Multiline = true;
            this.txtScriptLog.Name = "txtScriptLog";
            this.txtScriptLog.ReadOnly = true;
            // 
            // 
            // 
            this.txtScriptLog.RootElement.StretchVertically = true;
            this.txtScriptLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScriptLog.Size = new System.Drawing.Size(423, 271);
            this.txtScriptLog.TabIndex = 19;
            this.txtScriptLog.ThemeName = "VisualStudio2012Dark";
            // 
            // radSplitContainer2
            // 
            this.radSplitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSplitContainer2.Controls.Add(this.splitPanel3);
            this.radSplitContainer2.Controls.Add(this.splitPanel4);
            this.radSplitContainer2.EnableCollapsing = true;
            this.radSplitContainer2.Location = new System.Drawing.Point(1, 274);
            this.radSplitContainer2.Name = "radSplitContainer2";
            // 
            // 
            // 
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer2.Size = new System.Drawing.Size(422, 28);
            this.radSplitContainer2.SplitterWidth = 3;
            this.radSplitContainer2.TabIndex = 18;
            this.radSplitContainer2.TabStop = false;
            this.radSplitContainer2.ThemeName = "VisualStudio2012Dark";
            // 
            // splitPanel3
            // 
            this.splitPanel3.Controls.Add(this.btnSaveScript);
            this.splitPanel3.Location = new System.Drawing.Point(0, 0);
            this.splitPanel3.Name = "splitPanel3";
            // 
            // 
            // 
            this.splitPanel3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel3.Size = new System.Drawing.Size(210, 28);
            this.splitPanel3.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.001193345F, 0F);
            this.splitPanel3.SizeInfo.SplitterCorrection = new System.Drawing.Size(3, 0);
            this.splitPanel3.TabIndex = 0;
            this.splitPanel3.TabStop = false;
            this.splitPanel3.Text = "splitPanel3";
            this.splitPanel3.ThemeName = "VisualStudio2012Dark";
            // 
            // btnSaveScript
            // 
            this.btnSaveScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveScript.Location = new System.Drawing.Point(0, 0);
            this.btnSaveScript.Name = "btnSaveScript";
            this.btnSaveScript.Size = new System.Drawing.Size(210, 28);
            this.btnSaveScript.TabIndex = 0;
            this.btnSaveScript.Text = "Save";
            this.btnSaveScript.ThemeName = "VisualStudio2012Dark";
            this.btnSaveScript.Click += new System.EventHandler(this.btnSaveScript_Click);
            // 
            // splitPanel4
            // 
            this.splitPanel4.Controls.Add(this.btnClearScript);
            this.splitPanel4.Location = new System.Drawing.Point(213, 0);
            this.splitPanel4.Name = "splitPanel4";
            // 
            // 
            // 
            this.splitPanel4.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel4.Size = new System.Drawing.Size(209, 28);
            this.splitPanel4.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.001193315F, 0F);
            this.splitPanel4.SizeInfo.SplitterCorrection = new System.Drawing.Size(-3, 0);
            this.splitPanel4.TabIndex = 1;
            this.splitPanel4.TabStop = false;
            this.splitPanel4.Text = "splitPanel4";
            this.splitPanel4.ThemeName = "VisualStudio2012Dark";
            // 
            // btnClearScript
            // 
            this.btnClearScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearScript.Location = new System.Drawing.Point(0, 0);
            this.btnClearScript.Name = "btnClearScript";
            this.btnClearScript.Size = new System.Drawing.Size(209, 28);
            this.btnClearScript.TabIndex = 0;
            this.btnClearScript.Text = "Clear";
            this.btnClearScript.ThemeName = "VisualStudio2012Dark";
            this.btnClearScript.Click += new System.EventHandler(this.btnClearScript_Click);
            // 
            // tabFlashCalls
            // 
            this.tabFlashCalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.tabFlashCalls.Controls.Add(this.lbFlashCalls);
            this.tabFlashCalls.Controls.Add(this.radPanel1);
            this.tabFlashCalls.ItemSize = new System.Drawing.SizeF(91F, 24F);
            this.tabFlashCalls.Location = new System.Drawing.Point(5, 30);
            this.tabFlashCalls.Name = "tabFlashCalls";
            this.tabFlashCalls.Size = new System.Drawing.Size(423, 302);
            this.tabFlashCalls.Text = "Flash Call Errors";
            // 
            // lbFlashCalls
            // 
            this.lbFlashCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFlashCalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lbFlashCalls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFlashCalls.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbFlashCalls.FormattingEnabled = true;
            this.lbFlashCalls.Location = new System.Drawing.Point(0, 0);
            this.lbFlashCalls.Name = "lbFlashCalls";
            this.lbFlashCalls.Size = new System.Drawing.Size(424, 273);
            this.lbFlashCalls.TabIndex = 18;
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Location = new System.Drawing.Point(0, 274);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(423, 28);
            this.radPanel1.TabIndex = 18;
            this.radPanel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radButton1
            // 
            this.radButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radButton1.Location = new System.Drawing.Point(0, 0);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(423, 28);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Clear";
            this.radButton1.ThemeName = "VisualStudio2012Dark";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(433, 337);
            this.Controls.Add(this.tabLogs);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "LogForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Logs";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.LogForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveDebug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClearDebug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebugLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLogs)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.tabDebugLog.ResumeLayout(false);
            this.tabDebugLog.PerformLayout();
            this.tabScriptLog.ResumeLayout(false);
            this.tabScriptLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtScriptLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).EndInit();
            this.splitPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).EndInit();
            this.splitPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClearScript)).EndInit();
            this.tabFlashCalls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadButton btnSaveDebug;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadButton btnClearDebug;
        private Telerik.WinControls.UI.RadTextBox txtDebugLog;
        private Telerik.WinControls.UI.RadPageView tabLogs;
        private Telerik.WinControls.UI.RadPageViewPage tabDebugLog;
        private Telerik.WinControls.UI.RadPageViewPage tabScriptLog;
        private Telerik.WinControls.UI.RadPageViewPage tabFlashCalls;
        private Telerik.WinControls.UI.RadTextBox txtScriptLog;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer2;
        private Telerik.WinControls.UI.SplitPanel splitPanel3;
        private Telerik.WinControls.UI.RadButton btnSaveScript;
        private Telerik.WinControls.UI.SplitPanel splitPanel4;
        private Telerik.WinControls.UI.RadButton btnClearScript;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.ListBox lbFlashCalls;
    }
}