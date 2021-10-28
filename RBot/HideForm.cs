using DarkUI.Forms;
using System;
using System.ComponentModel;
using Telerik.WinControls.UI;

namespace RBot
{
    public class HideForm : RadForm
    {
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;

        public ScriptInterface Bot => ScriptInterface.Instance;

        public HideForm() : base()
        {
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        protected override void OnShown(EventArgs e)
        {
            BringToFront();
        }

        public virtual new void Show()
        {
            base.Show();
            BringToFront();
        }

        private void InitializeComponent()
        {
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // HideForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "HideForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
