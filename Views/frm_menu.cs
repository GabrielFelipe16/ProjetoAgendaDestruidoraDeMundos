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

        private void bt_alterar_cadastro_Click(object sender, EventArgs e)
        {
            frm_alterar_cadastro janela_alterar_cadastro = new frm_alterar_cadastro();
            this.Hide();
            janela_alterar_cadastro.ShowDialog();
        }

        private void bt_deletar_cadastro_Click(object sender, EventArgs e)
        {
            frm_deletar_cadastro janela_deletar_cadastro = new frm_deletar_cadastro();
            this.Hide();
            janela_deletar_cadastro.ShowDialog();
        }
    }
}
