using MySql.Data.MySqlClient;
using ProjetoAgendaDestruidoraDeMundos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendaDestruidoraDeMundos.Controller
{
    internal class UsuarioController
    {
        public bool addUsuario(string nome, string usuario, string telefone, string senha, string categoria)
        {
            MySqlConnection conn = ConexaoDB.CriaConexao();
            conn.Open();
            string sql = $"INSERT INTO usuarios (nome, usuario, telefone, senha, categoria VALUES (@nome, @usuario, @telefone, @senha, @categoria);";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
        }
    }
}
