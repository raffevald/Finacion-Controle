using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeSistema___v2.src.Login;

namespace ZeSistema___v2.src.DataBase
{
    internal class DBDeletarDados
    {
        public DBDeletarDados()
        {

        }

        public void DeletarCategoria(string codigoCat)
        {
            if (codigoCat != "")
            {
                string strSQL;
                int categoriaID;

                categoriaID = Convert.ToInt32(codigoCat);

                strSQL = $"DELETE from Categorias WHERE Categorias.id_cat = {categoriaID} and Categorias.id_usuario_fk = {LoginForm.dbUserId};";
                DBCadastrarDados cadastrarCategoriasReceitas = new DBCadastrarDados();
                cadastrarCategoriasReceitas.ExQuerySQL(strSQL);

            }

        }
    }
}
