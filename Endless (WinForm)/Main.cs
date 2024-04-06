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

        private void fileLoad(string FileName)
        {
            if (Path.GetExtension(FileName) == ".m3u")
            {
                string[] inputing = File.ReadAllLines(FileName);
                foreach (string item in inputing) { fileLoad(item); }
            }
            else { playlist.Add(FileName); }
        }

        private void tsmiAddSong_Click(object sender, EventArgs e)
        {
            try { if (ofdAddSong.ShowDialog() == DialogResult.OK) { for (int i = 0; i < ofdAddSong.FileNames.Count(); i++) { fileLoad(ofdAddSong.FileNames[i]); } } }
            catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
