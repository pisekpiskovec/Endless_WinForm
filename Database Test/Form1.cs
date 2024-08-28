using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playlistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void playlistBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.playlistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'databaseDataSet.Playlist'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.playlistTableAdapter.Fill(this.databaseDataSet.Playlist);

        }
    }
}
