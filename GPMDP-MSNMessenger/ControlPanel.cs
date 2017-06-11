using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace GPMDP_MSNMessenger
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var obj = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Google Play Music Desktop Player\\json_store\\playback.json"));
                var songObj = obj["song"];
                var songTitle = (string)songObj["title"];
                var songArtist = (string)songObj["artist"];
                var songAlbum = (string)songObj["album"];
                var songPlaying = (bool)obj["playing"];
                if (statusesEnabledCheck.Checked)
                {
                    if (ShowPausedCheck.Checked)
                    {
                        if (songPlaying)
                        {
                            MSNStatus.SetMusic(songArtist, songTitle, songAlbum);
                            currentlyPlayingText.Text = songArtist + " - " + songTitle;
                        }
                        else
                        {
                            MSNStatus.Clear();
                            currentlyPlayingText.Text = "Nothing";
                        }
                    }
                    else
                    {
                        MSNStatus.SetMusic(songArtist, songTitle, songAlbum);
                        currentlyPlayingText.Text = songArtist + " - " + songTitle;
                    }
                }
                else
                {
                    MSNStatus.Clear();
                    currentlyPlayingText.Text = "Nothing";
                }
            } catch
            {

            }
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Enabled)
            {
                enabledToolStripMenuItem.Checked = true;
                statusesEnabledCheck.Checked = true;
            }
            if (Properties.Settings.Default.PausedStop)
            {
                ShowPausedCheck.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MSNStatus.Clear();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void openWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            enabledToolStripMenuItem.Checked = statusesEnabledCheck.Checked;
            Properties.Settings.Default.Enabled = statusesEnabledCheck.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PausedStop = ShowPausedCheck.Checked;
            Properties.Settings.Default.Save();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            if (e.CloseReason == CloseReason.TaskManagerClosing)
            {
                MSNStatus.Clear();
            }
        }

        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusesEnabledCheck.Checked = enabledToolStripMenuItem.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSNStatus.Clear();
            Application.Exit();
        }

        private void notificationIcon_DoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
