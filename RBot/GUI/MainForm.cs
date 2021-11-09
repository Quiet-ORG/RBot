﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

using AxShockwaveFlashObjects;

using RBot.Flash;
using RBot.PatchProxy;
using RBot.Updates;
using RBot.Plugins;
using RBot.Utils;
using RBot.Options;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace RBot
{
    public partial class MainForm : RadForm
    {
        public ScriptInterface Bot => ScriptInterface.Instance;
        public RadMenu MainMenu => mainMenu;
        public MainForm()
        {
            Forms.Main = this;

            if (AppRuntime.Options.Get<bool>("proxy.enabled"))
            {
                (RProxyServer.Instance = new RProxyServer(AppRuntime.Options.Get<int>("proxy.port"))).Start();
                WinINetProxyHook.Hook();
            }

            InitializeComponent();
            InitFlash();

            Bot.Init();

            Directory.GetFiles("plugins", "*.dll").ForEach(p =>
            {
                Exception e = PluginManager.Load(p);
                if (e != null)
                    Debug.WriteLine($"Error while loading plugin '{p}': {e.Message}");
            });

            KeyPreview = true;
            KeyPress += MainForm_KeyPress;
            FormClosing += MainForm_FormClosing;

            debugToolStripMenuItem.Visibility = Debugger.IsAttached ? ElementVisibility.Visible : ElementVisibility.Hidden;
            scripteditorToolStripMenuItem.Visibility = Debugger.IsAttached ? ElementVisibility.Visible : ElementVisibility.Hidden;
            botbuilderToolStripMenuItem.Visibility = Debugger.IsAttached ? ElementVisibility.Visible : ElementVisibility.Hidden;
            if (Debugger.IsAttached)
            {
                Forms.Log.Show();
                Debug.WriteLine("Debugger is attached.");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            IOption opt = AppRuntime.Options.Options.Find(x => x.Name.StartsWith("binding.") && (Keys)AppRuntime.Options.Get<int>(x) == keyData);
            if (opt != null)
            {
                _ProcessBinding(opt.Name.Split('.')[1]);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void _ProcessBinding(string binding)
        {
            Forms.Scripts.Show();
            switch (binding)
            {
                case "start":
                    if (!ScriptManager.ScriptRunning)
                        Forms.Scripts.btnStartScript.PerformClick();
                    break;
                case "stop":
                    if (ScriptManager.ScriptRunning)
                        Forms.Scripts.btnStartScript.PerformClick();
                    break;
                case "toggle":
                    Forms.Scripts.btnStartScript.PerformClick();
                    break;
                case "load":
                    Forms.Scripts.btnLoadScript.PerformClick();
                    break;
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '#')
                Forms.Console.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bot.Exit();
        }

        public void InitFlash()
        {
            if (!EoLHook.IsHooked)
            {
                EoLHook.Hook();
            }

            FlashUtil.Flash?.Dispose();

            AxShockwaveFlash flash = new AxShockwaveFlash();
            flash.BeginInit();
            flash.Name = "flash";
            flash.Dock = DockStyle.Fill;
            flash.TabIndex = 0;
            flash.FlashCall += FlashUtil.CallHandler;
            gameContainer.Controls.Add(flash);
            flash.EndInit();
            FlashUtil.Flash = flash;

            byte[] swf = File.ReadAllBytes("rbot.swf");
            using (MemoryStream stream = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                writer.Write(8 + swf.Length);
                writer.Write(1432769894);
                writer.Write(swf.Length);
                writer.Write(swf);
                writer.Seek(0, SeekOrigin.Begin);
                flash.OcxState = new AxHost.State(stream, 1, false, null);
            }

            EoLHook.Unhook();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (AppRuntime.Options.Get<bool>("updates.check"))
            {
                List<UpdateInfo> infos = await UpdateChecker.GetReleases();
                UpdateInfo latest = infos.OrderByDescending(x => x.ParsedVersion).FirstOrDefault(x => AppRuntime.Options.Get<bool>("updates.beta") || !x.Prerelease);
                if (latest?.ParsedVersion.CompareTo(Version.Parse(Application.ProductVersion)) > 0)
                {
                    RadMessageBox.SetThemeName("VisualStudio2012Dark");
                    if (RadMessageBox.Show($"An update is available:\r\n{latest.Name}\r\nVersion: {latest.Version}\r\n{(latest.Prerelease ? "This is a prerelease update.\r\n" : "")}Would you like to download it?", "Update Available", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                        Process.Start(latest.URL);
                }
            }
        }

        private void reloadFlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitFlash();
        }

        private void setNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bot.Options.CustomName = "ARTIX";
        }

        private void hidePlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bot.Options.HidePlayers = !ScriptInterface.Instance.Options.HidePlayers;
        }

        private void addDebugHandlersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bot.Events.CellChanged += (_, m, c, p) => Debug.WriteLine($"CellChanged: {m}: {c}, {p}");
            Bot.Events.MapChanged += (_, m) => Debug.WriteLine($"MapChanged: {m}");
            Bot.Events.MonsterKilled += _ => Debug.WriteLine("MonsterKilled");
            Bot.Events.PlayerAFK += _ => Debug.WriteLine("PlayerAFK");
            Bot.Events.PlayerDeath += _ => Debug.WriteLine("PlayerDeath");
            Bot.Events.QuestAccepted += (_, q) => Debug.WriteLine($"QuestAccepted: {q}");
            Bot.Events.QuestTurnedIn += (_, q) => Debug.WriteLine($"QuestTurnedIn: {q}");
            Bot.Events.ReloginTriggered += (_, k) => Debug.WriteLine($"ReloginTriggered: {k}");
            Bot.Events.TryBuyItem += (_, id, sid, siid) => Debug.WriteLine($"TryBuyItem: {id}, {sid}, {siid}");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.About.Show();
        }

        private void scriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Scripts.Show();
        }

        /*
         * Options
        */
        private void botOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Options.Show();
        }

        private void scriptOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ScriptManager.LoadedScript == null)
            {
                if (MessageBox.Show("No script is currently loaded. Please load a script to edit its options.", "No Script Loaded", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Forms.Scripts.Show();
                }
            }
            else
            {
                try
                {
                    object compiled = ScriptManager.Compile(File.ReadAllText(ScriptManager.LoadedScript));
                    ScriptManager.LoadScriptConfig(compiled);
                    if (Bot.Config.Options.Count > 0)
                    {
                        using GenericOptionsForm gof = new GenericOptionsForm() { Container = Bot.Config };
                        gof.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("The loaded script has no options to configure.", "No Options", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Script cannot be configured as it has compilation errors:\r\n" + ex);
                }
            }
        }

        private void applicationOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using GenericOptionsForm gof = new GenericOptionsForm() { Container = AppRuntime.Options };
            gof.ShowDialog();
        }
        // End Options

        /*
         * tools
        */
        private void pluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Plugins.Show();
        }

        private void relogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AutoRelogin.Show();
        }

        private void skillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Skills.Show();
        }

        private void cosmeticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Cosmetics.Show();
        }

        private void strategiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.StratBuilder.Show();
        }

        private void as3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Injector.Show();
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Stats.Show();
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Updates.Show();
        }
        // End Tools

        /*
         * Packets
        */
        private void spammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.PacketSpammer.Show();
        }

        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.PacketLogger.Show();
        }

        private void interceptorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.PacketInterceptor.Show();
        }
        // End Packets

        private void jumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Jump.Show();
        }

        private void loadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Loaders.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bot.Player.OpenBank();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Log.Show();
        }

        private void scripteditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ScriptEditor.Show();
        }

        private void botbuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BotBuilder.Show();
        }
    }
}
