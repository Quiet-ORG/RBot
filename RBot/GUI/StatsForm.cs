using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RBot
{
    public partial class StatsForm : HideForm
    {
        public StatsForm()
        {
            InitializeComponent();

            GotFocus += StatsForm_GotFocus;
        }

        private void StatsForm_GotFocus(object sender, EventArgs e)
        {
            statsTimer.Start();
        }

        public override void Show()
        {
            base.Show();
            statsTimer.Start();
        }

        public new void Hide()
        {
            base.Hide();
            statsTimer.Stop();
        }

        private void statsTimer_Tick(object sender, EventArgs e)
        {
            lblKills.Text = $"Kills: {Bot.Stats.Kills}";
            lblDeaths.Text = $"Deaths: {Bot.Stats.Deaths}";
            lblQuests.Text = $"Quests (A/C): {Bot.Stats.QuestsAccepted}/{Bot.Stats.QuestsCompleted}";
            lblPickups.Text = $"Pickups: {Bot.Stats.Drops}";
            lblRelogins.Text = $"Relogins: {Bot.Stats.Relogins}";
            lblTime.Text = $"Time: {DateTime.UtcNow - Process.GetCurrentProcess().StartTime.ToUniversalTime()}";
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bot.Stats = new ScriptBotStats();
        }
    }
}
