﻿namespace Endless__WinForm_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            lbQueue = new ListBox();
            cmsQueue = new ContextMenuStrip(components);
            tsmiQueuePlay = new ToolStripMenuItem();
            tsmiQueuePlayNext = new ToolStripMenuItem();
            tssQueue = new ToolStripSeparator();
            tsmiMoveUp = new ToolStripMenuItem();
            tsmiMoveDown = new ToolStripMenuItem();
            tsmiRemoveFromQueue = new ToolStripMenuItem();
            nudVolume = new NumericUpDown();
            toolTip = new ToolTip(components);
            ofdAddSong = new OpenFileDialog();
            tDuration = new System.Windows.Forms.Timer(components);
            tControls = new System.Windows.Forms.Timer(components);
            tsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            cmsPlaylist.SuspendLayout();
            cmsQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudVolume).BeginInit();
            SuspendLayout();
            // 
            // tsTop
            // 
            tsTop.Items.AddRange(new ToolStripItem[] { tssbAddSong, tssbSavePlaylist, tssBasic1, tsbPrevious, tsbSeekBack, tsbPlay, tsbPause, tsbStop, tsbSeekForward, tsbNext, tssBasic2, tslDuration });
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
            tssbAddSong.Image = (Image)resources.GetObject("tssbAddSong.Image");
            tssbAddSong.ImageTransparentColor = Color.Magenta;
            tssbAddSong.Name = "tssbAddSong";
            tssbAddSong.Size = new Size(32, 22);
            tssbAddSong.Text = "Add Song";
            tssbAddSong.ButtonClick += tsmiAddSong_Click;
            // 
            // tsmiAddFolder
            // 
            tsmiAddFolder.Enabled = false;
            tsmiAddFolder.Name = "tsmiAddFolder";
            tsmiAddFolder.Size = new Size(182, 22);
            tsmiAddFolder.Text = "Add Folder";
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
            tsmiOpenPlaylist.Enabled = false;
            tsmiOpenPlaylist.Name = "tsmiOpenPlaylist";
            tsmiOpenPlaylist.Size = new Size(182, 22);
            tsmiOpenPlaylist.Text = "Open Playlist";
            // 
            // tsmiOpenQueue
            // 
            tsmiOpenQueue.Enabled = false;
            tsmiOpenQueue.Name = "tsmiOpenQueue";
            tsmiOpenQueue.Size = new Size(182, 22);
            tsmiOpenQueue.Text = "Open Queue";
            // 
            // tsmiOpenLastSession
            // 
            tsmiOpenLastSession.Enabled = false;
            tsmiOpenLastSession.Name = "tsmiOpenLastSession";
            tsmiOpenLastSession.Size = new Size(182, 22);
            tsmiOpenLastSession.Text = "Open Last Session";
            // 
            // tssAdd2
            // 
            tssAdd2.Name = "tssAdd2";
            tssAdd2.Size = new Size(179, 6);
            // 
            // tsmiCleanPlaylist
            // 
            tsmiCleanPlaylist.Enabled = false;
            tsmiCleanPlaylist.Name = "tsmiCleanPlaylist";
            tsmiCleanPlaylist.Size = new Size(182, 22);
            tsmiCleanPlaylist.Text = "Clean Playlist";
            // 
            // tsmiCleanQueue
            // 
            tsmiCleanQueue.Enabled = false;
            tsmiCleanQueue.Name = "tsmiCleanQueue";
            tsmiCleanQueue.ShortcutKeyDisplayString = "Ctrl+L";
            tsmiCleanQueue.Size = new Size(182, 22);
            tsmiCleanQueue.Text = "Clean Queue";
            // 
            // tssbSavePlaylist
            // 
            tssbSavePlaylist.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbSavePlaylist.DropDownItems.AddRange(new ToolStripItem[] { tsmiSavePlaylist, tsmiSaveQueue });
            tssbSavePlaylist.Enabled = false;
            tssbSavePlaylist.Image = (Image)resources.GetObject("tssbSavePlaylist.Image");
            tssbSavePlaylist.ImageTransparentColor = Color.Magenta;
            tssbSavePlaylist.Name = "tssbSavePlaylist";
            tssbSavePlaylist.Size = new Size(32, 22);
            tssbSavePlaylist.Text = "Save Playlist";
            // 
            // tsmiSavePlaylist
            // 
            tsmiSavePlaylist.Enabled = false;
            tsmiSavePlaylist.Name = "tsmiSavePlaylist";
            tsmiSavePlaylist.Size = new Size(138, 22);
            tsmiSavePlaylist.Text = "Save Playlist";
            // 
            // tsmiSaveQueue
            // 
            tsmiSaveQueue.Enabled = false;
            tsmiSaveQueue.Name = "tsmiSaveQueue";
            tsmiSaveQueue.Size = new Size(138, 22);
            tsmiSaveQueue.Text = "Save Queue";
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
            tsbPrevious.Image = (Image)resources.GetObject("tsbPrevious.Image");
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
            tsbSeekBack.Image = (Image)resources.GetObject("tsbSeekBack.Image");
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
            tsbPlay.Image = (Image)resources.GetObject("tsbPlay.Image");
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
            tsbPause.Image = (Image)resources.GetObject("tsbPause.Image");
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
            tsbStop.Image = (Image)resources.GetObject("tsbStop.Image");
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
            tsbSeekForward.Image = (Image)resources.GetObject("tsbSeekForward.Image");
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
            tsbNext.Image = (Image)resources.GetObject("tsbNext.Image");
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
            // 
            // pbAlbum
            // 
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
            lTitle.AutoSize = true;
            lTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lTitle.Location = new Point(132, 28);
            lTitle.Name = "lTitle";
            lTitle.Size = new Size(39, 21);
            lTitle.TabIndex = 4;
            lTitle.Text = "Title";
            // 
            // lArtist
            // 
            lArtist.AutoSize = true;
            lArtist.Location = new Point(132, 49);
            lArtist.Name = "lArtist";
            lArtist.Size = new Size(35, 15);
            lArtist.TabIndex = 5;
            lArtist.Text = "Artist";
            // 
            // lAlbum
            // 
            lAlbum.AutoSize = true;
            lAlbum.Location = new Point(132, 64);
            lAlbum.Name = "lAlbum";
            lAlbum.Size = new Size(43, 15);
            lAlbum.TabIndex = 6;
            lAlbum.Text = "Album";
            // 
            // lNumbers
            // 
            lNumbers.AutoSize = true;
            lNumbers.Location = new Point(132, 79);
            lNumbers.Name = "lNumbers";
            lNumbers.Size = new Size(46, 15);
            lNumbers.TabIndex = 7;
            lNumbers.Text = "#/#D/Y";
            // 
            // tbPosition
            // 
            tbPosition.Location = new Point(132, 97);
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new Size(311, 45);
            tbPosition.TabIndex = 8;
            tbPosition.TickFrequency = 5;
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
            lbList.ItemHeight = 15;
            lbList.Location = new Point(0, 0);
            lbList.Name = "lbList";
            lbList.Size = new Size(243, 403);
            lbList.TabIndex = 0;
            lbList.DoubleClick += lbList_DoubleClick;
            // 
            // cmsPlaylist
            // 
            cmsPlaylist.Items.AddRange(new ToolStripItem[] { tsmiPlaylistPlay, tsmiPlaylistPlayNext, tssPlaylistMenu, tsmiRemoveFromPlaylist });
            cmsPlaylist.Name = "cmsPlaylist";
            cmsPlaylist.Size = new Size(187, 76);
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
            tsmiPlaylistPlayNext.Enabled = false;
            tsmiPlaylistPlayNext.Name = "tsmiPlaylistPlayNext";
            tsmiPlaylistPlayNext.Size = new Size(186, 22);
            tsmiPlaylistPlayNext.Text = "Play Next";
            // 
            // tssPlaylistMenu
            // 
            tssPlaylistMenu.Name = "tssPlaylistMenu";
            tssPlaylistMenu.Size = new Size(183, 6);
            // 
            // tsmiRemoveFromPlaylist
            // 
            tsmiRemoveFromPlaylist.Enabled = false;
            tsmiRemoveFromPlaylist.Name = "tsmiRemoveFromPlaylist";
            tsmiRemoveFromPlaylist.Size = new Size(186, 22);
            tsmiRemoveFromPlaylist.Text = "Remove from Playlist";
            // 
            // lbQueue
            // 
            lbQueue.ContextMenuStrip = cmsQueue;
            lbQueue.Dock = DockStyle.Fill;
            lbQueue.FormattingEnabled = true;
            lbQueue.ItemHeight = 15;
            lbQueue.Location = new Point(0, 0);
            lbQueue.Name = "lbQueue";
            lbQueue.Size = new Size(240, 403);
            lbQueue.TabIndex = 0;
            // 
            // cmsQueue
            // 
            cmsQueue.Items.AddRange(new ToolStripItem[] { tsmiQueuePlay, tsmiQueuePlayNext, tssQueue, tsmiMoveUp, tsmiMoveDown, tsmiRemoveFromQueue });
            cmsQueue.Name = "cmsQueue";
            cmsQueue.Size = new Size(185, 120);
            cmsQueue.Text = "Queue Item";
            toolTip.SetToolTip(cmsQueue, "Queue Item");
            // 
            // tsmiQueuePlay
            // 
            tsmiQueuePlay.Name = "tsmiQueuePlay";
            tsmiQueuePlay.Size = new Size(184, 22);
            tsmiQueuePlay.Text = "Play";
            tsmiQueuePlay.Click += lbList_DoubleClick;
            // 
            // tsmiQueuePlayNext
            // 
            tsmiQueuePlayNext.Enabled = false;
            tsmiQueuePlayNext.Name = "tsmiQueuePlayNext";
            tsmiQueuePlayNext.Size = new Size(184, 22);
            tsmiQueuePlayNext.Text = "Play Next";
            // 
            // tssQueue
            // 
            tssQueue.Name = "tssQueue";
            tssQueue.Size = new Size(181, 6);
            // 
            // tsmiMoveUp
            // 
            tsmiMoveUp.Enabled = false;
            tsmiMoveUp.Name = "tsmiMoveUp";
            tsmiMoveUp.Size = new Size(184, 22);
            tsmiMoveUp.Text = "Move Up";
            // 
            // tsmiMoveDown
            // 
            tsmiMoveDown.Enabled = false;
            tsmiMoveDown.Name = "tsmiMoveDown";
            tsmiMoveDown.Size = new Size(184, 22);
            tsmiMoveDown.Text = "Move Down";
            // 
            // tsmiRemoveFromQueue
            // 
            tsmiRemoveFromQueue.Enabled = false;
            tsmiRemoveFromQueue.Name = "tsmiRemoveFromQueue";
            tsmiRemoveFromQueue.Size = new Size(184, 22);
            tsmiRemoveFromQueue.Text = "Remove from Queue";
            // 
            // nudVolume
            // 
            nudVolume.Location = new Point(449, 105);
            nudVolume.Name = "nudVolume";
            nudVolume.Size = new Size(50, 23);
            nudVolume.TabIndex = 10;
            nudVolume.Tag = "";
            toolTip.SetToolTip(nudVolume, "Volume\r\nPress Middle Mouse Button to toggle Mute.");
            nudVolume.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudVolume.ValueChanged += nudVolume_ValueChanged;
            nudVolume.MouseUp += nudVolume_MouseClick;
            // 
            // ofdAddSong
            // 
            ofdAddSong.DefaultExt = "mp3";
            ofdAddSong.Filter = "MP3 files|*.mp3";
            ofdAddSong.InitialDirectory = "E:\\Dokumenty Vojta\\Hudba";
            ofdAddSong.Multiselect = true;
            ofdAddSong.RestoreDirectory = true;
            ofdAddSong.Title = "Add Song...";
            // 
            // tDuration
            // 
            tDuration.Interval = 750;
            tDuration.Tick += tDuration_Tick;
            // 
            // tControls
            // 
            tControls.Enabled = true;
            tControls.Interval = 750;
            tControls.Tick += tControls_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 563);
            Controls.Add(nudVolume);
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
            ((System.ComponentModel.ISupportInitialize)nudVolume).EndInit();
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
        private NumericUpDown nudVolume;
        private ListBox lbQueue;
        private ToolStripMenuItem tsmiAddFolder;
        private ToolStripMenuItem tsmiAddSong;
        private ToolStripSeparator tssAdd1;
        private ToolStripMenuItem tsmiOpenLastSession;
        private ToolTip toolTip;
        private OpenFileDialog ofdAddSong;
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
        private System.Windows.Forms.Timer tDuration;
        private System.Windows.Forms.Timer tControls;
    }
}
