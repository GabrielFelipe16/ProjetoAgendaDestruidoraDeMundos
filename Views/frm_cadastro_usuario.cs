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


    public partial class frm_cadastro_usuario : Form
    {
        private void AtualizaDataGrid()
        {
            UsuarioController getUsuarios = new UsuarioController();

            DataTable tabela = getUsuarios.GetUsuarios();

            dgv_usuario.DataSource = tabela;
        }

        public frm_cadastro_usuario()
        {
            InitializeComponent();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            frm_menu janela_menu = new frm_menu();
            this.Hide();
            janela_menu.ShowDialog();
        }

        private void frm_alterar_cadastro_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void frm_cadastro_usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            UsuarioController deleteUsuario = new UsuarioController();

            int usuarios = Convert.ToInt32(dgv_usuario.SelectedRows[0].Cells["Código"].Value);

            bool resultado = deleteUsuario.DropUsuario(usuarios);

            if (resultado == false)
            {
                MessageBox.Show("Falhou");
            }

            AtualizaDataGrid();
        }

        private void txt_campo_nome_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_campo_usuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_campo_telefone_TextChanged(object sender, EventArgs e)
        {
        }


        private void btn_alterar_senha_Click(object sender, EventArgs e)
        {

            UsuarioController updateCadastro = new UsuarioController();

            int usuarioId = Convert.ToInt32(dgv_usuario.SelectedRows[0].Cells["Código"].Value);

            bool resultado = updateCadastro.AlterCadastro(usuarioId, txt_campo_nome.Text, txt_campo_usuario.Text, txt_campo_telefone.Text, txt_alterar_senha.Text);

            if (resultado)
            {
                MessageBox.Show("Cadastro alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_usuario.SelectedRows.Count > 0)
            {
                string nome = Convert.ToString(dgv_usuario.SelectedRows[0].Cells["Nome"].Value);
                string usuario = Convert.ToString(dgv_usuario.SelectedRows[0].Cells["Usuários"].Value);
                string telefone = Convert.ToString(dgv_usuario.SelectedRows[0].Cells["Telefone"].Value);

                txt_campo_nome.Text = nome;
                txt_campo_usuario.Text = usuario;
                txt_campo_telefone.Text = telefone;
            }
        }
    }
}
