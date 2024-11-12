using MySql.Data.MySqlClient;
using ProjetoAgendaDestruidoraDeMundos.Controller;
using ProjetoAgendaDestruidoraDeMundos.Data;
using ProjetoAgendaDestruidoraDeMundos.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgendaDestruidoraDeMundos
{
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
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
                bt_cadastrar.Enabled = true;
            }
            else
            {
                bt_cadastrar.Enabled = false;
            }
        }



        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            UsuarioController cadastra = new UsuarioController();
            bool resultado = cadastra.addUsuario(txt_campo_nome.Text, txt_campo_usuario.Text, txt_campo_telefone.Text, txt_campo_senha.Text);

            if (resultado == true)
            {
                DialogResult mensagemEfetuado = MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (mensagemEfetuado == DialogResult.OK)
                {
                    frm_login janela_login = new frm_login();
                    this.Hide();
                    janela_login.ShowDialog();
                }
            }
            else
            {
                DialogResult mensagemErro = MessageBox.Show("Erro ao cadastrar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void bt_cancelar_Click_1(object sender, EventArgs e)
        {
            frm_menu janela_menu = new frm_menu();
            this.Hide();
            janela_menu.ShowDialog();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void frm_cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
