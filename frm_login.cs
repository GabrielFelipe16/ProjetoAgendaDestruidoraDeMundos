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
    }
}
