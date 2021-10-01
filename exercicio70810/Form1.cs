using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio70810
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }

        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInclusao inclusao = new frmInclusao();
            inclusao.MdiParent = this;
            inclusao.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void janelaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
