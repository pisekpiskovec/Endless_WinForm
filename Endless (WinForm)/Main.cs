using System.ComponentModel;

namespace Endless__WinForm_
{
    public partial class Main : Form
    {
        BindingList<string> playlist = new BindingList<string>();
        BindingList<string> queue = new BindingList<string>();

        public Main()
        {
            InitializeComponent();
            lbList.DataSource = playlist;
            lbQueue.DataSource = queue;
        }

        private void tsmiAddSong_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdAddSong.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < ofdAddSong.FileNames.Count(); i++)
                    {
                        if (Path.GetExtension(ofdAddSong.FileNames[i]) == ".m3u")
                        {
                            String[] inputing = File.ReadAllLines(ofdAddSong.FileNames[i]);
                            foreach (string item in inputing) { playlist.Add(item); }
                        }
                        else { playlist.Add(ofdAddSong.FileNames[i]); }
                    }
                }
            }
            catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
