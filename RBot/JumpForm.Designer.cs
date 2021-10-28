namespace RBot
{
    partial class JumpForm
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
            this.cbCell = new System.Windows.Forms.ComboBox();
            this.cbPads = new System.Windows.Forms.ComboBox();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.btnJump = new Telerik.WinControls.UI.RadButton();
            this.btnGetCurrent = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCell
            // 
            this.cbCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cbCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCell.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbCell.FormattingEnabled = true;
            this.cbCell.Location = new System.Drawing.Point(12, 12);
            this.cbCell.Name = "cbCell";
            this.cbCell.Size = new System.Drawing.Size(138, 21);
            this.cbCell.TabIndex = 0;
            // 
            // cbPads
            // 
            this.cbPads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cbPads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPads.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbPads.FormattingEnabled = true;
            this.cbPads.Items.AddRange(new object[] {
            "Spawn",
            "Center",
            "Left",
            "Right",
            "Up",
            "Down",
            "Top",
            "Bottom"});
            this.cbPads.Location = new System.Drawing.Point(156, 12);
            this.cbPads.Name = "cbPads";
            this.cbPads.Size = new System.Drawing.Size(138, 21);
            this.cbPads.TabIndex = 1;
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(156, 39);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(138, 23);
            this.btnJump.TabIndex = 4;
            this.btnJump.Text = "Jump";
            this.btnJump.ThemeName = "VisualStudio2012Dark";
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // btnGetCurrent
            // 
            this.btnGetCurrent.Location = new System.Drawing.Point(12, 39);
            this.btnGetCurrent.Name = "btnGetCurrent";
            this.btnGetCurrent.Size = new System.Drawing.Size(138, 23);
            this.btnGetCurrent.TabIndex = 5;
            this.btnGetCurrent.Text = "Get Current";
            this.btnGetCurrent.ThemeName = "VisualStudio2012Dark";
            this.btnGetCurrent.Click += new System.EventHandler(this.btnGetCurrent_Click);
            // 
            // JumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 76);
            this.Controls.Add(this.btnGetCurrent);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.cbPads);
            this.Controls.Add(this.cbCell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JumpForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Jump";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.btnJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCell;
        private System.Windows.Forms.ComboBox cbPads;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadButton btnJump;
        private Telerik.WinControls.UI.RadButton btnGetCurrent;
    }
}