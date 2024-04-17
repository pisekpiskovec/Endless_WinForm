using Mpv.NET.Player;
using System.ComponentModel;
using Mpv.NET.Player;
using TagLib;

namespace Endless__WinForm_
{
    public partial class Main : Form
    {
        BindingList<string> playlist = new BindingList<string>();
        BindingList<string> queue = new BindingList<string>();
        Panel panelMPV = new Panel();
        MpvPlayer player;
        bool isMediaLoaded = false, isMediaPlaying = false;
        string mediaPath;
        int saveLocalVolume = 0, queueIndex = 0;
        TagLib.File musFile;

        public Main()
        {
            InitializeComponent();
            lbList.DataSource = playlist;
            lbQueue.DataSource = queue;
            player = new MpvPlayer(panelMPV.Handle);
            player.Volume = 100;
        }

        private void fileLoad(string FileName)
        {
            if (Path.GetExtension(FileName) == ".m3u")
            {
                string[] inputing = System.IO.File.ReadAllLines(FileName);
                foreach (string item in inputing) { fileLoad(item); }
            }
            else { playlist.Add(FileName); }
        }

        private void tsmiAddSong_Click(object sender, EventArgs e)
        {
            player.Pause();
            try { if (ofdAddSong.ShowDialog() == DialogResult.OK) { for (int i = 0; i < ofdAddSong.FileNames.Count(); i++) { fileLoad(ofdAddSong.FileNames[i]); } } }
            catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lbList_DoubleClick(object sender, EventArgs e) { if (playlist.Count > 0) loadMedia(lbList.Text); }
        public void loadMedia(string path)
        {
            player.Load(path);
            mediaPath = path;
            queue.Add(path);
            queueIndex = queue.Count - 1;
            isMediaLoaded = true;
            player.Resume();
            isMediaPlaying = true;
            tDuration.Start();

            musFile = TagLib.File.Create(path);
            if(musFile.Tag.Pictures.Length > 0) { pbAlbum.BackgroundImage = Image.FromStream(new MemoryStream(musFile.Tag.Pictures[0].Data.Data)); }
            else { /* continue in code*/ }
            lTitle.Text = musFile.Tag.Title;
            lArtist.Text = string.Join("; ", musFile.Tag.Performers);
            lNumbers.Text = string.Empty;
            lNumbers.Text = (musFile.Tag.Track.ToString() ?? "0") + "/";
            lNumbers.Text += (musFile.Tag.Disc.ToString() ?? "0") + "/";
            lNumbers.Text += (musFile.Tag.Year.ToString() ?? "0000");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) { player.Dispose(); }
        private void nudVolume_ValueChanged(object sender, EventArgs e) { player.Volume = (int)nudVolume.Value; }
        private void nudVolume_MouseClick(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Middle) { if (player.Volume == 0) { player.Volume = saveLocalVolume; } else { saveLocalVolume = player.Volume; player.Volume = 0; } } }
        private void tDuration_Tick(object sender, EventArgs e)
        {
            tbPosition.Maximum = (int)player.Duration.TotalSeconds;
            string hoursPosition = null;
            string hoursTotal = null;
            if (player.Duration.Hours.ToString("00") != "00") { hoursPosition = player.Position.Hours.ToString("00") + ":"; };
            if (player.Duration.Hours.ToString("00") != "00") { hoursTotal = player.Duration.Hours.ToString("00") + ":"; };
            tslDuration.Text = $"{hoursPosition}{player.Position.Minutes:00}:{player.Position.Seconds:00}/{hoursTotal}{player.Duration.Minutes:00}:{player.Duration.Seconds:00}";
        }

        private void tbPosition_Seek(object sender, EventArgs e) { player.Position = TimeSpan.FromSeconds(tbPosition.Value); }

        private void tControls_Tick(object sender, EventArgs e)
        {
            tbPosition.Enabled = isMediaLoaded;
            tbPosition.Value = (int)player.Position.TotalSeconds;
            nudVolume.Value = player.Volume;
            tsbPrevious.Enabled = isMediaLoaded;
            tsbSeekBack.Enabled = player.Position.TotalSeconds >= 10;
            tsbPlay.Enabled = !isMediaPlaying && isMediaLoaded;
            tsbPause.Enabled = isMediaPlaying && isMediaLoaded;
            tsbStop.Enabled = isMediaLoaded;
            tsbSeekForward.Enabled = player.Duration.TotalSeconds - player.Position.TotalSeconds >= 10;
            tsbNext.Enabled = isMediaLoaded;
            this.Text = isMediaLoaded ? "Endless | " + player.MediaTitle : "Endless";
        }

        private void tsbPrevious_Click(object sender, EventArgs e)
        {
            if (player.Position.TotalSeconds > 10) { player.Position = TimeSpan.FromSeconds(0); }
            else if (queueIndex != 0)
            {
                player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; queueIndex--;
                player.Load(queue[queueIndex]);
                mediaPath = queue[queueIndex];
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
        }

        private void tsbSeekBack_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds - 10); }
        private void tsbPlay_Click(object sender, EventArgs e) { player.Resume(); isMediaPlaying = true; }
        private void tsbPause_Click(object sender, EventArgs e) { player.Pause(); isMediaPlaying = false; }
        private void tsbStop_Click(object sender, EventArgs e) { player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; }
        private void tsbSeekForward_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds + 10); }
        private void tsbNext_Click(object sender, EventArgs e)
        {
            if (queueIndex != queue.Count - 1)
            {
                player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; queueIndex++;
                player.Load(queue[queueIndex]);
                mediaPath = queue[queueIndex];
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
        }
    }
}
