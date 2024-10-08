using MySql.Data.MySqlClient;
using ProjetoAgendaDestruidoraDeMundos.Data;
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
            if (casoBotaoValido )
            {
                bt_cadastrar.Enabled = true;
            }
            else
            {
                bt_cadastrar.Enabled = false;
            }
        }

        private void cadastraUsuario()
        {
            MySqlConnection conn = ConexaoDB.CriaConexao();

            //abrindo a conexão
            conn.Open();

            //string para insert
            string sql = $"INSERT INTO usuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha)";

            //monta o comando sql
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", txt_campo_nome.Text);
            cmd.Parameters.AddWithValue("@usuario", txt_campo_usuario.Text);
            cmd.Parameters.AddWithValue("@telefone", txt_campo_telefone.Text);
            cmd.Parameters.AddWithValue("@senha", txt_campo_senha.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            cadastraUsuario();
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
            this.Close();
        }
    }
}
