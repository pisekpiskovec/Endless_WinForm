using Endless_WinForm.Properties;

namespace Endless_WinForm
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tsTop = new ToolStrip();
            tssbAddSong = new ToolStripSplitButton();
            tsmiAddFolder = new ToolStripMenuItem();
            tsmiAddSong = new ToolStripMenuItem();
            tssAdd1 = new ToolStripSeparator();
            tsmiOpenPlaylist = new ToolStripMenuItem();
            tsmiOpenQueue = new ToolStripMenuItem();
            tsmiOpenLastSession = new ToolStripMenuItem();
            tssAdd2 = new ToolStripSeparator();
            tsmiCleanPlaylist = new ToolStripMenuItem();
            tsmiCleanQueue = new ToolStripMenuItem();
            tssbSavePlaylist = new ToolStripSplitButton();
            tsmiSavePlaylist = new ToolStripMenuItem();
            tsmiSaveQueue = new ToolStripMenuItem();
            tsmiSaveSession = new ToolStripMenuItem();
            tssBasic1 = new ToolStripSeparator();
            tsbPrevious = new ToolStripButton();
            tsbSeekBack = new ToolStripButton();
            tsbPlay = new ToolStripButton();
            tsbPause = new ToolStripButton();
            tsbStop = new ToolStripButton();
            tsbSeekForward = new ToolStripButton();
            tsbNext = new ToolStripButton();
            tssBasic2 = new ToolStripSeparator();
            tslDuration = new ToolStripLabel();
            tssBasic3 = new ToolStripSeparator();
            tsddbQueueLooping = new ToolStripDropDownButton();
            tsmiNoLoop = new ToolStripMenuItem();
            tsmiLoopOne = new ToolStripMenuItem();
            tsmiLoopPlaylist = new ToolStripMenuItem();
            tsddbQueueRandom = new ToolStripDropDownButton();
            tsmiNoRandom = new ToolStripMenuItem();
            tsmiNormalRandom = new ToolStripMenuItem();
            tsmiUniqueRandom = new ToolStripMenuItem();
            pbAlbum = new PictureBox();
            lTitle = new Label();
            lArtist = new Label();
            lAlbum = new Label();
            lNumbers = new Label();
            tbPosition = new TrackBar();
            splitContainer1 = new SplitContainer();
            lbList = new ListBox();
            cmsPlaylist = new ContextMenuStrip(components);
            tsmiPlaylistPlay = new ToolStripMenuItem();
            tsmiPlaylistPlayNext = new ToolStripMenuItem();
            tssPlaylistMenu = new ToolStripSeparator();
            tsmiRemoveFromPlaylist = new ToolStripMenuItem();
            tsmiPlaylistCleanPlaylist = new ToolStripMenuItem();
            lbQueue = new ListBox();
            cmsQueue = new ContextMenuStrip(components);
            tsmiQueuePlay = new ToolStripMenuItem();
            tsmiQueuePlayNext = new ToolStripMenuItem();
            tssQueue = new ToolStripSeparator();
            tsmiMoveUp = new ToolStripMenuItem();
            tsmiMoveDown = new ToolStripMenuItem();
            tsmiRemoveFromQueue = new ToolStripMenuItem();
            tsmiQueueCleanQueue = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            tControls = new System.Windows.Forms.Timer(components);
            cmsSettings = new ContextMenuStrip(components);
            tsmiRestoreSession = new ToolStripMenuItem();
            tbVolume = new TrackBar();
            tsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            cmsPlaylist.SuspendLayout();
            cmsQueue.SuspendLayout();
            cmsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbVolume).BeginInit();
            SuspendLayout();
            // 
            // tsTop
            // 
            tsTop.Items.AddRange(new ToolStripItem[] { tssbAddSong, tssbSavePlaylist, tssBasic1, tsbPrevious, tsbSeekBack, tsbPlay, tsbPause, tsbStop, tsbSeekForward, tsbNext, tssBasic2, tslDuration, tssBasic3, tsddbQueueLooping, tsddbQueueRandom });
            tsTop.Location = new Point(0, 0);
            tsTop.Name = "tsTop";
            tsTop.Size = new Size(511, 25);
            tsTop.TabIndex = 0;
            tsTop.Text = "Menu Bar";
            // 
            // tssbAddSong
            // 
            tssbAddSong.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbAddSong.DropDownItems.AddRange(new ToolStripItem[] { tsmiAddFolder, tsmiAddSong, tssAdd1, tsmiOpenPlaylist, tsmiOpenQueue, tsmiOpenLastSession, tssAdd2, tsmiCleanPlaylist, tsmiCleanQueue });
            tssbAddSong.Image = Resources.opened_folder_96px;
            tssbAddSong.ImageTransparentColor = Color.Magenta;
            tssbAddSong.Name = "tssbAddSong";
            tssbAddSong.Size = new Size(32, 22);
            tssbAddSong.Text = "Add Song";
            tssbAddSong.ButtonClick += tsmiAddSong_Click;
            // 
            // tsmiAddFolder
            // 
            tsmiAddFolder.Name = "tsmiAddFolder";
            tsmiAddFolder.Size = new Size(182, 22);
            tsmiAddFolder.Text = "Add Folder";
            tsmiAddFolder.Click += tsmiAddFolder_Click;
            // 
            // tsmiAddSong
            // 
            tsmiAddSong.Name = "tsmiAddSong";
            tsmiAddSong.ShortcutKeyDisplayString = "Ctrl+S";
            tsmiAddSong.Size = new Size(182, 22);
            tsmiAddSong.Text = "Add Song";
            tsmiAddSong.Click += tsmiAddSong_Click;
            // 
            // tssAdd1
            // 
            tssAdd1.Name = "tssAdd1";
            tssAdd1.Size = new Size(179, 6);
            // 
            // tsmiOpenPlaylist
            // 
            tsmiOpenPlaylist.Name = "tsmiOpenPlaylist";
            tsmiOpenPlaylist.Size = new Size(182, 22);
            tsmiOpenPlaylist.Text = "Open Playlist";
            tsmiOpenPlaylist.Click += tsmiOpenPlaylist_Click;
            // 
            // tsmiOpenQueue
            // 
            tsmiOpenQueue.Name = "tsmiOpenQueue";
            tsmiOpenQueue.Size = new Size(182, 22);
            tsmiOpenQueue.Text = "Open Queue";
            tsmiOpenQueue.Click += tsmiOpenQueue_Click;
            // 
            // tsmiOpenLastSession
            // 
            tsmiOpenLastSession.Name = "tsmiOpenLastSession";
            tsmiOpenLastSession.Size = new Size(182, 22);
            tsmiOpenLastSession.Text = "Open Last Session";
            tsmiOpenLastSession.Click += tsmiOpenLastSession_Click;
            // 
            // tssAdd2
            // 
            tssAdd2.Name = "tssAdd2";
            tssAdd2.Size = new Size(179, 6);
            // 
            // tsmiCleanPlaylist
            // 
            tsmiCleanPlaylist.Name = "tsmiCleanPlaylist";
            tsmiCleanPlaylist.Size = new Size(182, 22);
            tsmiCleanPlaylist.Text = "Clean Playlist";
            tsmiCleanPlaylist.Click += tsmiCleanPlaylist_Click;
            // 
            // tsmiCleanQueue
            // 
            tsmiCleanQueue.Name = "tsmiCleanQueue";
            tsmiCleanQueue.ShortcutKeyDisplayString = "Ctrl+L";
            tsmiCleanQueue.Size = new Size(182, 22);
            tsmiCleanQueue.Text = "Clean Queue";
            tsmiCleanQueue.Click += tsmiCleanQueue_Click;
            // 
            // tssbSavePlaylist
            // 
            tssbSavePlaylist.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbSavePlaylist.DropDownItems.AddRange(new ToolStripItem[] { tsmiSavePlaylist, tsmiSaveQueue, tsmiSaveSession });
            tssbSavePlaylist.Image = Resources.save_96px;
            tssbSavePlaylist.ImageTransparentColor = Color.Magenta;
            tssbSavePlaylist.Name = "tssbSavePlaylist";
            tssbSavePlaylist.Size = new Size(32, 22);
            tssbSavePlaylist.Text = "Save Playlist";
            tssbSavePlaylist.ButtonClick += tsmiSavePlaylist_Click;
            // 
            // tsmiSavePlaylist
            // 
            tsmiSavePlaylist.Name = "tsmiSavePlaylist";
            tsmiSavePlaylist.Size = new Size(140, 22);
            tsmiSavePlaylist.Text = "Save Playlist";
            tsmiSavePlaylist.Click += tsmiSavePlaylist_Click;
            // 
            // tsmiSaveQueue
            // 
            tsmiSaveQueue.Name = "tsmiSaveQueue";
            tsmiSaveQueue.Size = new Size(140, 22);
            tsmiSaveQueue.Text = "Save Queue";
            tsmiSaveQueue.Click += tsmiSaveQueue_Click;
            // 
            // tsmiSaveSession
            // 
            tsmiSaveSession.Name = "tsmiSaveSession";
            tsmiSaveSession.Size = new Size(140, 22);
            tsmiSaveSession.Text = "Save Session";
            tsmiSaveSession.Click += tsmiSaveSession_Click;
            // 
            // tssBasic1
            // 
            tssBasic1.Name = "tssBasic1";
            tssBasic1.Size = new Size(6, 25);
            // 
            // tsbPrevious
            // 
            tsbPrevious.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbPrevious.Enabled = false;
            tsbPrevious.Image = Resources.skip_to_start_96px;
            tsbPrevious.ImageTransparentColor = Color.Magenta;
            tsbPrevious.Name = "tsbPrevious";
            tsbPrevious.Size = new Size(23, 22);
            tsbPrevious.Text = "Previous";
            tsbPrevious.ToolTipText = "Previous";
            tsbPrevious.Click += tsbPrevious_Click;
            // 
            // tsbSeekBack
            // 
            tsbSeekBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSeekBack.Enabled = false;
            tsbSeekBack.Image = Resources.rewind_96px;
            tsbSeekBack.ImageTransparentColor = Color.Magenta;
            tsbSeekBack.Name = "tsbSeekBack";
            tsbSeekBack.Size = new Size(23, 22);
            tsbSeekBack.Text = "Seek back";
            tsbSeekBack.Click += tsbSeekBack_Click;
            // 
            // tsbPlay
            // 
            tsbPlay.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbPlay.Enabled = false;
            tsbPlay.Image = Resources.play_96px;
            tsbPlay.ImageTransparentColor = Color.Magenta;
            tsbPlay.Name = "tsbPlay";
            tsbPlay.Size = new Size(23, 22);
            tsbPlay.Text = "Play";
            tsbPlay.Click += tsbPlay_Click;
            // 
            // tsbPause
            // 
            tsbPause.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbPause.Enabled = false;
            tsbPause.Image = Resources.pause_96px;
            tsbPause.ImageTransparentColor = Color.Magenta;
            tsbPause.Name = "tsbPause";
            tsbPause.Size = new Size(23, 22);
            tsbPause.Text = "Pause";
            tsbPause.Click += tsbPause_Click;
            // 
            // tsbStop
            // 
            tsbStop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbStop.Enabled = false;
            tsbStop.Image = Resources.stop_96px;
            tsbStop.ImageTransparentColor = Color.Magenta;
            tsbStop.Name = "tsbStop";
            tsbStop.Size = new Size(23, 22);
            tsbStop.Text = "Stop";
            tsbStop.Click += tsbStop_Click;
            // 
            // tsbSeekForward
            // 
            tsbSeekForward.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSeekForward.Enabled = false;
            tsbSeekForward.Image = Resources.fast_forward_96px;
            tsbSeekForward.ImageTransparentColor = Color.Magenta;
            tsbSeekForward.Name = "tsbSeekForward";
            tsbSeekForward.Size = new Size(23, 22);
            tsbSeekForward.Text = "Seek Forward";
            tsbSeekForward.Click += tsbSeekForward_Click;
            // 
            // tsbNext
            // 
            tsbNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNext.Enabled = false;
            tsbNext.Image = Resources.end_96px;
            tsbNext.ImageTransparentColor = Color.Magenta;
            tsbNext.Name = "tsbNext";
            tsbNext.Size = new Size(23, 22);
            tsbNext.Text = "Next";
            tsbNext.Click += tsbNext_Click;
            // 
            // tssBasic2
            // 
            tssBasic2.Name = "tssBasic2";
            tssBasic2.Size = new Size(6, 25);
            // 
            // tslDuration
            // 
            tslDuration.Name = "tslDuration";
            tslDuration.Size = new Size(66, 22);
            tslDuration.Text = "00:00/00:00";
            tslDuration.ToolTipText = "Click to open Settings.";
            tslDuration.MouseUp += tslDuration_MouseUp;
            // 
            // tssBasic3
            // 
            tssBasic3.Name = "tssBasic3";
            tssBasic3.Size = new Size(6, 25);
            // 
            // tsddbQueueLooping
            // 
            tsddbQueueLooping.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsddbQueueLooping.DropDownItems.AddRange(new ToolStripItem[] { tsmiNoLoop, tsmiLoopOne, tsmiLoopPlaylist });
            tsddbQueueLooping.Image = Resources.repeat_100px;
            tsddbQueueLooping.ImageTransparentColor = Color.Magenta;
            tsddbQueueLooping.Name = "tsddbQueueLooping";
            tsddbQueueLooping.Size = new Size(29, 22);
            tsddbQueueLooping.Text = "Looping";
            // 
            // tsmiNoLoop
            // 
            tsmiNoLoop.Name = "tsmiNoLoop";
            tsmiNoLoop.Size = new Size(141, 22);
            tsmiNoLoop.Text = "No Looping";
            tsmiNoLoop.Click += tsmiNoLoop_Click;
            // 
            // tsmiLoopOne
            // 
            tsmiLoopOne.Name = "tsmiLoopOne";
            tsmiLoopOne.Size = new Size(141, 22);
            tsmiLoopOne.Text = "Loop One";
            tsmiLoopOne.Click += tsmiLoopOne_Click;
            // 
            // tsmiLoopPlaylist
            // 
            tsmiLoopPlaylist.Checked = true;
            tsmiLoopPlaylist.CheckState = CheckState.Checked;
            tsmiLoopPlaylist.Name = "tsmiLoopPlaylist";
            tsmiLoopPlaylist.Size = new Size(141, 22);
            tsmiLoopPlaylist.Text = "Loop Playlist";
            tsmiLoopPlaylist.Click += tsmiLoopPlaylist_Click;
            // 
            // tsddbQueueRandom
            // 
            tsddbQueueRandom.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsddbQueueRandom.DropDownItems.AddRange(new ToolStripItem[] { tsmiNoRandom, tsmiNormalRandom, tsmiUniqueRandom });
            tsddbQueueRandom.Enabled = false;
            tsddbQueueRandom.Image = Resources.shuffle_100px;
            tsddbQueueRandom.ImageTransparentColor = Color.Magenta;
            tsddbQueueRandom.Name = "tsddbQueueRandom";
            tsddbQueueRandom.Size = new Size(29, 22);
            tsddbQueueRandom.Text = "Shuffle";
            // 
            // tsmiNoRandom
            // 
            tsmiNoRandom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsmiNoRandom.Name = "tsmiNoRandom";
            tsmiNoRandom.Size = new Size(180, 22);
            tsmiNoRandom.Text = "No Shuffle";
            tsmiNoRandom.Click += tsmiNoRandom_Click;
            // 
            // tsmiNormalRandom
            // 
            tsmiNormalRandom.Checked = true;
            tsmiNormalRandom.CheckState = CheckState.Checked;
            tsmiNormalRandom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsmiNormalRandom.Name = "tsmiNormalRandom";
            tsmiNormalRandom.Size = new Size(180, 22);
            tsmiNormalRandom.Text = "Normal Shuffle";
            tsmiNormalRandom.Click += tsmiNormmalRandom_Click;
            // 
            // tsmiUniqueRandom
            // 
            tsmiUniqueRandom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsmiUniqueRandom.Name = "tsmiUniqueRandom";
            tsmiUniqueRandom.Size = new Size(180, 22);
            tsmiUniqueRandom.Text = "Unique Shuffle";
            tsmiUniqueRandom.Click += tsmiUniqueRandom_Click;
            // 
            // pbAlbum
            // 
            pbAlbum.BackgroundImage = Resources.generic_music_file_100px;
            pbAlbum.BackgroundImageLayout = ImageLayout.Zoom;
            pbAlbum.BorderStyle = BorderStyle.FixedSingle;
            pbAlbum.Location = new Point(12, 28);
            pbAlbum.Name = "pbAlbum";
            pbAlbum.Size = new Size(114, 114);
            pbAlbum.TabIndex = 3;
            pbAlbum.TabStop = false;
            // 
            // lTitle
            // 
            lTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lTitle.Location = new Point(132, 28);
            lTitle.Name = "lTitle";
            lTitle.Size = new Size(311, 21);
            lTitle.TabIndex = 4;
            lTitle.Text = "Title";
            // 
            // lArtist
            // 
            lArtist.Location = new Point(132, 49);
            lArtist.Name = "lArtist";
            lArtist.Size = new Size(311, 15);
            lArtist.TabIndex = 5;
            lArtist.Text = "Artist";
            // 
            // lAlbum
            // 
            lAlbum.Location = new Point(132, 64);
            lAlbum.Name = "lAlbum";
            lAlbum.Size = new Size(311, 15);
            lAlbum.TabIndex = 6;
            lAlbum.Text = "Album";
            // 
            // lNumbers
            // 
            lNumbers.Location = new Point(132, 79);
            lNumbers.Name = "lNumbers";
            lNumbers.Size = new Size(311, 15);
            lNumbers.TabIndex = 7;
            lNumbers.Text = "#/#D/Y";
            // 
            // tbPosition
            // 
            tbPosition.Location = new Point(132, 97);
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new Size(311, 45);
            tbPosition.TabIndex = 8;
            tbPosition.TickFrequency = 60;
            tbPosition.TickStyle = TickStyle.Both;
            tbPosition.Scroll += tbPosition_Seek;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 148);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lbQueue);
            splitContainer1.Size = new Size(487, 403);
            splitContainer1.SplitterDistance = 243;
            splitContainer1.TabIndex = 9;
            // 
            // lbList
            // 
            lbList.ContextMenuStrip = cmsPlaylist;
            lbList.Dock = DockStyle.Fill;
            lbList.FormattingEnabled = true;
            lbList.HorizontalScrollbar = true;
            lbList.ItemHeight = 15;
            lbList.Location = new Point(0, 0);
            lbList.Name = "lbList";
            lbList.Size = new Size(243, 403);
            lbList.TabIndex = 0;
            lbList.DoubleClick += lbList_DoubleClick;
            // 
            // cmsPlaylist
            // 
            cmsPlaylist.Items.AddRange(new ToolStripItem[] { tsmiPlaylistPlay, tsmiPlaylistPlayNext, tssPlaylistMenu, tsmiRemoveFromPlaylist, tsmiPlaylistCleanPlaylist });
            cmsPlaylist.Name = "cmsPlaylist";
            cmsPlaylist.Size = new Size(187, 98);
            cmsPlaylist.Text = "Playlist Item";
            toolTip.SetToolTip(cmsPlaylist, "Playlist Item");
            // 
            // tsmiPlaylistPlay
            // 
            tsmiPlaylistPlay.Name = "tsmiPlaylistPlay";
            tsmiPlaylistPlay.Size = new Size(186, 22);
            tsmiPlaylistPlay.Text = "Play";
            tsmiPlaylistPlay.Click += lbList_DoubleClick;
            // 
            // tsmiPlaylistPlayNext
            // 
            tsmiPlaylistPlayNext.Name = "tsmiPlaylistPlayNext";
            tsmiPlaylistPlayNext.Size = new Size(186, 22);
            tsmiPlaylistPlayNext.Text = "Play Next";
            tsmiPlaylistPlayNext.Click += tsmiPlaylistPlayNext_Click;
            // 
            // tssPlaylistMenu
            // 
            tssPlaylistMenu.Name = "tssPlaylistMenu";
            tssPlaylistMenu.Size = new Size(183, 6);
            // 
            // tsmiRemoveFromPlaylist
            // 
            tsmiRemoveFromPlaylist.Name = "tsmiRemoveFromPlaylist";
            tsmiRemoveFromPlaylist.Size = new Size(186, 22);
            tsmiRemoveFromPlaylist.Text = "Remove from Playlist";
            tsmiRemoveFromPlaylist.Click += tsmiRemoveFromPlaylist_Click;
            // 
            // tsmiPlaylistCleanPlaylist
            // 
            tsmiPlaylistCleanPlaylist.Name = "tsmiPlaylistCleanPlaylist";
            tsmiPlaylistCleanPlaylist.Size = new Size(186, 22);
            tsmiPlaylistCleanPlaylist.Text = "Clean Playlist";
            tsmiPlaylistCleanPlaylist.Click += tsmiCleanPlaylist_Click;
            // 
            // lbQueue
            // 
            lbQueue.ContextMenuStrip = cmsQueue;
            lbQueue.Dock = DockStyle.Fill;
            lbQueue.FormattingEnabled = true;
            lbQueue.HorizontalScrollbar = true;
            lbQueue.ItemHeight = 15;
            lbQueue.Location = new Point(0, 0);
            lbQueue.Name = "lbQueue";
            lbQueue.Size = new Size(240, 403);
            lbQueue.TabIndex = 0;
            // 
            // cmsQueue
            // 
            cmsQueue.Items.AddRange(new ToolStripItem[] { tsmiQueuePlay, tsmiQueuePlayNext, tssQueue, tsmiMoveUp, tsmiMoveDown, tsmiRemoveFromQueue, tsmiQueueCleanQueue });
            cmsQueue.Name = "cmsQueue";
            cmsQueue.Size = new Size(185, 142);
            cmsQueue.Text = "Queue Item";
            toolTip.SetToolTip(cmsQueue, "Queue Item");
            // 
            // tsmiQueuePlay
            // 
            tsmiQueuePlay.Name = "tsmiQueuePlay";
            tsmiQueuePlay.Size = new Size(184, 22);
            tsmiQueuePlay.Text = "Play";
            tsmiQueuePlay.Click += tsmiQueuePlay_Click;
            // 
            // tsmiQueuePlayNext
            // 
            tsmiQueuePlayNext.Name = "tsmiQueuePlayNext";
            tsmiQueuePlayNext.Size = new Size(184, 22);
            tsmiQueuePlayNext.Text = "Play Next";
            tsmiQueuePlayNext.Click += tsmiQueuePlayNext_Click;
            // 
            // tssQueue
            // 
            tssQueue.Name = "tssQueue";
            tssQueue.Size = new Size(181, 6);
            // 
            // tsmiMoveUp
            // 
            tsmiMoveUp.Name = "tsmiMoveUp";
            tsmiMoveUp.Size = new Size(184, 22);
            tsmiMoveUp.Text = "Move Up";
            tsmiMoveUp.Click += tsmiMoveUp_Click;
            // 
            // tsmiMoveDown
            // 
            tsmiMoveDown.Name = "tsmiMoveDown";
            tsmiMoveDown.Size = new Size(184, 22);
            tsmiMoveDown.Text = "Move Down";
            tsmiMoveDown.Click += tsmiMoveDown_Click;
            // 
            // tsmiRemoveFromQueue
            // 
            tsmiRemoveFromQueue.Name = "tsmiRemoveFromQueue";
            tsmiRemoveFromQueue.Size = new Size(184, 22);
            tsmiRemoveFromQueue.Text = "Remove from Queue";
            tsmiRemoveFromQueue.Click += tsmiRemoveFromQueue_Click;
            // 
            // tsmiQueueCleanQueue
            // 
            tsmiQueueCleanQueue.Name = "tsmiQueueCleanQueue";
            tsmiQueueCleanQueue.Size = new Size(184, 22);
            tsmiQueueCleanQueue.Text = "Clean Queue";
            tsmiQueueCleanQueue.Click += tsmiCleanQueue_Click;
            // 
            // tControls
            // 
            tControls.Enabled = true;
            tControls.Interval = 750;
            tControls.Tick += tControls_Tick;
            // 
            // cmsSettings
            // 
            cmsSettings.Items.AddRange(new ToolStripItem[] { tsmiRestoreSession });
            cmsSettings.Name = "cmsSettings";
            cmsSettings.Size = new Size(185, 26);
            // 
            // tsmiRestoreSession
            // 
            tsmiRestoreSession.Checked = true;
            tsmiRestoreSession.CheckOnClick = true;
            tsmiRestoreSession.CheckState = CheckState.Checked;
            tsmiRestoreSession.Name = "tsmiRestoreSession";
            tsmiRestoreSession.Size = new Size(184, 22);
            tsmiRestoreSession.Text = "Restore Last Session?";
            tsmiRestoreSession.CheckedChanged += tsmiRestoreSession_CheckedChanged;
            // 
            // tbVolume
            // 
            tbVolume.Location = new Point(454, 28);
            tbVolume.Maximum = 100;
            tbVolume.Name = "tbVolume";
            tbVolume.Orientation = Orientation.Vertical;
            tbVolume.Size = new Size(45, 114);
            tbVolume.TabIndex = 11;
            tbVolume.TickFrequency = 10;
            tbVolume.TickStyle = TickStyle.Both;
            tbVolume.Value = 100;
            tbVolume.Scroll += tbVolume_ValueChanged;
            tbVolume.MouseUp += nudVolume_MouseClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 563);
            Controls.Add(tbVolume);
            Controls.Add(splitContainer1);
            Controls.Add(tbPosition);
            Controls.Add(lNumbers);
            Controls.Add(lAlbum);
            Controls.Add(lArtist);
            Controls.Add(lTitle);
            Controls.Add(pbAlbum);
            Controls.Add(tsTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.Manual;
            Text = "Endless";
            FormClosing += Main_FormClosing;
            tsTop.ResumeLayout(false);
            tsTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPosition).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            cmsPlaylist.ResumeLayout(false);
            cmsQueue.ResumeLayout(false);
            cmsSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsTop;
        private ToolStripButton tsbPrevious;
        private ToolStripSplitButton tssbAddSong;
        private ToolStripMenuItem tsmiOpenPlaylist;
        private ToolStripMenuItem tsmiOpenQueue;
        private ToolStripSplitButton tssbSavePlaylist;
        private ToolStripMenuItem tsmiSavePlaylist;
        private ToolStripMenuItem tsmiSaveQueue;
        private ToolStripSeparator tssBasic1;
        private ToolStripButton tsbSeekBack;
        private ToolStripButton tsbPlay;
        private ToolStripButton tsbPause;
        private ToolStripButton tsbStop;
        private ToolStripButton tsbSeekForward;
        private ToolStripButton tsbNext;
        private ToolStripSeparator tssBasic2;
        private ToolStripLabel tslDuration;
        private PictureBox pbAlbum;
        private Label lTitle;
        private Label lArtist;
        private Label lAlbum;
        private Label lNumbers;
        private TrackBar tbPosition;
        private SplitContainer splitContainer1;
        private ListBox lbList;
        private ListBox lbQueue;
        private ToolStripMenuItem tsmiAddFolder;
        private ToolStripMenuItem tsmiAddSong;
        private ToolStripSeparator tssAdd1;
        private ToolStripMenuItem tsmiOpenLastSession;
        private ToolTip toolTip;
        private ToolStripSeparator tssAdd2;
        private ToolStripMenuItem tsmiCleanPlaylist;
        private ToolStripMenuItem tsmiCleanQueue;
        private ContextMenuStrip cmsPlaylist;
        private ToolStripMenuItem tsmiPlaylistPlay;
        private ToolStripMenuItem tsmiPlaylistPlayNext;
        private ToolStripSeparator tssPlaylistMenu;
        private ToolStripMenuItem tsmiRemoveFromPlaylist;
        private ContextMenuStrip cmsQueue;
        private ToolStripMenuItem tsmiQueuePlay;
        private ToolStripMenuItem tsmiQueuePlayNext;
        private ToolStripSeparator tssQueue;
        private ToolStripMenuItem tsmiMoveUp;
        private ToolStripMenuItem tsmiMoveDown;
        private ToolStripMenuItem tsmiRemoveFromQueue;
        private System.Windows.Forms.Timer tControls;
        private ToolStripMenuItem tsmiSaveSession;
        private ToolStripMenuItem tsmiPlaylistCleanPlaylist;
        private ToolStripMenuItem tsmiQueueCleanQueue;
        private ContextMenuStrip cmsSettings;
        private ToolStripMenuItem tsmiRestoreSession;
        private ToolStripSeparator tssBasic3;
        private ToolStripDropDownButton tsddbQueueLooping;
        private ToolStripMenuItem tsmiNoLoop;
        private ToolStripMenuItem tsmiLoopOne;
        private ToolStripMenuItem tsmiLoopPlaylist;
        private ToolStripDropDownButton tsddbQueueRandom;
        private ToolStripMenuItem tsmiNoRandom;
        private ToolStripMenuItem tsmiUniqueRandom;
        private ToolStripMenuItem tsmiNormalRandom;
        private TrackBar tbVolume;
    }
}
