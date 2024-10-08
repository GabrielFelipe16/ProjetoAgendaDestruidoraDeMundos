namespace ProjetoAgendaDestruidoraDeMundos
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_cadastro janela_cadastro = new frm_cadastro();
            janela_cadastro.Show();
        }
    }
}
