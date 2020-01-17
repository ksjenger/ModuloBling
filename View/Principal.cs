using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloBling.View
{
    public partial class Principal : Form
    {
        public Principal(string usuario, string senha)
        {
            InitializeComponent();

        }

        private void ConfiguracoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracoes configuracoes = new Configuracoes();
            configuracoes.Show();
        }
    }
}
