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
        public bool addUsuario(string nome, string usuario, string telefone, string senha)
        {
            MySqlConnection conn = ConexaoDB.CriaConexao();
            conn.Open();
            string sql = $"INSERT INTO usuarios (nome, usuario, telefone, senha VALUES (@nome, @usuario, @telefone, @senha);";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@senha", senha);

            int linhasAfetadas = cmd.ExecuteNonQuery();

            conn.Close();

            if (linhasAfetadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
