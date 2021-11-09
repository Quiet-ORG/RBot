namespace RBot
{
    partial class SkillRuleForm
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
            this.lbRules = new System.Windows.Forms.ListBox();
            this.cbRules = new System.Windows.Forms.ComboBox();
            this.propsRule = new Telerik.WinControls.UI.RadPropertyGrid();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnEditCombined = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.propsRule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCombined)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRules
            // 
            this.lbRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.lbRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRules.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbRules.FormattingEnabled = true;
            this.lbRules.Location = new System.Drawing.Point(12, 12);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(223, 234);
            this.lbRules.TabIndex = 0;
            // 
            // cbRules
            // 
            this.cbRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cbRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRules.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbRules.FormattingEnabled = true;
            this.cbRules.Location = new System.Drawing.Point(12, 256);
            this.cbRules.Name = "cbRules";
            this.cbRules.Size = new System.Drawing.Size(137, 21);
            this.cbRules.TabIndex = 1;
            // 
            // propsRule
            // 
            this.propsRule.Location = new System.Drawing.Point(241, 12);
            this.propsRule.Name = "propsRule";
            this.propsRule.Size = new System.Drawing.Size(182, 238);
            this.propsRule.TabIndex = 2;
            this.propsRule.ThemeName = "VisualStudio2012Dark";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Rule";
            this.btnAdd.ThemeName = "VisualStudio2012Dark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditCombined
            // 
            this.btnEditCombined.Location = new System.Drawing.Point(241, 254);
            this.btnEditCombined.Name = "btnEditCombined";
            this.btnEditCombined.Size = new System.Drawing.Size(182, 23);
            this.btnEditCombined.TabIndex = 4;
            this.btnEditCombined.Text = "Combined Rule Options";
            this.btnEditCombined.ThemeName = "VisualStudio2012Dark";
            this.btnEditCombined.Click += new System.EventHandler(this.btnEditCombined_Click);
            // 
            // SkillRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 287);
            this.Controls.Add(this.btnEditCombined);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.propsRule);
            this.Controls.Add(this.cbRules);
            this.Controls.Add(this.lbRules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SkillRuleForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Edit Use Rule";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.SkillRuleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propsRule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCombined)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.ComboBox cbRules;
        private Telerik.WinControls.UI.RadPropertyGrid propsRule;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnEditCombined;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}