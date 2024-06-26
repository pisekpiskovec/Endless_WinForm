using System.ComponentModel;
using System.IO;
using Endless_WinForm.Properties;
using Mpv.NET.Player;

namespace Endless__WinForm_
{
    public partial class Main : Form
    {
        BindingList<musItem> playlist = new BindingList<musItem>();
        BindingList<musItem> queue = new BindingList<musItem>();
        Panel panelMPV = new Panel();
        MpvPlayer player;
        bool isMediaLoaded = false, isMediaPlaying = false;
        string mediaPath;
        int saveLocalVolume = 0, queueIndex = 0;

        public Main()
        {
            InitializeComponent();
            lbList.DataSource = playlist;
            lbList.DisplayMember = "Display";
            lbQueue.DataSource = queue;
            lbQueue.DisplayMember = "Display";
            player = new MpvPlayer(panelMPV.Handle);
            player.Volume = 100;
        }

        private void fileLoad(string FileName, BindingList<musItem> list)
        {
            if (Path.GetExtension(FileName) == ".m3u")
            {
                string[] inputing = System.IO.File.ReadAllLines(FileName);
                foreach (string item in inputing) { fileLoad(item, list); }
            }
            else if (Path.GetExtension(FileName) == ".mp3") {
                musItem newItem = new musItem();
                TagLib.File musFile = TagLib.File.Create(FileName);
                if (musFile.Tag.Pictures.Length > 0) { newItem.Image = Image.FromStream(new MemoryStream(musFile.Tag.Pictures[0].Data.Data)); }
                newItem.Title = musFile.Tag.Title;
                newItem.Artist = string.Join("; ", musFile.Tag.Performers);
                newItem.Album = musFile.Tag.Album;
                newItem.Artists = musFile.Tag.Performers;
                newItem.Track = musFile.Tag.Track;
                newItem.Disc = musFile.Tag.Disc;
                newItem.Year = musFile.Tag.Year;
                newItem.Path = FileName;
                list.Add(newItem); 
            }
        }

        private void tsmiAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files| *.mp3";
            openFileDialog.Title = "Add Song...";
            openFileDialog.DefaultExt = "mp3";
            openFileDialog.Multiselect = true;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyMusic);

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)

                { for (int i = 0; i < openFileDialog.FileNames.Count(); i++) { fileLoad(openFileDialog.FileNames[i], playlist); } }
            }
            catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lbList_DoubleClick(object sender, EventArgs e) { if (playlist.Count > 0) loadMedia(playlist[lbList.SelectedIndex]); }
        private void tsmiQueuePlay_Click(object sender, EventArgs e) { if (queue.Count > 0) loadMedia(queue[lbQueue.SelectedIndex], false); }
        public void loadMedia(musItem item, bool addToQueue = true)
        {
            player.Load(item.Path);
            mediaPath = item.Path;
            if (addToQueue)
            {
                queue.Add(item);
                queueIndex = queue.Count - 1;
                lbQueue.SelectedIndex = queueIndex;
            }
            isMediaLoaded = true;
            player.Resume();
            isMediaPlaying = true;
            tDuration.Start();

            pbAlbum.BackgroundImage = item.Image;
            lTitle.Text = item.Title;
            lArtist.Text = item.Artist;
            lAlbum.Text = item.Album;
            lNumbers.Text = string.Empty;
            lNumbers.Text = (item.Track.ToString() ?? "0") + "/";
            lNumbers.Text += (item.Disc.ToString() ?? "0") + "/";
            lNumbers.Text += (item.Year.ToString() ?? "0000");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) { player.Dispose(); }
        private void nudVolume_ValueChanged(object sender, EventArgs e) { player.Volume = (int)nudVolume.Value; }
        private void nudVolume_MouseClick(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Middle) { if (player.Volume == 0) { player.Volume = saveLocalVolume; } else { saveLocalVolume = player.Volume; player.Volume = 0; } } }
        private void tDuration_Tick(object sender, EventArgs e)
        {
            tbPosition.Maximum = (int)player.Duration.TotalSeconds;
            string hoursPosition = string.Empty;
            string hoursTotal = string.Empty;
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
            this.Text = isMediaLoaded ? "Endless | " + queue[queueIndex].Display : "Endless";
            tsmiPlaylistCleanPlaylist.Enabled = playlist.Count > 0;
            tsmiPlaylistPlay.Enabled = playlist.Count > 0;
            tsmiPlaylistPlayNext.Enabled = playlist.Count > 0;
            tsmiRemoveFromPlaylist.Enabled = playlist.Count > 0;

            tsmiQueueCleanQueue.Enabled = queue.Count > 0;
            tsmiQueuePlay.Enabled = queue.Count > 0;
            tsmiQueuePlayNext.Enabled = queue.Count > 0;
            tsmiRemoveFromQueue.Enabled = queue.Count > 0;
            tsmiMoveDown.Enabled = queue.Count > 0;
            tsmiMoveUp.Enabled = queue.Count > 0;
        }

        private void tsbPrevious_Click(object sender, EventArgs e)
        {
            if (player.Position.TotalSeconds > 10) { player.Position = TimeSpan.FromSeconds(0); }
            else if (queueIndex != 0)
            {
                player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; queueIndex--;
                player.Load(queue[queueIndex].Path);
                mediaPath = queue[queueIndex].Path;
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
        }

        private void tsbSeekBack_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds - 10); }
        private void tsbPlay_Click(object sender, EventArgs e) { player.Resume(); isMediaPlaying = true; }
        private void tsbPause_Click(object sender, EventArgs e) { player.Pause(); isMediaPlaying = false; }
        private void tsbStop_Click(object sender, EventArgs e) { player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; pbAlbum.BackgroundImage = Resources.generic_music_file_100px; }
        private void tsbSeekForward_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds + 10); }
        private void tsbNext_Click(object sender, EventArgs e)
        {
            if (queueIndex != queue.Count - 1)
            {
                player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; queueIndex++;
                player.Load(queue[queueIndex].Path);
                mediaPath = queue[queueIndex].Path;
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
        }

        private void tsmiAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filesInFolder = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                foreach (string file in filesInFolder) fileLoad(file, playlist);
            }
        }

        private void tsmiCleanQueue_Click(object sender, EventArgs e) { queue.Clear(); }
        private void tsmiCleanPlaylist_Click(object sender, EventArgs e) { playlist.Clear(); }
        private void tsmiSavePlaylist_Click(object sender, EventArgs e) { listSave(playlist); }
        private void tsmiSaveQueue_Click(object sender, EventArgs e) { listSave(queue); }
        private void listSave(BindingList<musItem> list)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "M3U|*.m3u";
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != string.Empty)
                {
                    System.IO.File.WriteAllLines(saveFileDialog.FileName, list.MusicListToArray());
                }
            }
            catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void saveSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] sessionDirParts = { Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "Endless" };
            string sessionDir = Path.Combine(sessionDirParts);

            string[] playlistFile = { sessionDir, "playlist.m3u" };
            string[] queueFile = { sessionDir, "queue.m3u" };

            if (!Directory.Exists(sessionDir)) Directory.CreateDirectory(sessionDir);

            System.IO.File.WriteAllLines(Path.Combine(playlistFile), playlist.MusicListToArray());
            System.IO.File.WriteAllLines(Path.Combine(queueFile), queue.MusicListToArray());
        }

        private void tsmiOpenPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "M3U|*.m3u";
            StreamReader reader = new StreamReader(openFileDialog.FileName, System.Text.Encoding.Default);
            string[] inputing = reader.ReadToEnd().Split('\n');
            foreach (string input in inputing) fileLoad(input, playlist);
        }

        private void tsmiOpenQueue_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "M3U|*.m3u";
            StreamReader reader = new StreamReader(openFileDialog.FileName, System.Text.Encoding.Default);
            string[] inputing = reader.ReadToEnd().Split('\n');
            foreach (string input in inputing) fileLoad(input, queue);
        }

        private void tsmiOpenLastSession_Click(object sender, EventArgs e)
        {
            string[] sessionDirParts = { Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "Endless" };
            string sessionDir = Path.Combine(sessionDirParts);

            string[] playlistFile = { sessionDir, "playlist.m3u" };
            string[] queueFile = { sessionDir, "queue.m3u" };

            if (!Directory.Exists(sessionDir))
            {
                Directory.CreateDirectory(sessionDir);
                MessageBox.Show("Saved session's files eiter don't exsists or are corrupted.", "Can't load last session!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StreamReader reader;
            string[] inputing;

            reader = new StreamReader(Path.Combine(playlistFile), System.Text.Encoding.Default);
            inputing = reader.ReadToEnd().Split('\n');
            for (int i = 0; i < inputing.Length - 1; i++)
            {
                string str = inputing[i];
                str = str.Replace("\r", string.Empty);
                fileLoad(str, playlist);
            }

            reader = new StreamReader(Path.Combine(queueFile), System.Text.Encoding.Default);
            inputing = reader.ReadToEnd().Split('\n');
            for (int i = 0; i < inputing.Length - 1; i++)
            {
                string str = inputing[i];
                str = str.Replace("\r", string.Empty);
                fileLoad(str, queue);
            }
        }

        private void playNext(BindingList<musItem> list, ListBox listBox)
        {
            if (list.Count > 0)
            {
                queue.Insert(queueIndex + 1, list[listBox.SelectedIndex]);
            }
        }

        private void tsmiPlaylistPlayNext_Click(object sender, EventArgs e) { playNext(playlist, lbList); }
        private void tsmiQueuePlayNext_Click(object sender, EventArgs e) { playNext(queue, lbQueue); }
        private void tsmiRemoveFromPlaylist_Click(object sender, EventArgs e) { playlist.RemoveAt(lbList.SelectedIndex); }
        private void tsmiRemoveFromQueue_Click(object sender, EventArgs e) { queue.RemoveAt(lbQueue.SelectedIndex); }
        private void tsmiMoveUp_Click(object sender, EventArgs e) { queue.Move(lbQueue.SelectedIndex, lbQueue.SelectedIndex-1); }
        private void tsmiMoveDown_Click(object sender, EventArgs e) { queue.Move(lbQueue.SelectedIndex, lbQueue.SelectedIndex + 1); }
    }

    public static class Listing
    {
        public static void Move<T>(this BindingList<T> list, int oldIndex, int newIndex)
        {
            T item = list[oldIndex];
            if (newIndex > -1 && newIndex < list.Count())
            {
                list.RemoveAt(oldIndex);
                list.Insert(newIndex, item);
            }
        }

        public static string[] MusicListToArray(this BindingList<musItem> list)
        {
            string[] result = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                result[i] = list[i].Path;
            }
            return result;
        }
    }

    public class musItem
    {
        public string Path { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string[] Artists { get; set; } = new string[0];
        public string Title { get; set; } = string.Empty;
        public string Album {  get; set; } = string.Empty;
        public uint Track { get; set; } = 0;
        public uint Disc { get; set; } = 0;
        public uint Year { get; set; } = 0;
        public Image Image { get; set; } = Resources.generic_music_file_100px;
        private string Unknown = "Unknown";
        public string Display { get { return $"{Artists[0] ?? Unknown} - {Title ?? Unknown} - {Album ?? Unknown}"; } }
    }
}
