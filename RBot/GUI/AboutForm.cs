using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    public partial class AboutForm : HideForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblRBotVersion.Text = $"RBot Version {Application.ProductVersion}";
            lblBuildDate.Text = $"Build Date: {Properties.Resources.BuildDate}";
        }

        private void lblLinkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lblLinkWebsite.Text);
        }

        private void lblLinkProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lblLinkProject.Text);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel3.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }
    }
}
