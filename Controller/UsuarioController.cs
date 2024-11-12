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
    internal class UsuarioController
    {
        public bool addUsuario(string nome, string usuario, string telefone, string senha)
        {
            MySqlConnection conn = null;
            try
            {
                conn = ConexaoDB.CriaConexao();
                conn.Open();
                string sql = $"INSERT INTO usuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@senha", senha);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch (Exception e)
            {
                MessageBox.Show($"Erro ao cadastrar: {e.Message}");
                return false;
            }
            finally
            {
               conn.Close();
            }
            
        }

        public bool LoginUsuario(string usuario, string senha)
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true; // Retorna verdadeiro se o usuário foi encontrado
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha incorretos.");
                                return false; // Retorna falso se não encontrou
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro ao logar: {e.Message}");
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public DataTable GetUsuarios()
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    string sql = "SELECT idUsuario AS 'Código', nome AS 'Nome', usuario AS 'Usuários', telefone AS 'Telefone' FROM usuarios;";

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
                    MessageBox.Show($"ERRO AO RECUPERAR USUARIOS: {e.Message}");
                    return new DataTable();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool DropUsuario(int chavePrimaria)
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM usuarios WHERE idUsuario = @valor;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@valor", chavePrimaria);

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
                    MessageBox.Show($"Erro ao deletar: {e.Message}");
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
