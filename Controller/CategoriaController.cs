using MySql.Data.MySqlClient;
using ProjetoAgendaDestruidoraDeMundos.Data;
using System;
using System.Collections.Generic;
using System.Data;
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
                finally
                {
                    conn.Close();
                }
            }
        }

        public DataTable GetCategorias()
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    string sql = "SELECT id_categoria AS 'Código', categoria AS 'Categorias';";

                    conn.Open();

                    //cria um adaptador
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                    //cria uma tabela vazia
                    DataTable tabela = new DataTable();

                    //pede para o adaptador preencher a tabela 
                    adapter.Fill(tabela);

                    //retorna a tabela
                    return tabela;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"ERRO AO RECUPERAR CATEGORIAS: {e.Message}");
                    return new DataTable();
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
