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
    internal class DBAtualizarDados
    {

        private MySqlConnection connection;
        MySqlDataAdapter dataAdapter;

        public DBAtualizarDados()
        {

        }


        public void AtualizarDadosCategoria(string codigo, string descricao, string tipoDeCat, DateTime dataAtualizacao)
        {

            string categoriaDescricao;
            string categoriaData;
            string dataCategoria;
            string strSQL = "";
            string dataFormatForDB = "-";
            int categoriaID;
            string tipoDeCategoria;


            if (codigo != "")
            {
                categoriaDescricao = descricao;
                categoriaID = Convert.ToInt32(codigo);
                categoriaData = Convert.ToString(dataAtualizacao);
                dataCategoria = $"{categoriaData[6]}{categoriaData[7]}{categoriaData[8]}{categoriaData[9]}{dataFormatForDB}{categoriaData[3]}{categoriaData[4]}{dataFormatForDB}{categoriaData[0]}{categoriaData[1]}";
                tipoDeCategoria = tipoDeCat;


                if (descricao != "" & tipoDeCat != "")
                {
                    strSQL = $"UPDATE Categorias SET descricao_cat = '{categoriaDescricao}', data_de_atualizacao_cat = '{dataCategoria}', tipo_de_categoria_cat = '{tipoDeCategoria}' WHERE Categorias.id_cat = {categoriaID} and Categorias.id_usuario_fk = {LoginForm.dbUserId};";
                }
                else
                {
                    if (descricao != "" & tipoDeCat == "")
                    {
                        strSQL = $"UPDATE Categorias SET descricao_cat = '{categoriaDescricao}', data_de_atualizacao_cat = '{dataCategoria}' WHERE Categorias.id_cat = {categoriaID} and Categorias.id_usuario_fk = {LoginForm.dbUserId};";
                    } else
                    {
                        if (tipoDeCat != "" & descricao == "")
                        {
                            strSQL = $"UPDATE Categorias SET data_de_atualizacao_cat = '{dataCategoria}', tipo_de_categoria_cat = '{tipoDeCategoria}' WHERE Categorias.id_cat = {categoriaID} and Categorias.id_usuario_fk = {LoginForm.dbUserId};";
                        }
                    }
                }

                DBCadastrarDados cadastrarCategoriasReceitas = new DBCadastrarDados();
                cadastrarCategoriasReceitas.ExQuerySQL(strSQL);

            }

        }
    }       
}
