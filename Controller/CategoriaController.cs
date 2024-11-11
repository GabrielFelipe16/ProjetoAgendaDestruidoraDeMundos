using MySql.Data.MySqlClient;
using ProjetoAgendaDestruidoraDeMundos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendaDestruidoraDeMundos.Controller
{
    internal class CategoriaController
    {
        public bool CadastraCategoria(string categoria)
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO categorias (categoria) VALUES (@categoria);";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@categoria", categoria);

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
                catch (Exception e)
                {
                    MessageBox.Show($"Erro ao cadastrar: {e.Message}");
                    return false;
                }
            }
        }
    }
}
