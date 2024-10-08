using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendaDestruidoraDeMundos.Data
{
    static internal class ConexaoDB
    {
        static public MySqlConnection CriaConexao() {

            //String com informações para conexão
            string strConn = "Server=localhost;Database=dbagenda;User ID=root;password=root;";

            //iniciando uma conexão com o banco de dados
            MySqlConnection conn = new MySqlConnection(strConn);

            return conn;

        }
    }
}
