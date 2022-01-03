using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ZeSistema___v2.src.Login;
using MySql.Data;
using System.Data;
using ZeSistema___v2.src.Categorias;

namespace ZeSistema___v2.src.DataBase
{
    internal class DBListarDados
    {

        private MySqlConnection connection;
        MySqlDataAdapter dataAdapter;

        public MySqlDataAdapter ListagemDB(string strSQL)
        {
            try
            {
                DBConexao conexao = new DBConexao();
                connection = conexao.Conexao();
                connection.Open();

                dataAdapter = new MySqlDataAdapter(strSQL, connection);
                return dataAdapter;
            }
            catch (Exception error)
            {
                return null;
            }
        }

        public DataTable ListarCategoriasList()
        {
            try
            {
                string strSQL;
                int id_user_fk;

                LoginForm login = new LoginForm();
                DataTable dt = new DataTable();

                id_user_fk = LoginForm.dbUserId;

                strSQL = $"SELECT categorias.id_cat as 'Codigo', categorias.descricao_cat as 'Descrição', categorias.tipo_de_categoria_cat as 'Tipo de categoria', categorias.data_de_insercao_cat 'Data de cadastro', categorias.data_de_atualizacao_cat as 'Data de atualização' FROM categorias WHERE categorias.id_usuario_fk = '{id_user_fk}'";

                ListagemDB(strSQL);
                ListagemDB(strSQL).Fill(dt);

                return dt;

                strSQL = "";
            }
            catch (Exception error)
            {
                return null;
            }

        }

        public DataTable ListarCategoriasPorTipo(string tipoCat)
        {

            try
            {
                string strSQL;
                int id_user_fk;

                LoginForm login = new LoginForm();
                DataTable dt = new DataTable();

                id_user_fk = LoginForm.dbUserId;

                if (tipoCat == "Todos" | tipoCat == "Selecione o tipo de listagem")
                {
                    strSQL = $"SELECT categorias.id_cat as 'Codigo', categorias.descricao_cat as 'Descrição', categorias.tipo_de_categoria_cat as 'Tipo de categoria', categorias.data_de_insercao_cat 'Data de cadastro', categorias.data_de_atualizacao_cat as 'Data de atualização' FROM categorias WHERE categorias.id_usuario_fk = '{id_user_fk}'";
                } else
                {
                    strSQL = $"SELECT categorias.id_cat as 'Codigo', categorias.descricao_cat as 'Descrição', categorias.tipo_de_categoria_cat as 'Tipo de categoria', categorias.data_de_insercao_cat 'Data de cadastro', categorias.data_de_atualizacao_cat as 'Data de atualização' FROM categorias WHERE categorias.id_usuario_fk = '{id_user_fk}' and categorias.tipo_de_categoria_cat = '{tipoCat}'";
                }

                ListagemDB(strSQL);
                ListagemDB(strSQL).Fill(dt);

                return dt;

                strSQL = "";
            }
            catch (Exception error)
            {
                return null;
            }

        }

        public DataTable ListarTodosOsRecebimentos()
        {
            string strSQL;

            try
            {
                DataTable dt = new DataTable();

                strSQL = $"CALL ListarRecebimentos({LoginForm.dbUserId});";
                
                ListagemDB(strSQL);
                ListagemDB(strSQL).Fill(dt);

                return dt;

            } catch (Exception error)
            {
                return null;
            }
        }
    }
}
