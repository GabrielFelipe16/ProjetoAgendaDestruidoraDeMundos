using MySql.Data.MySqlClient;
using ProjetoAgendaDestruidoraDeMundos.Controller;
using ProjetoAgendaDestruidoraDeMundos.Views;

namespace ProjetoAgendaDestruidoraDeMundos
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void verificaLogin()
        {
            if (txt_campo_senha.Text.Length >= 8 && txt_campo_usuario.Text != "")
            {
                bt_logar.Enabled = true;
            }
            else
            {
                bt_logar.Enabled = false;
            }
        }


        private void lbl_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_cadastro janela_cadastro = new frm_cadastro();
            this.Hide();
            janela_cadastro.Show();
        }

        private void txt_campo_senha_TextChanged(object sender, EventArgs e)
        {

            verificaLogin();

        }

        private void txt_campo_usuario_TextChanged(object sender, EventArgs e)
        {

            verificaLogin();
        }

        private void bt_logar_Click(object sender, EventArgs e)
        {
            UsuarioController buscaUsuario = new UsuarioController();

            bool resultado = buscaUsuario.LoginUsuario(txt_campo_usuario.Text, txt_campo_senha.Text);

            if (resultado == true)
            {
                DialogResult mensagemEfetuado = MessageBox.Show("Login efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (mensagemEfetuado == DialogResult.OK)
                {
                    frm_menu janela_menu = new frm_menu();
                    this.Hide();
                    janela_menu.ShowDialog();
                }
            }
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
