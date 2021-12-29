using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ZeSistema___v2.src.Login;

namespace ZeSistema___v2.src.DataBase
{
    internal class DBConexao
    {
        private static string host = LoginForm.DBhost;
        private static string port = LoginForm.DBport;
        private static string user = LoginForm.DBuser;
        private static string password = LoginForm.DBpassword;
        private static string dbName = LoginForm.DBName;
        private MySqlConnection connection;

        public DBConexao()
        {

        }

        public MySqlConnection Conexao()
        {
            try
            {
                connection = new MySqlConnection($"server={host};database={dbName};port={port};user={user};password={password}");
                return connection;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
