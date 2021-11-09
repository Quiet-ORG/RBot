namespace RBot
{
    partial class ScriptsForm
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
            this.btnLoadScript = new Telerik.WinControls.UI.RadButton();
            this.btnClearEventHandlers = new Telerik.WinControls.UI.RadButton();
            this.btnEditScript = new Telerik.WinControls.UI.RadButton();
            this.btnConvertGbot = new Telerik.WinControls.UI.RadButton();
            this.btnLoadGbot = new Telerik.WinControls.UI.RadButton();
            this.btnStartScript = new Telerik.WinControls.UI.RadButton();
            this.btnAdvanced = new Telerik.WinControls.UI.RadButton();
            this.btnGetScripts = new Telerik.WinControls.UI.RadButton();
            this.chkRunOnExit = new Telerik.WinControls.UI.RadCheckBox();
            this.txtRunOnExit = new Telerik.WinControls.UI.RadTextBox();
            this.btnOpenLogs = new Telerik.WinControls.UI.RadButton();
            this.btnOpenScriptsFolder = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearEventHandlers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConvertGbot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadGbot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdvanced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetScripts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRunOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRunOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenScriptsFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadScript
            // 
            this.btnLoadScript.Location = new System.Drawing.Point(12, 6);
            this.btnLoadScript.Name = "btnLoadScript";
            this.btnLoadScript.Size = new System.Drawing.Size(294, 23);
            this.btnLoadScript.TabIndex = 10;
            this.btnLoadScript.Text = "Load Script";
            this.btnLoadScript.ThemeName = "VisualStudio2012Dark";
            this.btnLoadScript.Click += new System.EventHandler(this.btnLoadScript_Click);
            // 
            // btnClearEventHandlers
            // 
            this.btnClearEventHandlers.Location = new System.Drawing.Point(12, 187);
            this.btnClearEventHandlers.Name = "btnClearEventHandlers";
            this.btnClearEventHandlers.Size = new System.Drawing.Size(294, 23);
            this.btnClearEventHandlers.TabIndex = 11;
            this.btnClearEventHandlers.Text = "Clear Script Event Handlers";
            this.btnClearEventHandlers.ThemeName = "VisualStudio2012Dark";
            this.btnClearEventHandlers.Click += new System.EventHandler(this.btnClearEventHandlers_Click);
            // 
            // btnEditScript
            // 
            this.btnEditScript.Location = new System.Drawing.Point(12, 35);
            this.btnEditScript.Name = "btnEditScript";
            this.btnEditScript.Size = new System.Drawing.Size(172, 23);
            this.btnEditScript.TabIndex = 12;
            this.btnEditScript.Text = "Open Editor";
            this.btnEditScript.ThemeName = "VisualStudio2012Dark";
            this.btnEditScript.Click += new System.EventHandler(this.btnEditScript_Click);
            // 
            // btnConvertGbot
            // 
            this.btnConvertGbot.Location = new System.Drawing.Point(12, 122);
            this.btnConvertGbot.Name = "btnConvertGbot";
            this.btnConvertGbot.Size = new System.Drawing.Size(172, 23);
            this.btnConvertGbot.TabIndex = 12;
            this.btnConvertGbot.Text = "Convert .gbot to Script";
            this.btnConvertGbot.ThemeName = "VisualStudio2012Dark";
            this.btnConvertGbot.Click += new System.EventHandler(this.btnConvertGbot_Click);
            // 
            // btnLoadGbot
            // 
            this.btnLoadGbot.Location = new System.Drawing.Point(190, 122);
            this.btnLoadGbot.Name = "btnLoadGbot";
            this.btnLoadGbot.Size = new System.Drawing.Size(72, 23);
            this.btnLoadGbot.TabIndex = 12;
            this.btnLoadGbot.Text = "Load .gbot";
            this.btnLoadGbot.ThemeName = "VisualStudio2012Dark";
            this.btnLoadGbot.Click += new System.EventHandler(this.btnLoadGbot_Click);
            // 
            // btnStartScript
            // 
            this.btnStartScript.Location = new System.Drawing.Point(12, 64);
            this.btnStartScript.Name = "btnStartScript";
            this.btnStartScript.Size = new System.Drawing.Size(294, 23);
            this.btnStartScript.TabIndex = 13;
            this.btnStartScript.Text = "Start Script";
            this.btnStartScript.ThemeName = "VisualStudio2012Dark";
            this.btnStartScript.Click += new System.EventHandler(this.btnStartScript_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(268, 122);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(38, 23);
            this.btnAdvanced.TabIndex = 12;
            this.btnAdvanced.Text = ">>";
            this.btnAdvanced.ThemeName = "VisualStudio2012Dark";
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnGetScripts
            // 
            this.btnGetScripts.Location = new System.Drawing.Point(190, 35);
            this.btnGetScripts.Name = "btnGetScripts";
            this.btnGetScripts.Size = new System.Drawing.Size(116, 23);
            this.btnGetScripts.TabIndex = 14;
            this.btnGetScripts.Text = "Get Scripts";
            this.btnGetScripts.ThemeName = "VisualStudio2012Dark";
            this.btnGetScripts.Click += new System.EventHandler(this.btnGetScripts_Click);
            // 
            // chkRunOnExit
            // 
            this.chkRunOnExit.Location = new System.Drawing.Point(225, 159);
            this.chkRunOnExit.Name = "chkRunOnExit";
            this.chkRunOnExit.Size = new System.Drawing.Size(81, 18);
            this.chkRunOnExit.TabIndex = 15;
            this.chkRunOnExit.Text = "Run On Exit";
            this.chkRunOnExit.ThemeName = "VisualStudio2012Dark";
            this.chkRunOnExit.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkRunOnExit_CheckedChanged);
            // 
            // txtRunOnExit
            // 
            this.txtRunOnExit.Location = new System.Drawing.Point(12, 157);
            this.txtRunOnExit.Name = "txtRunOnExit";
            this.txtRunOnExit.Size = new System.Drawing.Size(205, 24);
            this.txtRunOnExit.TabIndex = 16;
            this.txtRunOnExit.ThemeName = "VisualStudio2012Dark";
            // 
            // btnOpenLogs
            // 
            this.btnOpenLogs.Location = new System.Drawing.Point(190, 93);
            this.btnOpenLogs.Name = "btnOpenLogs";
            this.btnOpenLogs.Size = new System.Drawing.Size(116, 23);
            this.btnOpenLogs.TabIndex = 16;
            this.btnOpenLogs.Text = "Open Logs";
            this.btnOpenLogs.ThemeName = "VisualStudio2012Dark";
            this.btnOpenLogs.Click += new System.EventHandler(this.btnOpenLogs_Click);
            // 
            // btnOpenScriptsFolder
            // 
            this.btnOpenScriptsFolder.Location = new System.Drawing.Point(12, 93);
            this.btnOpenScriptsFolder.Name = "btnOpenScriptsFolder";
            this.btnOpenScriptsFolder.Size = new System.Drawing.Size(172, 23);
            this.btnOpenScriptsFolder.TabIndex = 15;
            this.btnOpenScriptsFolder.Text = "Open Scripts Folder";
            this.btnOpenScriptsFolder.ThemeName = "VisualStudio2012Dark";
            this.btnOpenScriptsFolder.Click += new System.EventHandler(this.btnOpenScriptsFolder_Click);
            // 
            // ScriptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 152);
            this.Controls.Add(this.btnOpenLogs);
            this.Controls.Add(this.btnOpenScriptsFolder);
            this.Controls.Add(this.txtRunOnExit);
            this.Controls.Add(this.chkRunOnExit);
            this.Controls.Add(this.btnGetScripts);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnStartScript);
            this.Controls.Add(this.btnConvertGbot);
            this.Controls.Add(this.btnLoadGbot);
            this.Controls.Add(this.btnEditScript);
            this.Controls.Add(this.btnClearEventHandlers);
            this.Controls.Add(this.btnLoadScript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScriptsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Scripts";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearEventHandlers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConvertGbot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadGbot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdvanced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetScripts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRunOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRunOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenScriptsFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadButton btnClearEventHandlers;
        private Telerik.WinControls.UI.RadButton btnEditScript;
        private Telerik.WinControls.UI.RadButton btnConvertGbot;
        private Telerik.WinControls.UI.RadButton btnLoadGbot;
        private Telerik.WinControls.UI.RadButton btnAdvanced;
        private Telerik.WinControls.UI.RadButton btnGetScripts;
        private Telerik.WinControls.UI.RadCheckBox chkRunOnExit;
        private Telerik.WinControls.UI.RadTextBox txtRunOnExit;
        internal Telerik.WinControls.UI.RadButton btnLoadScript;
        internal Telerik.WinControls.UI.RadButton btnStartScript;
        private Telerik.WinControls.UI.RadButton btnOpenLogs;
        private Telerik.WinControls.UI.RadButton btnOpenScriptsFolder;
    }
}