namespace RBot
{
    partial class GenericOptionsForm
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
            this.propOptions = new Telerik.WinControls.UI.RadPropertyGrid();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.propOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // propOptions
            // 
            this.propOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propOptions.EnableFiltering = false;
            this.propOptions.EnableGestures = false;
            this.propOptions.EnableGrouping = false;
            this.propOptions.EnableSorting = false;
            this.propOptions.Location = new System.Drawing.Point(0, 0);
            this.propOptions.Name = "propOptions";
            this.propOptions.Size = new System.Drawing.Size(463, 353);
            this.propOptions.TabIndex = 1;
            this.propOptions.ThemeName = "VisualStudio2012Dark";
            // 
            // GenericOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 353);
            this.Controls.Add(this.propOptions);
            this.Name = "GenericOptionsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Options";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.GenericOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPropertyGrid propOptions;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}