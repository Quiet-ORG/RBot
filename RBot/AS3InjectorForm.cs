﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using RBot.Flash;

namespace RBot
{
    public partial class AS3InjectorForm : HideForm
    {
        public const string DefaultText = "package {\r\n\r\n\timport flash.display.*;\r\n\timport flash.external.*;\r\n\r\n\tpublic class Patch extends MovieClip {\r\n\r\n        private var game:*;\r\n\r\n\t\tpublic function run(root:*) {\r\n            game = root.getGame();\r\n            \r\n            \r\n\t\t}\r\n\t}\r\n}";

        public string CurrentFile { get; set; }
        private bool _modified;
        public bool Modified
        {
            get => _modified;
            set
            {
                Text = "AS3 Injector - " + (CurrentFile ?? "Unsaved.as") + (value ? "*" : "");
                _modified = value;
            }
        }

        public AS3InjectorForm()
        {
            InitializeComponent();

            KeyPreview = true;
            txtCode.DescriptionFile = "AS3Style.xml";
            txtCode.Text = DefaultText;
            txtCode.TextChanged += TxtCode_TextChanged;
        }

        private void TxtCode_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            Modified = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Modified || MessageBox.Show("The current script has unsaved changes which will be lost if a new script is started. Are you sure you would like to start a new script?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtCode.Text = DefaultText;
                CurrentFile = null;
                Modified = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Modified || MessageBox.Show("The current script has unsaved changes which will be lost if another script is opened. Are you sure you would like to open a new script?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "ActionScript Files (*.as)|*.as";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CurrentFile = ofd.FileName;
                    txtCode.Text = File.ReadAllText(CurrentFile);
                    Modified = false;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFile == null)
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else
            {
                File.WriteAllText(CurrentFile, txtCode.Text);
                Modified = false;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "ActionScript Files (*.as)|*.as";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                CurrentFile = sfd.FileName;
                Modified = false;
                File.WriteAllText(CurrentFile, txtCode.Text);
            }
        }

        private async void injectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            injectToolStripMenuItem.Enabled = false;
            injectToolStripMenuItem.Text = "Compiling...";

            await Task.Run(() =>
            {
                File.WriteAllText("tmp/Patch.as", txtCode.Text);

                Process p = Process.Start(new ProcessStartInfo("tools/as3compile.exe")
                {
                    Arguments = "tmp/Patch.as -o tmp/Patch.swf",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true
                });

                StringBuilder sb = new StringBuilder();
                using (StreamReader err = p.StandardError)
                {
                    while (!err.EndOfStream)
                        sb.AppendLine(err.ReadLine());
                }

                p.WaitForExit();
                if (p.ExitCode == 0)
                {
                    injectToolStripMenuItem.Text = "Injecting...";
                    FlashUtil.Call("injectScript", new Uri(Path.Combine(Environment.CurrentDirectory, "tmp", "Patch.swf")).AbsoluteUri);
                }
                else
                {
                    MessageBox.Show($"Compiler exited with code {p.ExitCode}:\r\n{sb}", "Compile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            injectToolStripMenuItem.Text = "Inject (Ctrl+F5)";
            injectToolStripMenuItem.Enabled = true;
        }
    }
}
