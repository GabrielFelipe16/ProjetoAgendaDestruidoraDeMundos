using ProjetoAgendaDestruidoraDeMundos.Controller;
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
    public partial class frm_cadastrar_categoria : Form
    {
        public frm_cadastrar_categoria()
        {
            InitializeComponent();
        }

        private void frm_cadastrar_categoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CategoriaController cadastraCategoria = new CategoriaController();

            bool resultado = cadastraCategoria.CadastraCategoria(txt_categoria.Text);

            if (resultado == true)
            {
                DialogResult mensagemEfetuado = MessageBox.Show("Cadastro de categoria efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult mensagemErro = MessageBox.Show("Erro ao cadastrar a categoria", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CategoriaController getCategorias = new CategoriaController();

            DataTable tabela = getCategorias.GetCategorias();

            dgv_Categoria.DataSource = tabela;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_cadastrar_categoria_Load(object sender, EventArgs e)
        {
            CategoriaController getCategorias = new CategoriaController();

            DataTable tabela = getCategorias.GetCategorias();

            dgv_Categoria.DataSource = tabela;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_menu janela_menu =  new frm_menu();
            this.Hide();
            janela_menu.ShowDialog();
        }
    }
}
