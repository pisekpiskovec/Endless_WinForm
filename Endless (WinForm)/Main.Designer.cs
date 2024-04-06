namespace Endless__WinForm_
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
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiOpenPlaylist = new ToolStripMenuItem();
            tsmiOpenQueue = new ToolStripMenuItem();
            tsmiOpenLastSession = new ToolStripMenuItem();
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
            lbQueue = new ListBox();
            nudVolume = new NumericUpDown();
            toolTip = new ToolTip(components);
            tsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            tssbAddSong.DropDownItems.AddRange(new ToolStripItem[] { tsmiAddFolder, tsmiAddSong, toolStripSeparator1, tsmiOpenPlaylist, tsmiOpenQueue, tsmiOpenLastSession });
            tssbAddSong.Enabled = false;
            tssbAddSong.Image = (Image)resources.GetObject("tssbAddSong.Image");
            tssbAddSong.ImageTransparentColor = Color.Magenta;
            tssbAddSong.Name = "tssbAddSong";
            tssbAddSong.Size = new Size(32, 22);
            tssbAddSong.Text = "Add Song";
            // 
            // tsmiAddFolder
            // 
            tsmiAddFolder.Enabled = false;
            tsmiAddFolder.Name = "tsmiAddFolder";
            tsmiAddFolder.Size = new Size(165, 22);
            tsmiAddFolder.Text = "Add Folder";
            // 
            // tsmiAddSong
            // 
            tsmiAddSong.Enabled = false;
            tsmiAddSong.Name = "tsmiAddSong";
            tsmiAddSong.Size = new Size(165, 22);
            tsmiAddSong.Text = "Add Song";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(162, 6);
            // 
            // tsmiOpenPlaylist
            // 
            tsmiOpenPlaylist.Enabled = false;
            tsmiOpenPlaylist.Name = "tsmiOpenPlaylist";
            tsmiOpenPlaylist.Size = new Size(165, 22);
            tsmiOpenPlaylist.Text = "Open Playlist";
            // 
            // tsmiOpenQueue
            // 
            tsmiOpenQueue.Enabled = false;
            tsmiOpenQueue.Name = "tsmiOpenQueue";
            tsmiOpenQueue.Size = new Size(165, 22);
            tsmiOpenQueue.Text = "Open Queue";
            // 
            // tsmiOpenLastSession
            // 
            tsmiOpenLastSession.Enabled = false;
            tsmiOpenLastSession.Name = "tsmiOpenLastSession";
            tsmiOpenLastSession.Size = new Size(165, 22);
            tsmiOpenLastSession.Text = "Open last session";
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
            // 
            // tssBasic2
            // 
            tssBasic2.Name = "tssBasic2";
            tssBasic2.Size = new Size(6, 25);
            // 
            // tslDuration
            // 
            tslDuration.Enabled = false;
            tslDuration.Name = "tslDuration";
            tslDuration.Size = new Size(66, 22);
            tslDuration.Text = "00:00/00:00";
            tslDuration.ToolTipText = "Click to open Settings.";
            // 
            // pbAlbum
            // 
            pbAlbum.BorderStyle = BorderStyle.FixedSingle;
            pbAlbum.Enabled = false;
            pbAlbum.Location = new Point(12, 28);
            pbAlbum.Name = "pbAlbum";
            pbAlbum.Size = new Size(114, 114);
            pbAlbum.TabIndex = 3;
            pbAlbum.TabStop = false;
            // 
            // lTitle
            // 
            lTitle.AutoSize = true;
            lTitle.Enabled = false;
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
            lArtist.Enabled = false;
            lArtist.Location = new Point(132, 49);
            lArtist.Name = "lArtist";
            lArtist.Size = new Size(35, 15);
            lArtist.TabIndex = 5;
            lArtist.Text = "Artist";
            // 
            // lAlbum
            // 
            lAlbum.AutoSize = true;
            lAlbum.Enabled = false;
            lAlbum.Location = new Point(132, 64);
            lAlbum.Name = "lAlbum";
            lAlbum.Size = new Size(43, 15);
            lAlbum.TabIndex = 6;
            lAlbum.Text = "Album";
            // 
            // lNumbers
            // 
            lNumbers.AutoSize = true;
            lNumbers.Enabled = false;
            lNumbers.Location = new Point(132, 79);
            lNumbers.Name = "lNumbers";
            lNumbers.Size = new Size(46, 15);
            lNumbers.TabIndex = 7;
            lNumbers.Text = "#/#D/Y";
            // 
            // tbPosition
            // 
            tbPosition.Enabled = false;
            tbPosition.Location = new Point(132, 97);
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new Size(311, 45);
            tbPosition.TabIndex = 8;
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
            lbList.Dock = DockStyle.Fill;
            lbList.FormattingEnabled = true;
            lbList.ItemHeight = 15;
            lbList.Location = new Point(0, 0);
            lbList.Name = "lbList";
            lbList.Size = new Size(243, 403);
            lbList.TabIndex = 0;
            // 
            // lbQueue
            // 
            lbQueue.Dock = DockStyle.Fill;
            lbQueue.FormattingEnabled = true;
            lbQueue.ItemHeight = 15;
            lbQueue.Location = new Point(0, 0);
            lbQueue.Name = "lbQueue";
            lbQueue.Size = new Size(240, 403);
            lbQueue.TabIndex = 0;
            // 
            // nudVolume
            // 
            nudVolume.Enabled = false;
            nudVolume.Location = new Point(449, 105);
            nudVolume.Name = "nudVolume";
            nudVolume.Size = new Size(50, 23);
            nudVolume.TabIndex = 10;
            nudVolume.Tag = "";
            toolTip.SetToolTip(nudVolume, "Volume");
            nudVolume.Value = new decimal(new int[] { 100, 0, 0, 0 });
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
            Text = "Endles";
            tsTop.ResumeLayout(false);
            tsTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPosition).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiOpenLastSession;
        private ToolTip toolTip;
    }
}
