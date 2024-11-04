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
    public partial class frm_alterar_cadastro : Form
    {
        public frm_alterar_cadastro()
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
            
        }
    }
}
