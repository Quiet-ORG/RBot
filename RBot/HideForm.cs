using System;
using System.ComponentModel;
using Telerik.WinControls.UI;

namespace RBot
{
    public class HideForm : RadForm
    {
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
    }
}
