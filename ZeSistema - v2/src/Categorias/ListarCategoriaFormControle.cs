using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeSistema___v2.src.Categorias
{
    internal class ListarCategoriaFormControle
    {
        public ListarCategoriaFormControle()
        {

        }

        public void MostrarFormListarCategorias()
        {
            ListarCategoriasForm listarCategoriasForm = new ListarCategoriasForm();
            listarCategoriasForm.ShowDialog();
        }
    }
}
