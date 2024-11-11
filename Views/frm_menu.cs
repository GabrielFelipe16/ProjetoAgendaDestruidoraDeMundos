using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgendaDestruidoraDeMundos.Views
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastrar_categoria janela_cadastro_categoria = new frm_cadastrar_categoria();
            this.Hide();
            janela_cadastro_categoria.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_alterar_cadastro janela_alterar_cadastro = new frm_alterar_cadastro();
            this.Hide();
            janela_alterar_cadastro.ShowDialog();
        }

        private void frm_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
