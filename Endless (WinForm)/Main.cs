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
    }
}
