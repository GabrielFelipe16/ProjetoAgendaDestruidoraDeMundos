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

        private void verificaCadastroValido()
        {
            //criando uma variavel booleana que faz as verificações de campos obrigatórios 
            bool casoBotaoValido = txt_campo_nome.Text != ""
               && txt_campo_usuario.Text != ""
               && txt_campo_senha.Text.Length >= 8
               && txt_campo_confirma_senha.Text == txt_campo_senha.Text;

            //verificando se a variavel criada acima retorna true or false
            if (casoBotaoValido)
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        private void ApagarCampos()
        {
            txt_campo_nome.Text = "";
            txt_campo_usuario.Text = "";
            txt_campo_telefone.Text = "";
            txt_campo_senha.Text = "";
            txt_campo_confirma_senha.Text = "";
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
            UsuarioController cadastra = new UsuarioController();
            bool resultado = cadastra.addUsuario(txt_campo_nome.Text, txt_campo_usuario.Text, txt_campo_telefone.Text, txt_campo_senha.Text);

            if (resultado == false)
            {
                DialogResult mensagemErro = MessageBox.Show("Erro ao cadastrar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizaDataGrid();

            ApagarCampos();
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
            verificaCadastroValido();
        }

        private void txt_campo_usuario_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_telefone_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_senha_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_confirma_senha_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }
    }
}
