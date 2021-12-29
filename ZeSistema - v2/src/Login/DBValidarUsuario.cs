using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ZeSistema___v2.src.DataBase;

namespace ZeSistema___v2.src.Login
{
    internal class DBValidarUsuario
    {
        private MySqlConnection connection;
        private MySqlCommand command;


        public DBValidarUsuario()
        {

        }
        public MySqlCommand ListagemDB(string strSQL)
        {
            DBConexao conexao = new DBConexao();
            connection = conexao.Conexao();
            connection.Open();

            command = new MySqlCommand(strSQL, connection);
            return command;
        }
    }
}
