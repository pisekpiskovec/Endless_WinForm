using System.Buffers.Text;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;
using Endless_WinForm.Properties;
using Microsoft.Toolkit.Uwp.Notifications;
using Mpv.NET.Player;

namespace Endless_WinForm
{
    public partial class Main : Form
    {
        BindingList<musItem> playlist = new();
        BindingList<musItem> queue = new BindingList<musItem>();
        Panel panelMPV = new Panel();
        MpvPlayer player;
        bool isMediaLoaded = false, isMediaPlaying = false;
        string mediaPath = String.Empty;
        int saveLocalVolume = 0, playlistIndex = 0, playlistUnique = 0, queueIndex = 0, queueLoop = 2, queueRand = 1;
        enum QueueLooping { NoLoop, LoopOne, LoopPlaylist };
        enum QueueRandom { NoRandom, NormalRandom, UniqueRandom };

        public Main()
        {
            InitializeComponent();
            lbList.DataSource = playlist;
            lbList.DisplayMember = "Display";
            lbQueue.DataSource = queue;
            lbQueue.DisplayMember = "Display";
            player = new MpvPlayer(panelMPV.Handle);
            player.MediaFinished += mediaFinished;
            player.Volume = Settings.Default.sessionLoadLast ? Settings.Default.volumeLast : 100;
            tbVolume.Value = player.Volume;
            tsmiRestoreSession.Checked = Settings.Default.sessionLoadLast;
            if (Settings.Default.sessionLoadLast) {
                tsmiOpenLastSession.PerformClick();
                queueLoop = Settings.Default.queueLoop; queueRand = Settings.Default.queueRand;
                PlayinModesSwitch(queueLoop, queueRand);
                loadMedia(queue[queueIndex], false, false);
            }
        }

        private static void fileLoad(string FileName, BindingList<musItem> list)
        {
            if (Path.GetExtension(FileName) == ".m3u")
            {
                string[] inputing = System.IO.File.ReadAllLines(FileName);
                foreach (string item in inputing) { fileLoad(item, list); }
            }
            else if (Path.GetExtension(FileName) == ".mp3")
            {
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

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)

                { for (int i = 0; i < openFileDialog.FileNames.Count(); i++) { fileLoad(openFileDialog.FileNames[i], playlist); } }
            }
            catch { Console.WriteLine("Opening dialog failed."); }
        }

        private void lbList_DoubleClick(object sender, EventArgs e) { if (playlist.Count > 0) { playlistIndex = lbList.SelectedIndex; loadMedia(playlist[lbList.SelectedIndex]); playlistIndex = lbList.SelectedIndex; } }
        private void tsmiQueuePlay_Click(object sender, EventArgs e) { if (queue.Count > 0) { queueIndex = lbQueue.SelectedIndex; queueIndex = lbQueue.SelectedIndex; playlistIndex = playlist.FindIndexByKey(queue[queueIndex].Key); tsbStop_Click(sender ?? this, e); loadMedia(queue[lbQueue.SelectedIndex], false); } }
        public void loadMedia(musItem item, bool addToQueue = true, bool PlayFlag = true)
        {
            player.Load(item.Path);
            mediaPath = item.Path;
            isMediaLoaded = true;

            if (addToQueue) { queue.Add(item); queueIndex = queue.Count - 1; }

            try { lbQueue.SelectedIndex = queueIndex; } catch { Console.WriteLine("Couldnt select item in list."); }
            try { lbList.SelectedIndex = playlistIndex; } catch { Console.WriteLine("Couldnt select item in list."); }
            pbAlbum.BackgroundImage = item.Image;
            lTitle.Text = item.Title;
            lArtist.Text = item.Artist;
            lAlbum.Text = item.Album;
            lNumbers.Text = string.Empty;
            lNumbers.Text = (item.Track.ToString() ?? "0") + "/";
            lNumbers.Text += (item.Disc.ToString() ?? "0") + "/";
            lNumbers.Text += (item.Year.ToString() ?? "0000");
            Text = isMediaLoaded ? "Endless | " + queue[queueIndex].Display : "Endless";
            //Debug
            lNumbers.Text += "//" + playlistIndex + "/" + queueIndex + "/" + tbPosition.Maximum;

            if (PlayFlag) {
                player.Resume();
                isMediaPlaying = true; 

                ToastNotificationManagerCompat.History.Clear();
                new ToastContentBuilder()
                    .AddText("Now playing:")
                    .AddText($"{string.Join(", ", item.Artists)}\n{item.Title}\n{item.Album}")
                    .AddHeroImage(Imaging.ImageToUri(item.Image))
                    .Show();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            tControls.Stop(); player.Dispose();
            if (Settings.Default.sessionLoadLast)
            {
                tsmiSaveSession.PerformClick();
                Settings.Default.queueLoop = queueLoop;
                Settings.Default.queueRand = queueRand;
            }

            Settings.Default.Save();
            ToastNotificationManagerCompat.Uninstall();
        }

        private void tbVolume_ValueChanged(object sender, EventArgs e) { player.Volume = tbVolume.Value; }
        private void nudVolume_MouseClick(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Right) { if (player.Volume == 0) { player.Volume = saveLocalVolume; } else { saveLocalVolume = player.Volume; player.Volume = 0; } } }
        private void tDuration_Tick(object sender, EventArgs e)
        {
            tbPosition.Maximum = isMediaLoaded ? (int)player.Duration.TotalSeconds : 10;
            string hoursPosition = string.Empty;
            string hoursTotal = string.Empty;
            if (player.Duration.Hours.ToString("00") != "00") { hoursPosition = player.Position.Hours.ToString("00") + ":"; };
            if (player.Duration.Hours.ToString("00") != "00") { hoursTotal = player.Duration.Hours.ToString("00") + ":"; };
            tslDuration.Text = $"{hoursPosition}{player.Position.Minutes:00}:{player.Position.Seconds:00}/{hoursTotal}{player.Duration.Minutes:00}:{player.Duration.Seconds:00}";
            tbPosition.Value = (int)player.Position.TotalSeconds;
        }

        private void tbPosition_Seek(object sender, EventArgs e) { player.Position = TimeSpan.FromSeconds(tbPosition.Value); }
        private void tControls_Tick(object sender, EventArgs e)
        {
            tbPosition.Enabled = isMediaLoaded;
            tDuration_Tick(sender, e);
            tbVolume.Value = player.Volume;
            tsbPrevious.Enabled = isMediaLoaded;
            tsbSeekBack.Enabled = player.Position.TotalSeconds >= 10;
            tsbPlay.Enabled = !isMediaPlaying && isMediaLoaded;
            tsbPause.Enabled = isMediaPlaying && isMediaLoaded;
            tsbStop.Enabled = isMediaLoaded;
            tsbSeekForward.Enabled = player.Duration.TotalSeconds - player.Position.TotalSeconds >= 10;
            tsbNext.Enabled = isMediaLoaded;
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

        private void tsmiCleanQueue_Click(object sender, EventArgs e) { tsbStop_Click(sender, e); queue.Clear(); }
        private void tsmiCleanPlaylist_Click(object sender, EventArgs e) { playlist.Clear(); }
        private void tsmiSavePlaylist_Click(object sender, EventArgs e) { listSave(playlist); }
        private void tsmiSaveQueue_Click(object sender, EventArgs e) { listSave(queue); }
        private static void listSave(BindingList<musItem> list)
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
            catch { Console.WriteLine("Opening dialog failed."); }
        }

        private void tsmiSaveSession_Click(object sender, EventArgs e)
        {
            string[] sessionDirParts = { Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Písek_Pískovec", "Endless_Data" };
            string sessionDir = Path.Combine(sessionDirParts);

            string[] playlistFileParts = { sessionDir, "playlist.m3u" };
            string[] queueFileParts = { sessionDir, "queue.m3u" };
            string[] indexFileParts = { sessionDir, "index.txt" };
            string playlistFile = Path.Combine(playlistFileParts), queueFile = Path.Combine(queueFileParts), indexFile = Path.Combine(indexFileParts);

            if (!Directory.Exists(sessionDir)) Directory.CreateDirectory(sessionDir);

            StreamWriter writer;

            writer = new StreamWriter(playlistFile, false, System.Text.Encoding.UTF8);
            for (int i = 0; i < playlist.Count; i++) { writer.WriteLine(playlist[i].Path); }
            writer.Close();
            File.SetAttributes(playlistFile, FileAttributes.Normal);

            writer = new StreamWriter(queueFile, false, System.Text.Encoding.UTF8);
            for (int i = 0; i < queue.Count; i++) { writer.WriteLine(queue[i].Path); }
            writer.Close();
            File.SetAttributes(queueFile, FileAttributes.Normal);

            Settings.Default.playlistIndex = playlistIndex;
            Settings.Default.queueIndex = queueIndex;
        }

        private void tsmiOpenPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "M3U|*.m3u";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName, System.Text.Encoding.Default);
                string[] inputing = reader.ReadToEnd().Split('\n');
                foreach (string input in inputing) fileLoad(input.Replace("\r", string.Empty), playlist);
                reader.Close();
            }
        }

        private void tsmiOpenQueue_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "M3U|*.m3u";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName, System.Text.Encoding.Default);
                string[] inputing = reader.ReadToEnd().Split('\n');
                foreach (string input in inputing) fileLoad(input.Replace("\r", string.Empty), queue);
                reader.Close();
            }
        }

        private void tsmiOpenLastSession_Click(object sender, EventArgs e)
        {
            string[] sessionDirParts = { Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Písek_Pískovec", "Endless_Data" };
            string sessionDir = Path.Combine(sessionDirParts);

            if (!Directory.Exists(sessionDir))
            {
                Directory.CreateDirectory(sessionDir);
                MessageBox.Show("Saved session's files eiter don't exsists or are corrupted.", "Can't load last session!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] playlistFileParts = { sessionDir, "playlist.m3u" };
            string[] queueFileParts = { sessionDir, "queue.m3u" };
            string[] indexFileParts = { sessionDir, "index.txt" };
            string playlistFile = Path.Combine(playlistFileParts), queueFile = Path.Combine(queueFileParts), indexFile = Path.Combine(indexFileParts);

            if (!File.Exists(playlistFile) || !File.Exists(queueFile) || !File.Exists(indexFile))
            {
                MessageBox.Show("Saved session's files eiter don't exsists or are corrupted.", "Can't load last session!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StreamReader reader;
            string[] inputing;

            reader = new StreamReader(playlistFile, System.Text.Encoding.UTF8);
            inputing = reader.ReadToEnd().Split('\n');
            for (int i = 0; i < inputing.Length - 1; i++)
            {
                string str = inputing[i];
                str = str.Replace("\r", string.Empty);
                fileLoad(str, playlist);
            }
            reader.Close();

            reader = new StreamReader(queueFile, System.Text.Encoding.UTF8);
            inputing = reader.ReadToEnd().Split('\n');
            for (int i = 0; i < inputing.Length - 1; i++)
            {
                string str = inputing[i];
                str = str.Replace("\r", string.Empty);
                fileLoad(str, queue);
            }
            reader.Close();

            playlistIndex = Settings.Default.playlistIndex;
            queueIndex = Settings.Default.queueIndex;
        }

        private void playNext(BindingList<musItem> list, ListBox listBox) { if (list.Count > 0) { queue.Insert(queueIndex + 1, list[listBox.SelectedIndex]); } }
        private void tsmiPlaylistPlayNext_Click(object sender, EventArgs e) { playNext(playlist, lbList); }
        private void tsmiQueuePlayNext_Click(object sender, EventArgs e) { playNext(queue, lbQueue); }
        private void tsmiRemoveFromPlaylist_Click(object sender, EventArgs e) { if (lbList.SelectedIndex < playlistIndex) playlistIndex--; playlist.RemoveAt(lbList.SelectedIndex); }
        private void tsmiRemoveFromQueue_Click(object sender, EventArgs e) { if (lbQueue.SelectedIndex < queueIndex) queueIndex--; queue.RemoveAt(lbQueue.SelectedIndex); }
        private void tsmiMoveUp_Click(object sender, EventArgs e) { queue.Move(lbQueue.SelectedIndex, lbQueue.SelectedIndex - 1); }
        private void tsmiMoveDown_Click(object sender, EventArgs e) { queue.Move(lbQueue.SelectedIndex, lbQueue.SelectedIndex + 1); }
        private void tslDuration_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    cmsSettings.Show(PointToScreen(new Point(tslDuration.Bounds.Location.X, tslDuration.Bounds.Location.Y + tslDuration.Bounds.Size.Height)));
                    break;
            }
        }

        private void tsmiRestoreSession_CheckedChanged(object sender, EventArgs e) { Settings.Default.sessionLoadLast = tsmiRestoreSession.Checked; }
        private void PlayinModesSwitch(int qLoop, int qRand)
        {
            switch (qLoop)
            {
                case (int)QueueLooping.NoLoop:
                    tsmiNoLoop.Checked = true;
                    tsmiLoopOne.Checked = false;
                    tsmiLoopPlaylist.Checked = false;
                    break;
                case (int)QueueLooping.LoopOne:
                    tsmiNoLoop.Checked = false;
                    tsmiLoopOne.Checked = true;
                    tsmiLoopPlaylist.Checked = false;
                    break;
                case (int)QueueLooping.LoopPlaylist:
                    tsmiNoLoop.Checked = false;
                    tsmiLoopOne.Checked = false;
                    tsmiLoopPlaylist.Checked = true;
                    break;
            }
            switch (qRand)
            {
                case (int)QueueRandom.NoRandom:
                    tsmiNoRandom.Checked = true;
                    tsmiUniqueRandom.Checked = false;
                    tsmiNormalRandom.Checked = false;
                    break;
                case (int)QueueRandom.NormalRandom:
                    tsmiNoRandom.Checked = false;
                    tsmiNormalRandom.Checked = true;
                    tsmiUniqueRandom.Checked = false;
                    break;
                case (int)QueueRandom.UniqueRandom:
                    tsmiNoRandom.Checked = true;
                    tsmiNormalRandom.Checked = false;
                    tsmiUniqueRandom.Checked = true;
                    break;
            }
        }

        private void tsmiNoLoop_Click(object sender, EventArgs e) { queueLoop = (int)QueueLooping.NoLoop; PlayinModesSwitch(queueLoop, queueRand); }
        private void tsmiLoopOne_Click(object sender, EventArgs e) { queueLoop = (int)QueueLooping.LoopOne; PlayinModesSwitch(queueLoop, queueRand); }
        private void tsmiLoopPlaylist_Click(object sender, EventArgs e) { queueLoop = (int)QueueLooping.LoopPlaylist; PlayinModesSwitch(queueLoop, queueRand); }
        private void tsmiNoRandom_Click(object sender, EventArgs e) { queueRand = (int)QueueRandom.NoRandom; PlayinModesSwitch(queueLoop, queueRand); }
        private void tsmiNormmalRandom_Click(object sender, EventArgs e) { queueRand = (int)QueueRandom.NormalRandom; PlayinModesSwitch(queueLoop, queueRand); }
        private void tsmiUniqueRandom_Click(object sender, EventArgs e) { queueRand = (int)QueueRandom.UniqueRandom; PlayinModesSwitch(queueLoop, queueRand); }
        private void mediaFinished(object? sender, EventArgs e)
        {
            tsbStop_Click(sender ?? this, e); playlist[playlistIndex].Played = true; queue[queueIndex].Played = true; playlistUnique++;
            switch (queueLoop)
            {
                case (int)QueueLooping.NoLoop:
                    if (queue.Count < Settings.Default.queueCapacity)
                    {
                        if (queueIndex == queue.Count - 1)
                        {
                            if (playlistIndex == playlist.Count - 1)
                            {
                                tsbStop_Click(sender ?? this, e);
                                foreach (musItem item in playlist) item.Played = false;
                                foreach (musItem item in queue) item.Played = false;
                                return;
                            }
                            else
                            {
                                switch (queueRand)
                                { 
                                    case (int)QueueRandom.NoRandom: playlistIndex++; break;
                                    case (int)QueueRandom.NormalRandom: playlistIndex = RandomNumber(); break;
                                    case (int)QueueRandom.UniqueRandom: playlistIndex = RandomNumber(true); break;
                                }
                                queue.Add(playlist[playlistIndex]);
                            }
                        }
                        queueIndex++;
                        loadMedia(queue[queueIndex], false);
                    }
                    else
                    {
                        for(int i = 0; i <= queue.Count - Settings.Default.queueCapacity; i++) queue.RemoveAt(0);
                        queue.Add(playlist[playlistIndex]);
                        loadMedia(queue[queueIndex], false);
                        switch (queueRand)
                        {
                            case (int)QueueRandom.NoRandom: playlistIndex += (playlistIndex == playlist.Count - 1) ? 0 : 1; break;
                            case (int)QueueRandom.NormalRandom: playlistIndex = (playlistIndex == playlist.Count - 1) ? 0 : RandomNumber(); break;
                            case (int)QueueRandom.UniqueRandom: playlistIndex = (playlistIndex == playlist.Count - 1) ? 0 : RandomNumber(true); break;
                        }
                    }
                    break;
                case (int)QueueLooping.LoopOne:
                    loadMedia(queue[queueIndex], false);
                    break;
                case (int)QueueLooping.LoopPlaylist:
                    if (queue.Count < Settings.Default.queueCapacity)
                    {
                        if (queueIndex == queue.Count - 1)
                        {
                            if (playlistIndex == playlist.Count - 1)
                            {
                                playlistIndex = 0;
                                foreach (musItem item in playlist) item.Played = false;
                                foreach (musItem item in queue) item.Played = false;
                            }
                            else
                            {
                                switch (queueRand)
                                {
                                    case (int)QueueRandom.NoRandom: playlistIndex++; break;
                                    case (int)QueueRandom.NormalRandom: playlistIndex = RandomNumber(); break;
                                    case (int)QueueRandom.UniqueRandom: playlistIndex = RandomNumber(true); break;
                                }
                                queue.Add(playlist[playlistIndex]);
                            }
                        }
                        queueIndex++;
                        loadMedia(queue[queueIndex], false);
                    }
                    else
                    {
                        for (int i = 0; i <= queue.Count - Settings.Default.queueCapacity; i++) queue.RemoveAt(0);
                        queue.Add(playlist[playlistIndex]);
                        loadMedia(queue[queueIndex], false);
                        switch (queueRand)
                        {
                            case (int)QueueRandom.NoRandom:
                                if (playlistIndex == playlist.Count - 1)
                                {
                                    playlistIndex = 0;
                                    foreach (musItem item in playlist) item.Played = false;
                                    foreach (musItem item in queue) item.Played = false;
                                }
                                else playlistIndex++;
                                break;
                            case (int)QueueRandom.NormalRandom: playlistIndex = (playlistIndex == playlist.Count - 1) ? 0 : RandomNumber(); break;
                            case (int)QueueRandom.UniqueRandom: playlistIndex = (playlistIndex == playlist.Count - 1) ? 0 : RandomNumber(true); break;
                        }
                    }
                    break;
            }
        }

        private int RandomNumber(bool Unique = false)
        {
            int GeneratedNum = new Random().Next(0, playlist.Count);
            if(Unique && playlist[GeneratedNum].Played) GeneratedNum = RandomNumber(Unique);
            return GeneratedNum;
        }
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

        public static int FindIndexByKey(this BindingList<musItem> list, string QuerryKey) { for (int i = 0; i < list.Count; i++) if (list[i].Key == QuerryKey) return i; return 0; }
    }

    public static class Imaging
    {
        public static Uri ImageToUri(Image image)
        {
            string[] TempDirParts = { System.IO.Path.GetTempPath(), "endless.png" };
            string TempDir = Path.Combine(TempDirParts[0], TempDirParts[1]);
            image.Save(TempDir, ImageFormat.Png);
            return new Uri(TempDir);
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
        public bool Played { get; set; } = false;
        private string Unknown = "Unknown";
        public string Display { get { return $"{Artists[0] ?? Unknown} - {Title ?? Unknown} - {Album ?? Unknown} - {Track}/{Disc}"; } }
        public string Key { get { return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Path)); } }
    }
}
