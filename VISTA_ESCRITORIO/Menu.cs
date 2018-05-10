using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA_ESCRITORIO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void jugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJugador frm =new frmJugador();
            frm.MdiParent = this;
            toolStripStatusLabel1.Text = "xx";
            frm.Show();

        }

        private void medallasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
