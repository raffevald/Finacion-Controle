using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ZeSistema___v2.src.DataBase
{
    internal class DBCadastrarDados
    {
        MySqlCommand command;
        MySqlConnection connection;
        public void ExQuerySQL(string strSQL)
        {
            try
            {
                DBConexao conexao = new DBConexao();
                connection = conexao.Conexao();
                connection.Open();
                command = new MySqlCommand(strSQL, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception error)
            {
                
            }
        }
    }
}
