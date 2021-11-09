namespace RBot
{
    partial class OptionsForm
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
            this.components = new System.ComponentModel.Container();
            this.dropTimer = new System.Windows.Forms.Timer(this.components);
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxBankLabel = new System.Windows.Forms.Label();
            this.filledBankLabel = new System.Windows.Forms.Label();
            this.freeBankLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxInvLabel = new System.Windows.Forms.Label();
            this.filledInvLabel = new System.Windows.Forms.Label();
            this.freeInvLabel = new System.Windows.Forms.Label();
            this.chkInfiniteRange = new Telerik.WinControls.UI.RadCheckBox();
            this.btnHotkeys = new Telerik.WinControls.UI.RadButton();
            this.btnReloadMap = new Telerik.WinControls.UI.RadButton();
            this.btnSetGuild = new Telerik.WinControls.UI.RadButton();
            this.txtCustomGuild = new Telerik.WinControls.UI.RadTextBox();
            this.btnSetName = new Telerik.WinControls.UI.RadButton();
            this.txtCustomName = new Telerik.WinControls.UI.RadTextBox();
            this.numFpsCap = new System.Windows.Forms.NumericUpDown();
            this.btnSetFpsCap = new Telerik.WinControls.UI.RadButton();
            this.lblWalkSpeed = new Telerik.WinControls.UI.RadLabel();
            this.numWalkSpeed = new System.Windows.Forms.NumericUpDown();
            this.chkDisableCols = new Telerik.WinControls.UI.RadCheckBox();
            this.chkDisableFX = new Telerik.WinControls.UI.RadCheckBox();
            this.chkFpsCounter = new Telerik.WinControls.UI.RadCheckBox();
            this.chkStaff = new Telerik.WinControls.UI.RadCheckBox();
            this.chkUpgrade = new Telerik.WinControls.UI.RadCheckBox();
            this.chkRejectAll = new Telerik.WinControls.UI.RadCheckBox();
            this.chkAcceptAll = new Telerik.WinControls.UI.RadCheckBox();
            this.chkHidePlayers = new Telerik.WinControls.UI.RadCheckBox();
            this.chkLagKiller = new Telerik.WinControls.UI.RadCheckBox();
            this.chkSkipCutscenes = new Telerik.WinControls.UI.RadCheckBox();
            this.chkPrivRooms = new Telerik.WinControls.UI.RadCheckBox();
            this.chkMagnet = new Telerik.WinControls.UI.RadCheckBox();
            this.chkAggro = new Telerik.WinControls.UI.RadCheckBox();
            this.chkCheckSpace = new Telerik.WinControls.UI.RadCheckBox();
            this.Check = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkInfiniteRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHotkeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReloadMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetGuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomGuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFpsCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetFpsCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWalkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWalkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDisableCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDisableFX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFpsCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUpgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRejectAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcceptAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHidePlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLagKiller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSkipCutscenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrivRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMagnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAggro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheckSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dropTimer
            // 
            this.dropTimer.Interval = 3000;
            this.dropTimer.Tick += new System.EventHandler(this.dropTimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxBankLabel);
            this.groupBox2.Controls.Add(this.filledBankLabel);
            this.groupBox2.Controls.Add(this.freeBankLabel);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(144, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 65);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bank";
            // 
            // maxBankLabel
            // 
            this.maxBankLabel.AutoSize = true;
            this.maxBankLabel.Location = new System.Drawing.Point(6, 16);
            this.maxBankLabel.Name = "maxBankLabel";
            this.maxBankLabel.Size = new System.Drawing.Size(60, 13);
            this.maxBankLabel.TabIndex = 26;
            this.maxBankLabel.Text = "Max: NULL";
            this.maxBankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filledBankLabel
            // 
            this.filledBankLabel.AutoSize = true;
            this.filledBankLabel.Location = new System.Drawing.Point(69, 16);
            this.filledBankLabel.Name = "filledBankLabel";
            this.filledBankLabel.Size = new System.Drawing.Size(67, 13);
            this.filledBankLabel.TabIndex = 27;
            this.filledBankLabel.Text = "Filled: NULL";
            this.filledBankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // freeBankLabel
            // 
            this.freeBankLabel.AutoSize = true;
            this.freeBankLabel.Location = new System.Drawing.Point(39, 42);
            this.freeBankLabel.Name = "freeBankLabel";
            this.freeBankLabel.Size = new System.Drawing.Size(61, 13);
            this.freeBankLabel.TabIndex = 28;
            this.freeBankLabel.Text = "Free: NULL";
            this.freeBankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxInvLabel);
            this.groupBox1.Controls.Add(this.filledInvLabel);
            this.groupBox1.Controls.Add(this.freeInvLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(3, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 65);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // maxInvLabel
            // 
            this.maxInvLabel.AutoSize = true;
            this.maxInvLabel.Location = new System.Drawing.Point(6, 16);
            this.maxInvLabel.Name = "maxInvLabel";
            this.maxInvLabel.Size = new System.Drawing.Size(60, 13);
            this.maxInvLabel.TabIndex = 26;
            this.maxInvLabel.Text = "Max: NULL";
            this.maxInvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filledInvLabel
            // 
            this.filledInvLabel.AutoSize = true;
            this.filledInvLabel.Location = new System.Drawing.Point(69, 16);
            this.filledInvLabel.Name = "filledInvLabel";
            this.filledInvLabel.Size = new System.Drawing.Size(67, 13);
            this.filledInvLabel.TabIndex = 27;
            this.filledInvLabel.Text = "Filled: NULL";
            this.filledInvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // freeInvLabel
            // 
            this.freeInvLabel.AutoSize = true;
            this.freeInvLabel.Location = new System.Drawing.Point(39, 42);
            this.freeInvLabel.Name = "freeInvLabel";
            this.freeInvLabel.Size = new System.Drawing.Size(61, 13);
            this.freeInvLabel.TabIndex = 28;
            this.freeInvLabel.Text = "Free: NULL";
            this.freeInvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkInfiniteRange
            // 
            this.chkInfiniteRange.Location = new System.Drawing.Point(20, 12);
            this.chkInfiniteRange.Name = "chkInfiniteRange";
            this.chkInfiniteRange.Size = new System.Drawing.Size(92, 18);
            this.chkInfiniteRange.TabIndex = 72;
            this.chkInfiniteRange.Text = "Infinite Range";
            this.chkInfiniteRange.ThemeName = "VisualStudio2012Dark";
            // 
            // btnHotkeys
            // 
            this.btnHotkeys.Location = new System.Drawing.Point(20, 315);
            this.btnHotkeys.Name = "btnHotkeys";
            this.btnHotkeys.Size = new System.Drawing.Size(243, 23);
            this.btnHotkeys.TabIndex = 71;
            this.btnHotkeys.Text = "Hotkeys";
            this.btnHotkeys.ThemeName = "VisualStudio2012Dark";
            this.btnHotkeys.Click += new System.EventHandler(this.btnHotkeys_Click);
            // 
            // btnReloadMap
            // 
            this.btnReloadMap.Location = new System.Drawing.Point(20, 286);
            this.btnReloadMap.Name = "btnReloadMap";
            this.btnReloadMap.Size = new System.Drawing.Size(243, 23);
            this.btnReloadMap.TabIndex = 70;
            this.btnReloadMap.Text = "Reload Map";
            this.btnReloadMap.ThemeName = "VisualStudio2012Dark";
            this.btnReloadMap.Click += new System.EventHandler(this.btnReloadMap_Click);
            // 
            // btnSetGuild
            // 
            this.btnSetGuild.Location = new System.Drawing.Point(172, 257);
            this.btnSetGuild.Name = "btnSetGuild";
            this.btnSetGuild.Size = new System.Drawing.Size(91, 23);
            this.btnSetGuild.TabIndex = 69;
            this.btnSetGuild.Text = "Set Guild";
            this.btnSetGuild.ThemeName = "VisualStudio2012Dark";
            this.btnSetGuild.Click += new System.EventHandler(this.btnSetGuild_Click);
            // 
            // txtCustomGuild
            // 
            this.txtCustomGuild.Location = new System.Drawing.Point(20, 256);
            this.txtCustomGuild.Name = "txtCustomGuild";
            this.txtCustomGuild.Size = new System.Drawing.Size(146, 24);
            this.txtCustomGuild.TabIndex = 68;
            this.txtCustomGuild.ThemeName = "VisualStudio2012Dark";
            // 
            // btnSetName
            // 
            this.btnSetName.Location = new System.Drawing.Point(172, 228);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(91, 23);
            this.btnSetName.TabIndex = 67;
            this.btnSetName.Text = "Set Name";
            this.btnSetName.ThemeName = "VisualStudio2012Dark";
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click);
            // 
            // txtCustomName
            // 
            this.txtCustomName.Location = new System.Drawing.Point(20, 227);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(146, 24);
            this.txtCustomName.TabIndex = 66;
            this.txtCustomName.ThemeName = "VisualStudio2012Dark";
            // 
            // numFpsCap
            // 
            this.numFpsCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.numFpsCap.ForeColor = System.Drawing.Color.Gainsboro;
            this.numFpsCap.Location = new System.Drawing.Point(20, 201);
            this.numFpsCap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFpsCap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFpsCap.Name = "numFpsCap";
            this.numFpsCap.Size = new System.Drawing.Size(146, 20);
            this.numFpsCap.TabIndex = 65;
            this.numFpsCap.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnSetFpsCap
            // 
            this.btnSetFpsCap.Location = new System.Drawing.Point(172, 199);
            this.btnSetFpsCap.Name = "btnSetFpsCap";
            this.btnSetFpsCap.Size = new System.Drawing.Size(91, 23);
            this.btnSetFpsCap.TabIndex = 64;
            this.btnSetFpsCap.Text = "Set FPS Cap";
            this.btnSetFpsCap.ThemeName = "VisualStudio2012Dark";
            this.btnSetFpsCap.Click += new System.EventHandler(this.btnSetFpsCap_Click);
            // 
            // lblWalkSpeed
            // 
            this.lblWalkSpeed.Location = new System.Drawing.Point(20, 175);
            this.lblWalkSpeed.Name = "lblWalkSpeed";
            this.lblWalkSpeed.Size = new System.Drawing.Size(68, 18);
            this.lblWalkSpeed.TabIndex = 63;
            this.lblWalkSpeed.Text = "Walk Speed:";
            this.lblWalkSpeed.ThemeName = "VisualStudio2012Dark";
            // 
            // numWalkSpeed
            // 
            this.numWalkSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.numWalkSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            this.numWalkSpeed.Location = new System.Drawing.Point(95, 174);
            this.numWalkSpeed.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numWalkSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWalkSpeed.Name = "numWalkSpeed";
            this.numWalkSpeed.Size = new System.Drawing.Size(71, 20);
            this.numWalkSpeed.TabIndex = 62;
            this.numWalkSpeed.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // chkDisableCols
            // 
            this.chkDisableCols.Location = new System.Drawing.Point(160, 150);
            this.chkDisableCols.Name = "chkDisableCols";
            this.chkDisableCols.Size = new System.Drawing.Size(110, 18);
            this.chkDisableCols.TabIndex = 61;
            this.chkDisableCols.Text = "Disable Collisions";
            this.chkDisableCols.ThemeName = "VisualStudio2012Dark";
            // 
            // chkDisableFX
            // 
            this.chkDisableFX.Location = new System.Drawing.Point(160, 127);
            this.chkDisableFX.Name = "chkDisableFX";
            this.chkDisableFX.Size = new System.Drawing.Size(75, 18);
            this.chkDisableFX.TabIndex = 60;
            this.chkDisableFX.Text = "Disable FX";
            this.chkDisableFX.ThemeName = "VisualStudio2012Dark";
            // 
            // chkFpsCounter
            // 
            this.chkFpsCounter.Location = new System.Drawing.Point(160, 104);
            this.chkFpsCounter.Name = "chkFpsCounter";
            this.chkFpsCounter.Size = new System.Drawing.Size(84, 18);
            this.chkFpsCounter.TabIndex = 59;
            this.chkFpsCounter.Text = "FPS Counter";
            this.chkFpsCounter.ThemeName = "VisualStudio2012Dark";
            this.chkFpsCounter.CheckStateChanged += new System.EventHandler(this.chkFpsCounter_CheckedChanged);
            // 
            // chkStaff
            // 
            this.chkStaff.Location = new System.Drawing.Point(160, 81);
            this.chkStaff.Name = "chkStaff";
            this.chkStaff.Size = new System.Drawing.Size(46, 18);
            this.chkStaff.TabIndex = 58;
            this.chkStaff.Text = "Staff";
            this.chkStaff.ThemeName = "VisualStudio2012Dark";
            this.chkStaff.CheckStateChanged += new System.EventHandler(this.chkStaff_CheckedChanged);
            // 
            // chkUpgrade
            // 
            this.chkUpgrade.Location = new System.Drawing.Point(160, 58);
            this.chkUpgrade.Name = "chkUpgrade";
            this.chkUpgrade.Size = new System.Drawing.Size(67, 18);
            this.chkUpgrade.TabIndex = 57;
            this.chkUpgrade.Text = "Upgrade";
            this.chkUpgrade.ThemeName = "VisualStudio2012Dark";
            this.chkUpgrade.CheckStateChanged += new System.EventHandler(this.chkUpgrade_CheckedChanged);
            // 
            // chkRejectAll
            // 
            this.chkRejectAll.Location = new System.Drawing.Point(160, 35);
            this.chkRejectAll.Name = "chkRejectAll";
            this.chkRejectAll.Size = new System.Drawing.Size(103, 18);
            this.chkRejectAll.TabIndex = 56;
            this.chkRejectAll.Text = "Reject All Drops";
            this.chkRejectAll.ThemeName = "VisualStudio2012Dark";
            this.chkRejectAll.CheckStateChanged += new System.EventHandler(this.chkRejectAll_CheckedChanged);
            // 
            // chkAcceptAll
            // 
            this.chkAcceptAll.Location = new System.Drawing.Point(160, 12);
            this.chkAcceptAll.Name = "chkAcceptAll";
            this.chkAcceptAll.Size = new System.Drawing.Size(106, 18);
            this.chkAcceptAll.TabIndex = 55;
            this.chkAcceptAll.Text = "Accept All Drops";
            this.chkAcceptAll.ThemeName = "VisualStudio2012Dark";
            this.chkAcceptAll.CheckStateChanged += new System.EventHandler(this.chkAcceptAll_CheckedChanged);
            // 
            // chkHidePlayers
            // 
            this.chkHidePlayers.Location = new System.Drawing.Point(20, 150);
            this.chkHidePlayers.Name = "chkHidePlayers";
            this.chkHidePlayers.Size = new System.Drawing.Size(85, 18);
            this.chkHidePlayers.TabIndex = 54;
            this.chkHidePlayers.Text = "Hide Players";
            this.chkHidePlayers.ThemeName = "VisualStudio2012Dark";
            // 
            // chkLagKiller
            // 
            this.chkLagKiller.Location = new System.Drawing.Point(20, 127);
            this.chkLagKiller.Name = "chkLagKiller";
            this.chkLagKiller.Size = new System.Drawing.Size(69, 18);
            this.chkLagKiller.TabIndex = 53;
            this.chkLagKiller.Text = "Lag Killer";
            this.chkLagKiller.ThemeName = "VisualStudio2012Dark";
            // 
            // chkSkipCutscenes
            // 
            this.chkSkipCutscenes.Location = new System.Drawing.Point(20, 104);
            this.chkSkipCutscenes.Name = "chkSkipCutscenes";
            this.chkSkipCutscenes.Size = new System.Drawing.Size(98, 18);
            this.chkSkipCutscenes.TabIndex = 52;
            this.chkSkipCutscenes.Text = "Skip Cutscenes";
            this.chkSkipCutscenes.ThemeName = "VisualStudio2012Dark";
            // 
            // chkPrivRooms
            // 
            this.chkPrivRooms.Location = new System.Drawing.Point(20, 81);
            this.chkPrivRooms.Name = "chkPrivRooms";
            this.chkPrivRooms.Size = new System.Drawing.Size(95, 18);
            this.chkPrivRooms.TabIndex = 51;
            this.chkPrivRooms.Text = "Private Rooms";
            this.chkPrivRooms.ThemeName = "VisualStudio2012Dark";
            // 
            // chkMagnet
            // 
            this.chkMagnet.Location = new System.Drawing.Point(20, 58);
            this.chkMagnet.Name = "chkMagnet";
            this.chkMagnet.Size = new System.Drawing.Size(98, 18);
            this.chkMagnet.TabIndex = 50;
            this.chkMagnet.Text = "Enemy Magnet";
            this.chkMagnet.ThemeName = "VisualStudio2012Dark";
            // 
            // chkAggro
            // 
            this.chkAggro.Location = new System.Drawing.Point(20, 35);
            this.chkAggro.Name = "chkAggro";
            this.chkAggro.Size = new System.Drawing.Size(104, 18);
            this.chkAggro.TabIndex = 49;
            this.chkAggro.Text = "Aggro Monsters";
            this.chkAggro.ThemeName = "VisualStudio2012Dark";
            // 
            // chkCheckSpace
            // 
            this.chkCheckSpace.Location = new System.Drawing.Point(172, 174);
            this.chkCheckSpace.Name = "chkCheckSpace";
            this.chkCheckSpace.Size = new System.Drawing.Size(86, 18);
            this.chkCheckSpace.TabIndex = 73;
            this.chkCheckSpace.Text = "Check Space";
            this.chkCheckSpace.ThemeName = "VisualStudio2012Dark";
            this.chkCheckSpace.CheckStateChanged += new System.EventHandler(this.chkCheckSpace_CheckChanged);
            // 
            // Check
            // 
            this.Check.Interval = 1000;
            this.Check.Tick += new System.EventHandler(this.Check_Tick);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 347);
            this.Controls.Add(this.chkCheckSpace);
            this.Controls.Add(this.chkInfiniteRange);
            this.Controls.Add(this.btnHotkeys);
            this.Controls.Add(this.btnReloadMap);
            this.Controls.Add(this.btnSetGuild);
            this.Controls.Add(this.txtCustomGuild);
            this.Controls.Add(this.btnSetName);
            this.Controls.Add(this.txtCustomName);
            this.Controls.Add(this.numFpsCap);
            this.Controls.Add(this.btnSetFpsCap);
            this.Controls.Add(this.lblWalkSpeed);
            this.Controls.Add(this.numWalkSpeed);
            this.Controls.Add(this.chkDisableCols);
            this.Controls.Add(this.chkDisableFX);
            this.Controls.Add(this.chkFpsCounter);
            this.Controls.Add(this.chkStaff);
            this.Controls.Add(this.chkUpgrade);
            this.Controls.Add(this.chkRejectAll);
            this.Controls.Add(this.chkAcceptAll);
            this.Controls.Add(this.chkHidePlayers);
            this.Controls.Add(this.chkLagKiller);
            this.Controls.Add(this.chkSkipCutscenes);
            this.Controls.Add(this.chkPrivRooms);
            this.Controls.Add(this.chkMagnet);
            this.Controls.Add(this.chkAggro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Options";
            this.ThemeName = "VisualStudio2012Dark";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkInfiniteRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHotkeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReloadMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetGuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomGuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFpsCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetFpsCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWalkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWalkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDisableCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDisableFX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFpsCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUpgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRejectAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcceptAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHidePlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLagKiller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSkipCutscenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrivRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMagnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAggro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheckSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer dropTimer;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label maxBankLabel;
        private System.Windows.Forms.Label filledBankLabel;
        private System.Windows.Forms.Label freeBankLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label maxInvLabel;
        private System.Windows.Forms.Label filledInvLabel;
        private System.Windows.Forms.Label freeInvLabel;
        private Telerik.WinControls.UI.RadCheckBox chkInfiniteRange;
        private Telerik.WinControls.UI.RadButton btnHotkeys;
        private Telerik.WinControls.UI.RadButton btnReloadMap;
        private Telerik.WinControls.UI.RadButton btnSetGuild;
        private Telerik.WinControls.UI.RadTextBox txtCustomGuild;
        private Telerik.WinControls.UI.RadButton btnSetName;
        private Telerik.WinControls.UI.RadTextBox txtCustomName;
        private System.Windows.Forms.NumericUpDown numFpsCap;
        private Telerik.WinControls.UI.RadButton btnSetFpsCap;
        private Telerik.WinControls.UI.RadLabel lblWalkSpeed;
        private System.Windows.Forms.NumericUpDown numWalkSpeed;
        private Telerik.WinControls.UI.RadCheckBox chkDisableCols;
        private Telerik.WinControls.UI.RadCheckBox chkDisableFX;
        private Telerik.WinControls.UI.RadCheckBox chkFpsCounter;
        private Telerik.WinControls.UI.RadCheckBox chkStaff;
        private Telerik.WinControls.UI.RadCheckBox chkUpgrade;
        private Telerik.WinControls.UI.RadCheckBox chkRejectAll;
        private Telerik.WinControls.UI.RadCheckBox chkAcceptAll;
        private Telerik.WinControls.UI.RadCheckBox chkHidePlayers;
        private Telerik.WinControls.UI.RadCheckBox chkLagKiller;
        private Telerik.WinControls.UI.RadCheckBox chkSkipCutscenes;
        private Telerik.WinControls.UI.RadCheckBox chkPrivRooms;
        private Telerik.WinControls.UI.RadCheckBox chkMagnet;
        private Telerik.WinControls.UI.RadCheckBox chkAggro;
        private Telerik.WinControls.UI.RadCheckBox chkCheckSpace;
        private System.Windows.Forms.Timer Check;
    }
}